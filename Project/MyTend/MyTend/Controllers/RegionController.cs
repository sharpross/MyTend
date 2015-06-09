using MyTend.Services;
using MyTender.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTend.Controllers
{
    public class RegionController : BaseController
    {
        [HttpGet]
        public JsonResult RegionAll()
        {
            var result = RegionService.RegionAll();

            return JsonSuccess(result);
        }

        [HttpGet]
        public JsonResult CityAll()
        {
            var result = RegionService.CityAll();

            return JsonSuccess(result);
        }

        [HttpGet]
        public JsonResult CountryAll()
        {
            var result = RegionService.CountryAll();

            return JsonSuccess(result);
        }

        [HttpGet]
        public JsonResult CountryById(int id)
        {
            var result = RegionService.CountryById(id);

            return JsonSuccess(result);
        }

        [HttpGet]
        public JsonResult CityById(int id)
        {
            var result = RegionService.CityById(id);

            return JsonSuccess(result);
        }

        [HttpGet]
        public JsonResult RegionById(int id)
        {
            var result = RegionService.RegionById(id);

            return JsonSuccess(result);
        }
    }
}