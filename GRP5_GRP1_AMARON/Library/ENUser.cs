//Paula Guadalajara Saiz

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
            age = 0;
            email = "Default email";
            addres = "Default addres";
        }

        /** Creates a user with the values of the parameters **/
        public ENUser(string name, int age, string email, string addres)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            thie.addres = addres;
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
