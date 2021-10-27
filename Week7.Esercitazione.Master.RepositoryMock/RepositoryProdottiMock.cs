using System;
using System.Collections.Generic;
using System.Linq;
using Week7.Esercitazione.Master.Core.Entities;
using Week7.Esercitazione.Master.Core.IRepositories;

namespace Week7.Esercitazione.Master.RepositoryMock
{
    public class RepositoryProdottiMock : IRepositoryProdotto
    {
        public static List<Prodotto> prodotto = new List<Prodotto>()
        {
            new Prodotto{IdProd="P-01", Descrizione="Cappotto", Tipologia='Abbigliamento', PrezzoPubblico=45, PrezzoFornitore=24},
            new Prodotto{IdProd="P-02", Descrizione="Cappotto", Tipologia='Abbigliamento', PrezzoPubblico=45, PrezzoFornitore=24}
        };

        public Prodotto Add(Prodotto item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Prodotto item)
        {
            throw new NotImplementedException();
        }

        public List<Prodotto> GetAll()
        {
            return prodotto;
        }

        public Prodotto GetById(string id)
        {
            return prodotto.Find(p => p.IdProd == id);
        }

        public Prodotto Update(Prodotto item)
        {
            throw new NotImplementedException();
        }
    }
}
