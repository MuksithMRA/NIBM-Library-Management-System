using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class User
    {
    
        String empId;
        String password;
        String empType;
        bool IsLoggedIn;

        public User() { }
        public User( string empId, string password, string userType, bool isLoggedIn)
        {
         
            this.empId = empId;
            this.password = password;
            this.empType = userType;
            IsLoggedIn = isLoggedIn;
        }

       
        public string EmpID { get => empId; set => empId = value; }
        public string Password { get => password; set => password = value; }
        public string EmpType { get => empType; set => empType = value; }
        public bool IsLoggedIn1 { get => IsLoggedIn; set => IsLoggedIn = value; }
    }
}
