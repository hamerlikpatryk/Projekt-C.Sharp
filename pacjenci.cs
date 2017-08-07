using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctors1
{
    class patient
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string sex { get; set; }
        public doctor doctor { get; set; }
        public string department { get; set; }
        public int ID { get; set; }

        public string WritePatient()
        {
            string write;
            write = "name: " + this.name + ", last name: "
                + this.lastname + ", sex: " + this.sex
                +",doctor:"+ this.doctor.name + this.doctor.lastname + ", department:" + this.department + ", ID:" + this.ID;

            return write;

        }


    }
}

