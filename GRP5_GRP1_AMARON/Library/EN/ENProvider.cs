//Paula Guadalajara Saiz

using System;

namespace Library
{

    public class ENProvider : ENUser
    {
        ////////////////////////////////////////////////////////////////////////////
        //                              PROPERTIES
        ////////////////////////////////////////////////////////////////////////////

        private string ProviderCompany;
        public string company
        {
            get { return this.ProviderCompany; }
            set { this.ProviderCompany = value; }
        }

        private string ProviderName;
        public string name
        {
            get { return this.ProviderName; }
            set { this.ProviderName = value; }
        }

        private string ProviderPass;
        public string pass
        {
            get { return this.ProviderPass; }
            set { this.ProviderPass = value; }
        }

        private int ProviderAge;
        public int age
        {
            get { return this.ProviderAge; }
            set { this.ProviderAge = value; }
        }

        private string ProviderEmail;
        public string email
        {
            get { return this.ProviderEmail; }
            set { this.ProviderEmail = value; }
        }

        private string ProviderUrl;
        public string url
        {
            get { return this.ProviderUrl; }
            set { this.ProviderUrl = value; }
        }

        private string UserAddress;
        public string address
        {
            get { return this.UserAddress; }
            set { this.UserAddress = value; }
        }


        ////////////////////////////////////////////////////////////////////////////
        //                              METHODS
        ////////////////////////////////////////////////////////////////////////////

        /**  Creates a default provider  **/
        public ENProvider()
        {
            company = "default name company";
        }

        /**  Creates a provider with the values of the parameters  **/
        public ENProvider(string name, string pass, string email, int age, string url, string company, string address)
        {
            this.company = company;
            this.name = name;
            this.pass = pass;
            this.age = age;
            this.email = email;
            this.url = url;
            this.address = address;
        }

        public bool CreateProvider()
        {
            CADProvider provider = new CADProvider();
            return provider.CreateProvider(this);
        }

        public bool ReadProvider()
        {
            CADProvider provider = new CADProvider();
            return provider.ReadProvider(this);
        }

        public bool UpdateProvider()
        {
            CADProvider provider = new CADProvider();
            return provider.UpdateProvider(this);
        }

        public bool DeleteProvider()
        {
            CADProvider provider = new CADProvider();
            return provider.DeleteProvider(this);
        }

    }

}