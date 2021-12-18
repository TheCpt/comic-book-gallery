﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.artists = new string[]
                    {
                        "Script: Dan Slott",
                        "Pencils: Humberto Ramos",
                        "Inks: Victor Olazaba",
                        "Colors: Edgar Delgado",
                        "Letters: Chris Eliopoulos"
                    };

            return View();
        }
    }
}
