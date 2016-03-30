using MagazinCommon.model;
using MagazinDeElectronice.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeElectronice.controller
{
    public class ProductController
    {

        private Repository repository;

        public ProductController(Repository repository)
        {
            this.repository = repository;
        }

        public bool comanda(int id_produs, int cantitate)
        {
            Produs produs= repository.getProdusById(id_produs);
            if (produs.Quantity < cantitate)
                return false;
            else
            {
                produs.Quantity -= cantitate;
                repository.update(produs);
                return true;
            }
               
        }
        public List<Produs> getProduseFilteredByCategorie(string categorie)
        {
            return repository.getProdusFilteredByCategorie(categorie);
        }
        public List<String> getCategorii()
        {
            return repository.getCategorii();
        }
    }
}
