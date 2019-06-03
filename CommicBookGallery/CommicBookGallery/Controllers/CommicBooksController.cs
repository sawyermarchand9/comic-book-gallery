using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace CommicBookGallery.Controllers
{
    public class CommicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "the amazing spriderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue! Witness the final hour </p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopouls"

            };
            return View();
        }
                
        
    }
}