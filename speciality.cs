using System;

using System.Collections.Generic;
using System.Text;
namespace lab3
{
    class speciality : sportsmen
    {
        private string specialy;
        private string education;
        public speciality(string name,
                            string lastname,
                             string age,
                              string level,
                               string team,
                                string specialy,
                                 string education) : base(level,team,name,lastname,age)
        {
            this.specialy = specialy;
            this.education = education;

        }                                                //constructor initialization

        public speciality() : base()
        {
            specialy = "underfined";
            education = "underfined";
        }

        public string Education
        {
            get { return education; }
            set { education = value; }
        }
        public string SpecialyM
        {
            get { return specialy; }
            set { specialy = value; }
        }

        public void PrintData()
        {
            PrintSportsmen();
            Console.WriteLine("Specialy : {0}", specialy);
            Console.WriteLine("Education : {0}", education);
        }

    }
}