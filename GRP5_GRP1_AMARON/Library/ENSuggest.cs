using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENSuggest
    {
        private string name;
        private string subject;
        private string email;
        private string text;

        public string namePublic
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
        public string emailPublic
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }
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
        public string subjectPublic
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }

        }
        public ENSuggest()
        {
            this.namePublic = this.emailPublic = this.subjectPublic = this.textPublic = null;
        }
        public ENSuggest(string nickname, string email, string topic, string text)
        {
            this.namePublic = nickname;
            this.emailPublic = email;
            this.subjectPublic = topic;
            this.textPublic = text;
            
        }
        public bool storeSuggest()
        {

            CADSuggest cadsup = new CADSuggest();

            return cadsup.storeSuggest(this);
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

