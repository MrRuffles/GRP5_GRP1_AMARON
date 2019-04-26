using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENSupport
    {
        private int userID;
        private string emailaddress;
        private string text;
        private string subject;
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
        
        public ENSupport(string email, string topic, string text)
        {
            this.emailAddressPublic = email;
            this.textPublic = text;
            this.subjectPublic = topic;
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
