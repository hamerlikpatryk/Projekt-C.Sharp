using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctors1
{
    class PatientList
    {
        public List<patients> PatientsList;
        public PatientList()
        {
            this.PatientsList = new List<patients>();
            patients all = new patient();
            all.name = "Patryk";
            all.lastname = "Hamerlik";
            all.sex = "Men";
            all.department = "Onkology";
            all.ID = 1;

            this.PatientsList.Add(all);

        }

        public void ShowPatientList()
        {
            foreach (var patients in this.PatientsList)
            {
                Console.WriteLine(patients.WritePatient());
            }
        }
         
        public void AddPatient()
        {
            patients all = new patients();
            Console.WriteLine("Write name");
            all.name = Console.ReadLine();
            Console.WriteLine("Write lastname");
            all.lastname= Console.ReadLine();
            Console.WriteLine("Write sex");
            all.sex = Console.ReadLine();
            Console.WriteLine("Write ID");
            all.ID = Convert.ToInt32(Console.ReadLine());

            this.PatientsList.Add(all);
        }
        ListaLekarzy jakas;
       /* public void PrzypiszLekarza()
        {
           // jakas = GetComponent<ListaLekarzy>();
  
            foreach (lekarze s in jakas.ListaLekarzyA)
                Console.WriteLine(s);
                */


        }


    }

