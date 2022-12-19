using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Account
    {
        //Variables
        protected int ID { get; set; }
        protected string name { get; set; }
        protected string username { get; set; }
        protected string password { get; set; }
        DateTime birthDate { get; set; }

        //constructor
        public Account(int iD, string name, string username, string password, DateTime birthDate)
        {
            this.ID = iD;
            this.name = name;
            this.username = username;
            this.password = password;
            this.birthDate = birthDate;
        }

    
        //Getters
        public string GetUserName()
        {
            return username;
        }

        public string GetName()
        {
            return name;
        }
        public DateTime GetBirthdate()
        {
            return birthDate;
        }
        public int GetID()
        {
            return ID;
        }


        //Functions
        public bool ValidateUsername(string username)
        {
            if (username == this.username)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidatePassword(string password)
        {
            if (password == this.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
