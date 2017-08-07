using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctors1
{
    class DoctorsList
    {
        public List<doctors> DoctorsListA;
    
    public DoctorsList()
        {
            this.DoctorsListA = new List<doctors>();
           
            doctors all = new doctors();

            all.name = "Jacek";
            all.lastname = "Jackowski";
            all.specialization = "Surgery";
            all.ID = 1;

            doctors all1 = new doctors();

            all1.name = "Stefan";
            all1.lastname = "Kowalski";
            all1.specialization = "Orthopaedics";
            all1.ID = 2;

            this.DoctorsListA.Add(all);
            this.DoctorsListA.Add(all1);

        }
       

        public void ShowDoctorsList()
        {
            foreach (var doctors in this.DoctorsListA)
            {
                Console.WriteLine(doctors.Write());
            }
        }
    public void AddDoctor()
        {
            Doctors all = new doctors();
            Console.WriteLine("Give me your name");
            all.name = Console.ReadLine();
            Console.WriteLine("Give me your latname");
            all.lastname = Console.ReadLine();
            Console.WriteLine("Give me your specialization");
            all.specialization = Console.ReadLine();

            this.DoctorsListA.Add(all);
        }
    }
}
