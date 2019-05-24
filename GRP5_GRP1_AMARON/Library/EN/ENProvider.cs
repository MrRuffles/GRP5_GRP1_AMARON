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

        /**  Creates a provider with the values of the parameters  **/
        public ENProvider(string company)
        {
            this.company = company;
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