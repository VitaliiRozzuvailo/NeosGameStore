using NeosGameStore.Domain.Abstract;
using NeosGameStore.Domain.Entities;
using NeosGameStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeosGameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        IGameRepository repository;
        public int pageSize = 4;

        public GameController(IGameRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult List(string category, int page = 1)
        {
            GamesListViewModel model = new GamesListViewModel()
            {
                Games = repository.Games
                .Where(p => category == null || p.Category == category)
                .OrderBy(game => game.GameId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ?
                    repository.Games.Count():
                    repository.Games.Where(game=>game.Category==category).Count()
                },
                CurentCategory = category
            };

            return View(model);
        }
    }
}