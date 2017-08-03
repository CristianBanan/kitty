using Kitty.DB;
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
       
            private LocationDbContext db = new LocationDbContext();

            [HttpGet]
            public ActionResult ListLocations()
            {
                var departments = db.locations.ToList();

                var viewModel = new ListLocationsViewModel { locs = departments };

                return View(viewModel);
            }
        }
 }