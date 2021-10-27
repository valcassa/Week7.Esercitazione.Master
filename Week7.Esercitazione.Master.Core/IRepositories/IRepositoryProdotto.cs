using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Esercitazione.Master.Core.Entities;

namespace Week7.Esercitazione.Master.Core.IRepositories
{
    public interface IRepositoryProdotto : IRepository<Prodotto>
    {
        public Prodotto GetById(string id);
    }
}
