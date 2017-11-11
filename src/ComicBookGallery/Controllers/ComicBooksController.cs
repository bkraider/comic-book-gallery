using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Detail()
        {
            var comicBookRepository = new ComicBookRepository();
            var comicBook = comicBookRepository.GetComicBook(700);
            return View(comicBook);
        }
    }
}