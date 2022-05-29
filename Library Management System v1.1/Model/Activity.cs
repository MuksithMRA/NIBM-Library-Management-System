using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class Activity
    {
        String id;
        String description;
        String emp_type;
        String emp_id;

        public Activity(string id, string description, string emp_type, string emp_id)
        {
            this.id = id;
            this.description = description;
            this.emp_type = emp_type;
            this.emp_id = emp_id;
        }

        public string Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Emp_type { get => emp_type; set => emp_type = value; }
        public string Emp_id { get => emp_id; set => emp_id = value; }
    }
}
