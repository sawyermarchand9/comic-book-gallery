using CommicBookGallery.Models;
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
            var commicBook = new CommicBook() {
                SeriesTitle = "the amazing spider-man",
                IssueNumber = 700, 
                DescriptionHtml = "<p>Final Issue! Witness the final hour </p>",
                Artists = new Artist[] 
                {
                    new Artist() { Name ="Dan Slott", Role="Script"},
                    new Artist() { Name ="Humberto Ramos", Role="Pencils"},
                    new Artist() { Name ="Victor Olazaba", Role="Ink"},
                    new Artist() { Name ="Edgar Delgado", Role="Colors"},
                    new Artist() { Name ="Chris Eliopouls", Role="Letters"}
                }
            };
            
            return View(commicBook);
        }
                
        
    }
}