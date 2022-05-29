using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Controller
{
    class SplashController
    {
        public static Boolean isLoggedIn;
        public static String currentUser;

        public static void setIsLoggedIn(Boolean b , String cu)
        {
            isLoggedIn = b;
            currentUser = cu;
        }
    }
}
