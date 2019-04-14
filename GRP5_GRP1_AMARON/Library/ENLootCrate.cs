﻿using System;
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
        enum SuscriptionType
        {
            Basic,
            Normal,
            Premium
        }

        //Properties
        private string name;
        private SuscriptionType type;
        private string description;

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