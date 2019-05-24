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
        
        ////////////////////////////////////////////////////////////////////////////
        //                              METHODS
        ////////////////////////////////////////////////////////////////////////////

        /**  Creates a default provider  **/
        public ENProvider()
        {
            company = "default name company";
        }

        public ENProvider(string email)
        {
            this.email = email;
        }
        /**  Creates a provider with the values of the parameters  **/
        public ENProvider(string name, string pass, string email, DateTime birth, string url, string company, string address)
        {
            this.company = company;
            this.name = name;
            this.pass = pass;
            this.birth = birth;
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