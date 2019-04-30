using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENSupport
    {
        private string name;
        private string emailaddress;
        private string text;
        private string subject;
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
        public string emailAddressPublic
        {
            get
            {
                return emailaddress;
            }
            set
            {
                emailaddress = value;
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


        public ENSupport()
        {
            this.namePublic = this.emailAddressPublic = this.subjectPublic = this.textPublic = null;
        }

        public ENSupport(string name, string email, string topic, string text)
        {
            this.namePublic = name;
            this.emailAddressPublic = email;
            this.subjectPublic = topic;
            this.textPublic = text;
        }

        public bool createSupport()
        {

            CADSupport cadsup = new CADSupport();

            return cadsup.createSupport(this);
        }

        public bool readSupport()
        {
            CADSupport cadsup = new CADSupport();

            return cadsup.readSupport(this);
        }

        public bool updateSupport()
        {
            CADSupport cadsup = new CADSupport();

            return cadsup.updateSupport(this);
        }

        public bool deleteSupport()
        {
            CADSupport cadsup = new CADSupport();

            return cadsup.deleteSupport(this);
        }
    }
}
