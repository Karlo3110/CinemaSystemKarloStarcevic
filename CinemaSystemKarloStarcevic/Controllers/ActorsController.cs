﻿using CinemaSystemKarloStarcevic.Data;
using CinemaSystemKarloStarcevic.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaSystemKarloStarcevic.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();

            return View(data);
        }
    }
}
