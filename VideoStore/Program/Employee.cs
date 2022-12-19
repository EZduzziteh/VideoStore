using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Employee:Account
    {
        //variables
        public string position { get; set; }


        //constructor
        public Employee(int iD, string name, string username, string password, DateTime birthDate, string position) : base(iD, name, username, password, birthDate)
        {
            this.position = position;
        }
        
        
    
        //Getters
        public string GetPosition()
        {
            return position;
        }

        
    }
}
