using CommicBookGallery.Data;
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
        private CommicBookRepository _comicBookRepository = null;

        public CommicBooksController()
        {
            _comicBookRepository = new CommicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.getCommicBook((int)id); // you can also use a nullable cast
            return View(comicBook);
        }
                
        
    }
}