using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.Esercitazione.Master.Core.Entities
{
    public class Prodotto
    {
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


        public override string ToString()
        {
            return $"{IdProd}\t{Descrizione}\t{Tipologia}\t{PrezzoPubblico}";
        }

        public object toProdottoViewModel()
        {
            throw new NotImplementedException();
        }
    }
}
