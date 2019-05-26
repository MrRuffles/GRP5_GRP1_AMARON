﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
    public class ENLootCrate
    {
        //Properties
        private string name;
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

        private string typeLootCrate;
        public string type
        {
            get
            {
                return typeLootCrate;
            }
            set
            {
                typeLootCrate = value;
            }
        }

        private float lootcrateprice;
        public float price
        {
            get { return this.lootcrateprice;  }
            set { this.lootcrateprice = value;  }

        }

        private string urlimg;

        public string url
        {

            get { return this.urlimg; }
            set { this.urlimg = value; }
        }

        private int lootcrateID;
        public int id {

            get { return this.lootcrateID; }

            set { this.lootcrateID = value; }

        }


        public ENLootCrate(int id, string name, float price, string description, string url, string type)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.url = url;
            this.description = description;
            this.type = type;
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

        public bool readLootCrateID()
        {
            CADLootCrate ltc = new CADLootCrate();
            return ltc.readLootCrateID(this);
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
