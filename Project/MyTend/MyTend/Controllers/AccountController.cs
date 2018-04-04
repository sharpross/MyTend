namespace MyTend.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using MyTend.Attributes;
    using MyTend.Entites;
    using MyTend.Entites.Block;
    using MyTend.Models;
    using MyTend.Services.Common;
    using MyTend.Services.EmailService;
    using MyTender.Core;
    using Newtonsoft.Json;
    using NHibernate.Criterion;

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

        public new ActionResult Profile(string tab)
        {
            var model = new ProfileModel(this.Auth.User);
            this.ViewBag.OpenTabParam = tab;
            return View(model);
        }
        
        public ActionResult Activate(ActivationModel model)
        {
            if (this.Auth.User.Activated)
            {
                return RedirectToAction("Index", "Home");
            }

            if (model.Code != string.Empty)
            {
                var smsActivator = SmsActivation.FindFirst(Expression.Eq("User", this.Auth.User));

                if (smsActivator != null)
                {
                    if (smsActivator.Code == model.Code)
                    {
                        var user = UserSystem.FindAllByProperty("Login", this.Auth.User.Login).First();
                        user.Activated = true;
                        user.Save();

                        return RedirectToAction("Welcom", "Account");
                    }
                    else
                    {
                        model.Error = "Не верно введён пароль";
                    }
                }
            }

            model.Phone = this.Auth.User.Phone;

            return View(model);
        }
        
        public ActionResult Card(string user)
        {
            //this.ViewBag.NoIndexing = true;

            var model = new CardModel(user);
            
            return View(model);
        }

        public class LoadProfilesModel
        {
            public HttpPostedFileBase[] Files { get; set; }
        }

        public ActionResult AddImage(LoadProfilesModel model)
        {
            if (model != null && model.Files.Length > 0)
            {
                var model2 = new ProfileModel();
                model2.AddProfile(model, this.Auth.User);
            }

            return null;
        }

        [HttpPost]
        public ActionResult UpdateProfiles(ProfileModel model)
        {
            model.AddProfile(this.Auth.User);

            return RedirectToAction("Card", new { @user = this.Auth.User.Login });
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
                catch (Exception e)
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

            return JsonFailur(model);
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
            if (model.TryRegistry())
            {
                this.Auth.Login(model.Login, model.Password);

                try
                {
                    this.SendSms(model.Login, model.Phone);
                    
                    var emailService = new EmailService(model.Login);
                    emailService.Registration(model.FullName, model.Login, model.Password);
                }
                catch (Exception ex)
                {
                    return JsonFailur(ex);
                }
            }

            if (model.Errors.Count > 0)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("Activate", "Account");
            }
        }

        public ActionResult ResendSms(string phone)
        {
            try
            {
                this.SendSms(this.Auth.User.Login, phone);
            }
            catch (Exception ex)
            {
                return JsonFailur(ex);
            }
            
            return JsonSuccess();
        }

        private void SendSms(string login, string phone)
        {
            var code = Utils.GenerateNumber(4);

            var user = UserSystem.FindOne(Expression.Eq("Login", login));

            if (user == null)
            {
                throw new Exception("Пользователь " + login + " не найден.");
            }

            if (user.Activated)
            {
                return;
            }

            var sms = SmsActivation.FindOne(Expression.Eq("User", this.Auth.User));

            if (sms != null)
            {
                sms.Code = code;
            }
            else
            {
                sms = new SmsActivation()
                {
                    User = user,
                    Code = code
                };
            }

            sms.Save();

            var phone2 = string.IsNullOrEmpty(phone) ? user.Phone : phone;

            var sender = new SmsMegafonSender();
            sender.Send(code, phone2, user);
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

        public ActionResult YouSeller()
        {
            

            return View();
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
        
        public class CaptchaResponse
        {
            [JsonProperty("success")]
            public bool Success { get; set; }

            [JsonProperty("error-codes")]
            public List<string> ErrorCodes { get; set; }
        }
    }
}