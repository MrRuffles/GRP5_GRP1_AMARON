using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    class ENLootCrate
    {
        public enum SuscriptionType
        {
            Basic,
            Normal,
            Premium
        }

        //Properties
        private string name;
        private SuscriptionType type;
        private string description;
        private float price;
        private int stock;
        private string brand;
        private string urlImage;

        public string nameLootCrate
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

        public SuscriptionType typeLootCrate
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

        public string descriptionLootCrate
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

        public float priceLootCrate
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

        public int stockLootCrate
        {

            get { return this.stock; }

            set { this.stock = value; }

        }
        public string brandLootCrate
        {

            get { return this.brand; }

            set { this.brand = value; }

        }
        public string urlLootCrate
        {

            get { return this.urlImage; }

            set { this.urlImage = value; }

        }

        public ENLootCrate(string name, SuscriptionType type, string description)
        {
            this.name = name;
            this.type = type;
            this.description = description;
        }
        
        public bool createLootCrate()
        {
            CADLootCrate ltc = new CADLootCrate();
            return ltc.createLootCrate(this);
        }

        public bool readLootCrate()
        {
            CADLootCrate ltc = new CADLootCrate();
            return ltc.readLootCrate(this);
        }

        public bool updateLootCrate()
        {
            CADLootCrate ltc = new CADLootCrate();
            return ltc.updateLootCrate(this);
        }

        public bool deleteLootCrate()
        {
            CADLootCrate ltc = new CADLootCrate();
            return ltc.deleteLootCrate(this);
        }
       
    }
}
