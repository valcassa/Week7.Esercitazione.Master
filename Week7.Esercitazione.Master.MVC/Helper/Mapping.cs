using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week7.Esercitazione.Master.Core.Entities;
using Week7.Esercitazione.Master.MVC.Models;

namespace Week7.Esercitazione.Master.MVC.Helper
{
    public static class Mapping
    {
        public static ProdottoViewModel toProdottoViewModel(this Prodotto prodotto)
        {
            List<ProdottoViewModel> prodottiViewModel = new List<ProdottoViewModel>();
            foreach (var item in prodotto.IdProd)
            {
                prodottiViewModel.Add(item.toProdottoViewModel());
            }

            return new ProdottoViewModel
            {
                IdProd = prodotto.IdProd,
                Descrizione = prodotto.Descrizione,
                PrezzoPubblico = prodotto.PrezzoPubblico,
                PrezzoFornitore = prodotto.PrezzoFornitore,
             };
        }

        public static Prodotto ToProdotto(this ProdottoViewModel prodottoViewModel)
        {
            List<Prodotto> prodotti = new List<Prodotto>();
            foreach (var item in prodottoViewModel.IdProd)
            {
                prodotti.Add(item.ToProdotto());
            }

            return new Prodotto
            {
                IdProd = prodottoViewModel.IdProd,
                Descrizione = prodottoViewModel.Descrizione,
                PrezzoPubblico = prodottoViewModel.PrezzoPubblico,
                PrezzoFornitore = prodottoViewModel.PrezzoFornitore,
                Prodotti = prodottoViewModel
            };
            }


        }
        }

