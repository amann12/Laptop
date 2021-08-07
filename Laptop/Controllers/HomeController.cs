using Laptop.Models;
using Laptop.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Laptop.Controllers
{
    public class HomeController : Controller
    {

        private InterfaceLappy _lappyRepo;
        public HomeController(InterfaceLappy _lappyRepo)
        {
            this._lappyRepo = _lappyRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SingleDetails(int Id)
        {
            Lappy l = _lappyRepo.GetLappy(Id);
            return View(l);
        }

        [Authorize]
        public IActionResult AllDetails()
        {
            var data = _lappyRepo.GetAllDetails();
            return View(data);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddLaptop()
        {
            return View();
        }  

        [HttpPost]
        public IActionResult Create(LappyViewModel model)
        {

            if (ModelState.IsValid)
            {
                Lappy newLappy=new Lappy
                {
                    LaptopName=model.LaptopName,
                    NumberOfPorts=model.NumberOfPorts,
                    Processor=model.Processor,
                    GraphicCard=model.GraphicCard,
                    RAM=model.RAM,
                    Memory=model.Memory,
                    Screen=model.Screen,
                    Price=model.Price

                };
                _lappyRepo.Add(newLappy);
                return RedirectToAction("AllDetails", new { Id = newLappy.Id });

            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Lappy lappy = _lappyRepo.GetLappy(Id);
            EditLappyViewModel editLappyViewModel = new EditLappyViewModel
            {
                Id = lappy.Id,
                LaptopName=lappy.LaptopName,
                NumberOfPorts=lappy.NumberOfPorts,
                Processor=lappy.Processor,
                GraphicCard=lappy.GraphicCard,
                RAM=lappy.RAM,
                Memory=lappy.Memory,
                Screen=lappy.Screen,
                Price=lappy.Price
            };
            return View(editLappyViewModel);
        }      
        
        [HttpPost]
        public IActionResult Edit(EditLappyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Lappy lappy = _lappyRepo.GetLappy(model.Id);
                lappy.LaptopName = model.LaptopName;
                lappy.NumberOfPorts = model.NumberOfPorts;
                lappy.Processor = model.Processor;
                lappy.GraphicCard = model.GraphicCard;
                lappy.RAM = model.RAM;
                lappy.Memory = model.Memory;
                lappy.Screen = model.Screen;
                lappy.Price = model.Price;
                Lappy updateLappy = _lappyRepo.Update(lappy);
                return RedirectToAction("AllDetails");
            }
            return View(model);
        }


        public IActionResult Delete(int Id)
        {
            _lappyRepo.Delete(Id);
            return RedirectToAction("AllDetails");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
