using Kitty;
using Kitty.DB;
using Kitty.Repositories;
using KittyUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KittyUI.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
            [HttpGet]
            public ActionResult ListLocations()
            {
                var locationRepo = new LocationRepository();

                var viewModel = new ListLocationsViewModel { locs = locationRepo.GetLocations().ToList() };

                return View(viewModel);
            }

           public ActionResult AddDepartment(Location location)
        {
            var locationRepo = new LocationRepository();

            locationRepo.Add(location);

            ViewBag.Error = false;

            return View();
        }
   }
 }