using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctors1
{
    class ListOfMedicalExaminations
    {
        public List<examinations> ExaminationList;
        public ListOfMedicalExaminations()
        {
            this.ExaminationList = new List<examinations>();
            examinations all = new examinations();
            all.name = "kolanoskopy";
            all.price = 100;
            all.ID = 1;
            all.PatientID = 1;
            all.dateday = 12;
            all.datemonth = 11;
            this.ExaminationList.Add(all);


        }


        public void ShowListOfMedicalExaminations()
        {
            foreach (var examinations in this.ExaminationList)
            {
                Console.WriteLine(examinations.WriteExaminations());
            }
        }

        public void CheckDate()
        {
                int day;
                int month;
                Console.WriteLine("Give a day");


                day = Console.ReadLine();
                Console.WriteLine("Give a month");
                month = Console.ReadLine();
            
                foreach (var examinations in this.ExaminationList)
                {
                int d = (int)System.DateTime.Now.DayOfWeek;
                int m = (int)System.DateTime.Now.Month;
                int dr =  examinations.dateday - d;
                int mr = examinations.datemonth - m;
                if(dr>0)
                {
                    mr = mr - 1;
                    Console.WriteLine("go to examination "+ examinations.name+ " days left: " + dr + " months left:" + mr );

                }
                else
                {
                    mr = mr-1;
                    dr = dr + 30;
                    Console.WriteLine("go to examination" + examinations.name + " days left: " + dr + " months left:" + mr);


                }

                }



            }

        public void AddExamination()
        {
            examinations all = new examinations();
            Console.WriteLine("Write name of examination");
            all.name = Console.ReadLine();
            Console.WriteLine("Write price");
            all.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write ID");
            all.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write PatientID");
            all.PatientID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write month to examination");
            all.datemonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a day");
            all.dateday = Convert.ToInt32(Console.ReadLine());


            this.ExaminationList.Add(all);
        }




    }
}
