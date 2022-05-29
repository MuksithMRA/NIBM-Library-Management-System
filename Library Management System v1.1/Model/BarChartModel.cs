using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class BarChartModel
    {
        int valueX;
        int valueY;

        public BarChartModel(int valueX, int valueY)
        {
            this.valueX = valueX;
            this.valueY = valueY;
        }

        public int ValueX { get => valueX; set => valueX = value; }
        public int ValueY { get => valueY; set => valueY = value; }
    }
}
