using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week7.Esercitazione.Master.MVC.Models;

namespace Week7.Esercitazione.Master.MVC.Controllers
{
    public class ProdottoController : Controller
    {
        private readonly IBusinessLayer BL;

        public ProdottoController(IBusinessLayer bl) {
            BL = bl;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var prodotti = BL.GetAllProdotti();

            List<ProdottoViewModel> docenteViewModels = new List<ProdottoViewModel>();

            foreach (var item in prodotti)
            {
                ProdottoViewModel.Add(item.toProdottoViewModel());
            }

            return View(prodottoViewModel);
        }
         
    }
}
