using MagazinCommon.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazinCommon.model;

namespace MagazinServer.service
{
    class ServiceImpl : Service
    {
        public bool comanda(int id_produs, int cantitate)
        {
            return false;
        }

        public List<string> getCategorii()
        {
            throw new NotImplementedException();
        }

        public Produs getProdusById(int id_produs)
        {
            throw new NotImplementedException();
        }


        public List<Produs> getProduseFilteredByCategorie(string categorie)
        {
            throw new NotImplementedException();
        }

        public string SayHello(string name)
        {
            return "Hello " + name;
        }

        public void update(Produs produs)
        {
            throw new NotImplementedException();
        }
    }
}
