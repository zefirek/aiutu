using aiutu.Application.Interfaces;
using aiutu.Application.Services;
using aiutu.Application.ViewModels.Kontrahent;
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
        [HttpGet]
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

            var model = _kontService.GetAllKontrahenciForList(2, 1, "");
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _kontService.GetAllKontrahenciForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }

        #region *** Dodawanie nowego ***
        [HttpGet]
        public IActionResult AddKontrahent()
        {
            return View(new NewKontrahentVm());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddKontrahent(NewKontrahentVm model)
        {
            var id = _kontService.AddKontrahent(model);
            return RedirectToAction("Index");
        }
        #endregion

        #region *** Edycja ***

        [HttpGet]
        public IActionResult EditKontrahent(int id)
        {
            var kontrahent = _kontService.GetKontrahentForEdit(id);
            return View(kontrahent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditKontrahent(NewKontrahentVm model)
        {
            _kontService.UpdateKontrahent(model);
            return RedirectToAction("Index");
        }

        #endregion

        public IActionResult Delete(int id)
        {
            _kontService.DeleteKontrahent(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AddNewAdresForKontrahent(int kontrahentId)
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
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
