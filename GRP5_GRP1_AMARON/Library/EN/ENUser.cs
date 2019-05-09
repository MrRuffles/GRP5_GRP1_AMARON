﻿//Paula Guadalajara Saiz

using System;

namespace Library
{

    public class ENUser
    {

        ////////////////////////////////////////////////////////////////////////////
        //                              PROPERTIES
        ////////////////////////////////////////////////////////////////////////////

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

        private string UserAddres;
        public string addres
        {
            get { return this.UserAddres; }
            set { this.UserAddres = value; }
        }

        ////////////////////////////////////////////////////////////////////////////
        //                              METHODS
        ////////////////////////////////////////////////////////////////////////////

        /**  Creates a default user  **/
        public ENUser()
        {
            name = "Default name";
            pass = "";
            email = "Default email";
            age = 0;
            url = "";
            empresa = "";
            addres = "Default addres";
        }

        /** Creates a user with the values of the parameters **/
        public ENUser(string name, string pass, string email, int age, string url, string empresa, string addres)
        {
            this.name = name;
            this.pass = pass;
            this.age = age;
            this.email = email;
            this.url = url;
            this.empresa = empresa;
            this.addres = addres;
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
