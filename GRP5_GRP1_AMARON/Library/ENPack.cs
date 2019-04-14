using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    public class ENPack
        //Properties
    {
        private string name;
        private float price;
        private string description;

        public string namePack
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

        public float pricePack
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string descriptionPack
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public ENPack(string name, float price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public bool createPack()
        {
            CADPack pck = new CADPack();
            return pck.createPack(this);
        }

        public bool readPack()
        {
            CADPack pck = new CADPack();
            return pck.readPack(this);
        }

        public bool updatePack()
        {
            CADPack pck = new CADPack();
            return pck.updatePack(this);
        }

        public bool deletePack()
        {
            CADPack pck = new CADPack();
            return pck.deletePack(this);
        }
    }
}
