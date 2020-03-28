using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{ 
    class People
    {
        private string name;
        private string lastname;
        private string age;

        protected People()
        {
            name = "underfined";
            lastname = "underfined";
            age = "underfined";
        }

        protected People(string name,
                       string lastname,
                         string age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        protected void PrintPeople()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("LastName : {0}", lastname);
            Console.WriteLine("Age : {0}", Age);

        }
    }
}
