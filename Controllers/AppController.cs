using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IDutchRepository _dutchRepository;

        public AppController(IMailService mailService,IDutchRepository dutchRepository)
        {
            _mailService = mailService;
            _dutchRepository = dutchRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        { 
            if(ModelState.IsValid)
            {
                //send email
               // _mailService.SendMessage(model.Email, model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }

            return View();
        }


        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

        public IActionResult Shop()
        {
            //var results = _dutchRepository.GetAllProducts();
            //return View(results)
             return View();
        }
    }

}
