using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KolekcjaGierMVC1.Models;
using KolekcjaGierMVC1.Models.Abstracted;

namespace KolekcjaGierMVC1.Controllers
{
    public class KolekcjaController : Controller
    {
        private FakeRepository repo = new FakeRepository();
        // GET: Kolekcja
        public ActionResult Lista()
        {

            return View(repo);
        }

        public ActionResult ListaGier(int id=-1) {
            List<Game> games;
            if (id == -1) {
                 games = repo.Games.ToList();
            }
            else {
                games = repo.Games.AsQueryable().Where(g =>( g.CategoryID==id)).ToList();
            }
            
            return View(games);
        }
    }
}