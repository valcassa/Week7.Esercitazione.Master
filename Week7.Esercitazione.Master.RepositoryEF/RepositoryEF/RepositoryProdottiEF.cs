using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Week7.Esercitazione.Master.Core.Entities;
using Week7.Esercitazione.Master.Core.IRepositories;

namespace Week7.Esercitazione.Master
{
    internal class RepositoryProdottiEF : IRepositoryProdotto
    {
        public Prodotto Add(Prodotto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Prodotti.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Prodotto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Prodotti.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Prodotto> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Prodotti.Include(x => x.Tipologia).ToList();
            }
        }

        public Prodotto GetById(string id)
        {

            using (var ctx = new MasterContext())
            {
                return ctx.Prodotti.Include(x => x.Descrizione).FirstOrDefault(d => d.IdProd == id);
            }
        }

        public Prodotto Update(Prodotto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Prodotti.Update(item);
                ctx.SaveChanges();
            }
            return item;
        }
    }
}