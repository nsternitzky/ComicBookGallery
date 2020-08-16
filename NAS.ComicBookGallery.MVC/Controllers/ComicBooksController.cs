using NAS.ComicBookGallery.MVC.Data;
using NAS.ComicBookGallery.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAS.ComicBookGallery.MVC.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int) id);

            return View(comicBook);
        }
    }
}