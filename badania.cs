using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctors1
{
    class medicalcheckups 
    {
        public string name { get; set; }
        public int price { get; set; }
        public int ID { get; set; }
        public int patientID { get; set; }
        public int dateday { get; set; }
        public int datemonth { get; set; }


        public string WriteCheckUps()
        {
            string write;
            write = "name: " + this.name + ", price: "
                + this.price + ", ID: " + this.ID
                +  ", IDPacjenta:" + this.patientID;

            return write;

        }
    }

}
