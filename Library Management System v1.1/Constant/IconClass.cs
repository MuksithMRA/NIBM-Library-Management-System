using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Constant
{
    class IconClass
    {
      
        static string startupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..");

        public static String showPass = startupPath + "\\Icons\\showPass.png";
        public static String hidePass = startupPath + "\\Icons\\hidePass.png";
      




    }
}
