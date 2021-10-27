using System.Collections.Generic;
using Week7.Esercitazione.Master.Core.Entities;

namespace Week7.Esercitazione.Master
{
    public interface IBusinessLayer
    {
        public List<Prodotto> GetAllProdotti();
    }
}