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

            var model = kontrahentService.GetAllKontrahenciForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddKontrahent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddKontrahent(KontrahentModel model)
        {
            var id = kontrahentService.AddKontrahent(model);
            return View();
        }

        [HttpGet]
        public IActionResult AddNewAdresForKontrahent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewAdresForKontrahent(AdresModel model)
        {
            return View();
        }

        public IActionResult ViewKontrahent(int kontrahentId)
        {
            var kontrahentModel = kontrahentService.GetKontrahentDetails(kontrahentId);
            return View(); //View(kontrahentModel);
        }

    }
}
