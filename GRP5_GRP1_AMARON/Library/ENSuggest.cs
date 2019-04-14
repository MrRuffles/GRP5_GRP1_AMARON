using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENSuggest
    {

        private string text;
        private int userID;
        public string textPublic
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }

        }
        public int userIDPublic
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }

        }
        public ENSuggest(int userID, string text)
        {
            this.userIDPublic = userID;
            this.textPublic = text;
            
        }

        public bool createSuggest()
        {

            CADSuggest cadsup = new CADSuggest();

            return cadsup.createSuggest(this);
        }

        public bool readSuggest()
        {
            CADSuggest cadsup = new CADSuggest();

            return cadsup.readSuggest(this);
        }

        public bool updateSuggest()
        {
            CADSuggest cadsup = new CADSuggest();

            return cadsup.updateSuggest(this);
        }

        public bool deleteSuggest()
        {
            CADSuggest cadsup = new CADSuggest();

            return cadsup.deleteSuggest(this);
        }
    }
}

