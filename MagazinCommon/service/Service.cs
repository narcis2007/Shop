using MagazinCommon.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinCommon.service
{
    public interface Service
    {
        string SayHello(string name);

        List<String> getCategorii();


        List<Produs> getProduseFilteredByCategorie(string categorie);

        Produs getProdusById(int id_produs);

        void update(Produs produs);
        bool comanda(int id_produs, int cantitate);
    }
}
