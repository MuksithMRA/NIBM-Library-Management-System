using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class PiechartDataModel
    {
        String name;
        double percentage;

        public PiechartDataModel(string name, double percentage)
        {
            this.Name = name;
            this.Percentage = percentage;
        }

        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }
    }
}
