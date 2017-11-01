namespace MyTend.Controllers
{
    using MyTend.Attributes;
    using MyTend.Entites.Block;
    using MyTend.Models;
    using MyTender.Core;
    using MyTender.Security;
    using System;
    using System.Web.Mvc;
    using System.Linq;
    using MyTend.Services.EmailService;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net;

    public class AccountController : BaseController
    {
        /// <summary>
        /// Профиль
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return RedirectToAction("Profile");
        }

        public ActionResult Profile(string tab)
        {
            var model = new ProfileModel(this.Auth.User);
            this.ViewBag.OpenTabParam = tab;
            return View(model);
        }

        public ActionResult Card(string user, string tab)
        {
            this.ViewBag.NoIndexing = true;

            var model = new CardModel(user);
            this.ViewBag.OpenTabParam = tab;
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateProfiles(ProfileModel model)
        {
            model.AddProfile(this.Auth.User);

            return RedirectToAction("Card", new { @user = this.Auth.User.Login, @tab = "tab5-3" });
        }

        [HttpPost]
        public JsonResult UpdateProfile(ProfileModel model)
        {
            if (model != null)
            {
                try
                {
                    model.UpdateProfile();
                }
                catch(Exception e)
                {
                    return JsonFailur(e.Message);
                }
            }
            return JsonSuccess();
        }

        [HttpPost]
        public JsonResult UpdateSubRegions(SubRegionModel model)
        {
            model.Save(this.Auth.User);

            return JsonSuccess();
        }

        [HttpPost]
        public JsonResult UpdateSubThemes(SubThemesModel model)
        {
            model.Save(this.Auth.User);

            return JsonSuccess();
        }

        public ActionResult OnlyForSub()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RemovePortfile(int? id, int? userId)
        {
            var model = new ProfileModel(this.Auth.User);

            if (id.HasValue && userId.HasValue)
            {
                try
                {
                    model.RemovePortfile(id.Value, userId.Value);
                    return JsonSuccess();
                }
                catch (Exception e)
                {
                    return JsonFailur(e);
                }
            }

            return View(model);
        }

        [HttpPost]
        public JsonResult GetSubThemes()
        {
            var model = new SubThemesModel();

            model.Load(this.Auth.User);

            return JsonSuccess(model.ListThemes);
        }

        [HttpPost]
        public JsonResult UpdateAbout(string portfolio)
        {
            var model = new ProfileModel(this.Auth.User);

            model.UpdateAbout(portfolio);

            return JsonSuccess();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            if (this.Auth.User != null)
            {
                return RedirectToAction("Profile");
            }

            var model = new RegistrationModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Registration(RegistrationModel model)
        {
            var response = Request["g-recaptcha-response"];
            //secret that was generated in key value pair
            const string secret = "6LfVYTYUAAAAABYdK2aq2YMOVn1453mlkfuCtYmM";

            var client = new WebClient();
            var reply =
                client.DownloadString(
                    string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secret, response));

            var captchaResponse = JsonConvert.DeserializeObject<CaptchaResponse>(reply);

            //when response is false check for the error message
            if (!captchaResponse.Success)
            {
                if (captchaResponse.ErrorCodes.Count <= 0) return View();

                var error = captchaResponse.ErrorCodes[0].ToLower();
                switch (error)
                {
                    case ("missing-input-secret"):
                        model.Errors.Add("The secret parameter is missing.");
                        break;
                    case ("invalid-input-secret"):
                        model.Errors.Add("The secret parameter is invalid or malformed.");
                        break;

                    case ("missing-input-response"):
                        model.Errors.Add("The response parameter is missing.");
                        break;
                    case ("invalid-input-response"):
                        model.Errors.Add("The response parameter is invalid or malformed.");
                        break;

                    default:
                        model.Errors.Add("Error occured. Please try again");
                        break;
                }
            }
            else
            {
                if (model.TryRegistry())
                {
                    this.Auth.Login(model.Login, model.Password);

                    try
                    {
                        var emailService = new EmailService(model.Login);
                        emailService.Registration(model.FullName, model.Login, model.Password);
                    }
                    catch
                    {

                    }
                }
            }

            

            if (model.Errors.Count > 0)
            {
                return View(model);
            }

            return RedirectToAction("Welcom");
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string login, string password)
        {
            if (!string.IsNullOrEmpty(login) &&
                !string.IsNullOrEmpty(password))
            {
                try
                {
                    this.Auth.Login(login, password);

                    return JsonSuccess();
                }
                catch (Exception e)
                {
                    return JsonFailur(Constants._UNKNOW_USER);
                }
            }

            return JsonFailur(Constants._UNKNOW_USER);
        }

        [HttpPost]
        public JsonResult Logout()
        {
            try
            {
                this.Auth.Logout();

                return Json(new
                {
                    Success = true,
                    Data = "null"
                });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ActionResult Welcom()
        {
            return View();
        }

        [BanResource]
        public ActionResult Blocked()
        {
            var block = BlockUser.FindAll()
                .Where(x => x.DateTo < DateTime.Now)
                .FirstOrDefault();

            return View(block);
        }

        [HttpPost]
        public ActionResult ValidateCaptcha()
        {
            

            return View();
        }

        public class CaptchaResponse
        {
            [JsonProperty("success")]
            public bool Success { get; set; }

            [JsonProperty("error-codes")]
            public List<string> ErrorCodes { get; set; }
        }
    }
}