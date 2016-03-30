using MagazinCommon.net;
using MagazinCommon.service;
using MagazinDeElectronice.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazinCommon.model;

namespace MagazinDeElectronice.service
{
    public class ServiceProxy : Service
    {
        public TcpClient TcpClient { get; internal set; }

        public List<string> getCategorii()
        {
            return new List<string>();
        }

        public Produs getProdusById(int id_produs)
        {
            return new Produs();
        }


        public List<Produs> getProduseFilteredByCategorie(string categorie)
        {
            return new List<Produs>();
        }


        public string SayHello(string name)
        {
            try
            {
                Message request = new Message(name);
                Message response = TcpClient.Execute(request);
                return response.ToString();
            }
            catch (Exception e)
            {
                throw e;
                throw new ServiceException("Service unavailable", e);
            }
        }

        public void update(Produs produs)
        {
            throw new NotImplementedException();
        }

        internal void comanda(int id_produs, int cantitate)
        {
            throw new NotImplementedException();
        }

        bool Service.comanda(int id_produs, int cantitate)
        {
            return false;
        }
    }
}
