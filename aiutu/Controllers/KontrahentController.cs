using aiutu.Application.Interfaces;
using aiutu.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aiutu.Web.Controllers
{
    public class KontrahentController : Controller
    {
        private readonly IKontrahentService _kontService;
        public KontrahentController(IKontrahentService kontService)
        {
            _kontService = kontService;
        }
        public IActionResult Index()
        {
            // utworzyć widok dla tej akcji
            // tabela z kontrahentami
            // filtrowanie kontrahentów
            //
            // przygotować dane
            // przekazać filtry do serwisu
            // serwis musi przygotować dane
            // serwis musi zwrócić dane w odpowiednim formacie

            var model = _kontService.GetAllKontrahenciForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddKontrahent()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddKontrahent(KontrahentModel model)
        //{
        //    var id = _kontService.AddKontrahent(model);
        //    return View();
        //}

        [HttpGet]
        public IActionResult AddNewAdresForKontrahent(int kontrahentId)
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddNewAdresForKontrahent(AdresModel model)
        //{
        //    return View();
        //}

        public IActionResult ViewKontrahent(int kontrahentId)
        {
            var kontrahentModel = _kontService.GetKontrahentDetails(kontrahentId);
            return View(kontrahentModel);
        }

    }
}
