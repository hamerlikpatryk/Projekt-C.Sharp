using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctors1
{
    class Program
    {
        static void Main(string[] args)
        {
            var doctorslist = new DoctorsList();
            var patientlist = new PatientList();
            var listofmedicalexaminations = new ListOfMedicalExaminations();
            string casec;
            do
            {
                Console.WriteLine("1 : Add doctor ");
                Console.WriteLine("2 : Write doctors");
                Console.WriteLine("3 : Write patients  ");
                Console.WriteLine("4 : Add patient  ");
                Console.WriteLine("5 :   ");
                Console.WriteLine("6 :   ");
                casec = Console.ReadLine();
                switch (casec)
                {
                    case "1":
                        DoctorsList.AddDoctor();
                        break;
                    case "2":
                        DoctorsList.ShowDoctorsList();
                        break;
                    case "3":
                        PatientList.ShowPatientList();
                        break;
                    case "4":
                        PatientList.AddPatient();
                        break;
                    case "5":
                        ListOfMedicalExaminations.ShowListOfMedicalExaminations();
                        break;
                    case "6":
                        ListOfMedicalExaminations.AddExamination();
                        break;
                    case "7":
                        ListOfMedicalExaminations.CheckDate();
                        break;
                    case "9":
                        Console.ReadKey();
                        break;

                }
            } while (casec != "9");

            Console.ReadKey();
        }

           
    }
}