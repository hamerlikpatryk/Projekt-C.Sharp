using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctors1
{
    class doctors
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string specialization { get; set; }
        public int ID { get; set; }
         public string write()
        {
            string writing;
            writing = "name: " + this.name + ", lastname: "
                + this.lastname + ", specialization: " + this.specialization;

            return writing;

        }

    }
}
