//Paula Guadalajara Saiz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public class ENUser
    {

        ////////////////////////////////////////////////////////////////////////////
        //                              PROPERTIES
        ////////////////////////////////////////////////////////////////////////////
        

        private int id;
        public int userID
        {
            get { return this.id; }
            set { this.id = value; }
        }


        private string UserName;
        public string name
        {
            get { return this.UserName; }
            set { this.UserName = value; }
        }

        private string UserPass;
        public string pass
        {
            get { return this.UserPass; }
            set { this.UserPass = value; }
        }

        private int UserAge;
        public int age
        {
            get { return this.UserAge; }
            set { this.UserAge = value; }
        }

        private string UserEmail;
        public string email
        {
            get { return this.UserEmail; }
            set { this.UserEmail = value; }
        }

        private string UserUrl;
        public string url
        {
            get { return this.UserUrl; }
            set { this.UserUrl = value; }
        }
        private string UserEmpresa;
        public string empresa
        {
            get { return this.UserEmpresa; }
            set { this.UserEmpresa = value; }
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

        /**  Creates a default user  **/
        public ENUser()
        {
            id = 0;
            name = "Default name";
            pass = "";
            email = "Default email";
            age = 0;
            url = "";
            empresa = "";
            address = "Default addres";
        }

        /** Creates a user with the values of the parameters **/
        public ENUser(int userID, string name, string pass, string email, int age, string url, string empresa, string address)
        {
            this.userID = userID;
            this.name = name;
            this.pass = pass;
            this.age = age;
            this.email = email;
            this.url = url;
            this.empresa = empresa;
            this.address = address;
        }

        public ENUser(string pass, string email)
        {
            this.pass = pass;
            this.email = email;
        }

        public ENUser(string email)
        {
            this.email = email;
        }

        public bool CreateUser()
        {
            CADUser user = new CADUser();
            return user.CreateUser(this);
        }

        public bool ReadUser()
        {
            CADUser user = new CADUser();
            return user.ReadUser(this);
        }

        public bool ReadUserPerfil()
        {
            CADUser user = new CADUser();
            return user.ReadUserPerfil(this);
        }

        public bool ReadUserEDPerfil()
        {
            CADUser user = new CADUser();
            return user.ReadUserEDPerfil(this);
        }

        public bool ReadID()
        {
            CADUser user = new CADUser();
            return user.ReadID(this);
        }

        public bool UpdateUser()
        {
            CADUser user = new CADUser();
            return user.UpdateUser(this);
        }

        public bool DeleteUser()
        {
            CADUser user = new CADUser();
            return user.DeleteUser(this);
        }




    }

}
