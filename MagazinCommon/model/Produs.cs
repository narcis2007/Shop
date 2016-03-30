using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinCommon.model
{
    public class Produs
    {
        private int id;
        private int quantity;
        private string type;
        private string name;
        private int pret;


        public Produs(int id_produs, string name, string type, int quantity,int pret)
        {
            this.id = id_produs;
            this.name = name;
            this.type = type;
            this.quantity = quantity;
            this.Pret = pret;
        }

        public Produs()
        {
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Pret
        {
            get
            {
                return pret;
            }

            set
            {
                pret = value;
            }
        }
    }
}
