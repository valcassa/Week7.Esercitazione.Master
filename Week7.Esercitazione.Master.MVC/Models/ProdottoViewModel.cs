using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Week7.Esercitazione.Master.MVC.Models
{
    public class ProdottoViewModel
    {
        [DisplayName("Prodotto")]

        public string IdProd { get; set; }
        public string Descrizione { get; set; }
        public Tipo Tipologia { get; set; }
        public decimal PrezzoPubblico { get; set; }
        public decimal PrezzoFornitore { get; set; }

        public enum Tipo
        {
            Elettronica,
            Abbigliamento,
            Casalinghi
        }
        public List<ProdottoViewModel> Prodotti { get; set; }
    }
}
