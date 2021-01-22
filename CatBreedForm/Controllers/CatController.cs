﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CatBreedForm.Models;

namespace CatBreedForm.Controllers
{
    public class CatController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormCollection form)
        {
            Cat kitty = new Cat();
            kitty.OwnerName = form["owner_name"];
            kitty.CatName = form["cat_name"];
            kitty.CatBirthDate = Convert.ToDateTime(form["cat_dob"]);
            kitty.CatBreed = form["cat_breed"];

            // ADD TO DATABASE

            ViewData["Added"] = kitty.CatName + " has been added.     =＾● ⋏ ●＾=";

            return View();
        }
    }
}