using System;

using System.Collections.Generic;
using System.Text;
/* Lesen 1*/

namespace lab3
{

    enum printProperty
    {
        id,
        name,
        lastname,
        age,
        level,
        team,
        specialyM,
        education
    }
    abstract class People
    {
        public static int id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public int Age { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nLastName: {2}\nAge: {3}\nLevel: {4}\nTeam: {5}\n\n",
              Id, Name, Lastname, Age
            );
        }

        public virtual void Print(printProperty property)
        {
            switch (property)
            {
                case printProperty.id:
                    Console.WriteLine("ID: {0}\n\n", Id);
                    break;
                case printProperty.name:
                    Console.WriteLine("Name: {0}\n\n", Name);
                    break;
                case printProperty.lastname:
                    Console.WriteLine("Lastname: {0}\n\n", Lastname);
                    break;
                case printProperty.age:
                    Console.WriteLine("Age: {0}\n\n", Age);
                    break;
                default:
                    Console.WriteLine("There are no requested property in Person object.");
                    break;
            }
        }



        public People(string name, string lastname, int age)
        {
            People.id++;
            this.Id = People.id;
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }
    }

    abstract class Sportsmen : People
    {
        public string Level { get; set; }
        public string Team { get; set; }


        public override void Print()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nLastName: {2}\nAge: {3}\nLevel: {4}\nTeam: {5}\n\n",
              Id, Name, Lastname, Age, Level, Team
            );
        }
        public override void Print(printProperty property)
        {
            switch (property)
            {
                case printProperty.id:
                    Console.WriteLine("ID: {0}\n\n", Id);
                    break;
                case printProperty.name:
                    Console.WriteLine("Name: {0}\n\n", Name);
                    break;
                case printProperty.lastname:
                    Console.WriteLine("Lastname: {0}\n\n", Lastname);
                    break;
                case printProperty.age:
                    Console.WriteLine("Age: {0}\n\n", Age);
                    break;
                case printProperty.level:
                    Console.WriteLine("Rank: {0}\n\n", this.Level);
                    break;
                case printProperty.team:
                    Console.WriteLine("Weight: {0}\n\n", this.Team);
                    break;

                default:
                    Console.WriteLine("There are no requested property in Sportsmen object.");
                    break;
            }
        }

        public Sportsmen(string level, string team, string lastname, string name, int age) : base(lastname, name, age)
        {
            this.Level = level;
            this.Team = team;

        }
    }
    class Specialy : Sportsmen
    {
        public string SpecialyM { get; set; }
        public string Education { get; set; }
        public override void Print()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nLastName: {2}\nAge: {3}\nLevel: {4}\nTeam: {5}\nSpecialy: {6}\nEducation: {7}\n\n",
               Id, Name, Lastname, Age, Level, Team, SpecialyM, Education
             );
        }

        public override void Print(printProperty property)
        {
            switch (property)
            {
                case printProperty.id:
                    Console.WriteLine("ID: {0}\n\n", Id);
                    break;
                case printProperty.name:
                    Console.WriteLine("Name: {0}\n\n", Name);
                    break;
                case printProperty.lastname:
                    Console.WriteLine("Lastname: {0}\n\n", Lastname);
                    break;
                case printProperty.age:
                    Console.WriteLine("Age: {0}\n\n", Age);
                    break;
                case printProperty.level:
                    Console.WriteLine("Rank: {0}\n\n", this.Level);
                    break;
                case printProperty.team:
                    Console.WriteLine("Weight: {0}\n\n", this.Team);
                    break;
                case printProperty.specialyM:
                    Console.WriteLine("Specialy: {0}\n\n", this.SpecialyM);
                    break;
                case printProperty.education:
                    Console.WriteLine("Education: {0}\n\n", this.Education);
                    break;

                default:
                    Console.WriteLine("There are no requested property in Sportsmen object.");
                    break;
            }
        }


        public Specialy(string specialyM, string education, string level, string team, string lastname, string name, int age) : base(level, team, lastname, name, age)
        {
            this.SpecialyM = specialyM;
            this.Education = education;
        }
    }
    class Program
    {
        static void Main()
        {
            Specialy man = new Specialy("football", "high", "very high", "real", "ronaldo", "cristiano", 35);

            man.Print();


            Console.ReadLine();
        }
    }
}

/* 
 class Programm
{
    static List<Specialy> Storage = new List<Specialy>();

    static void Add(int n)
    {

        Console.WriteLine("Enter name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter lastname : ");
        string lastname = Console.ReadLine();
        Console.WriteLine("Enter age : ");
        string age = Console.ReadLine();
        Console.WriteLine("Enter level : ");
        string level = Console.ReadLine();
        Console.WriteLine("Enter team : ");
        string team = Console.ReadLine();
        Console.WriteLine("Enter specialy : ");
        string speciality = Console.ReadLine();
        Console.WriteLine("Enter education  : ");
        string education = Console.ReadLine();
        Speciality form = new Speciality(name, lastname, age, level, team, speciality, education);
        Storage.Add(form);
    }
    static void Add()
    {

        Console.WriteLine("Enter name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter lastname : ");
        string lastname = Console.ReadLine();
        Console.WriteLine("Enter age : ");
        string age = Console.ReadLine();
        Console.WriteLine("Enter level : ");
        string level = Console.ReadLine();
        Console.WriteLine("Enter team : ");
        string team = Console.ReadLine();
        Console.WriteLine("Enter specialy : ");
        string speciality = Console.ReadLine();
        Console.WriteLine("Enter education : ");
        string education = Console.ReadLine();
        Speciality form = new Speciality(name, lastname, age, level, team, speciality, education);
        Storage.Add(form);

    }
    static void AddSportsmen()
    {
        Add();

        Console.Clear();
        Menu();
    }

    static void Change(int n)
    {
        Storage[n].PrintData();
        Console.Write("What do you wan't to change?\n\n 1.All Form\n 2.Name\n 3.Lastname\n 4.Age\n 5.Level\n 6.Team\n 7.Speciality\n 8.Education\n 9.Exit\n");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (choice == 1)
        {
            Add(n);
        }
            else if (choice == 2)
            {
            Storage[n].Name = Console.ReadLine();
            }
            else if (choice == 3)
            {
            Storage[n].Lastname = Console.ReadLine();
            }
            else if (choice == 4)
            {
            Storage[n].Age = Console.ReadLine();
            }
            else if (choice == 5)
            {
            Storage[n].Level = Console.ReadLine();
            }
             else if (choice == 6)
            {
            Storage[n].Team = Console.ReadLine();
            }
            else if (choice == 7)
            {
            Storage[n].SpecialyM = Console.ReadLine();
            }
            else if (choice == 8)
            {
            Storage[n].Education = Console.ReadLine();
            }
             else if (choice != 0)
            {
            Console.WriteLine("Wrong choice");
            }
        Console.Clear();

        Menu();
    }

    static void Delete(int n)
    {
        Storage[n].PrintData();
        Console.Write("Did you wan't to delete this form?\n 1. Yes 2.No");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (choice == 1)
        {
            Storage.RemoveAt(n);

            Console.Clear();

            Menu();
        }
        else
            if (choice == 2)
        {
            Menu();
        }
        else
        {
            Console.WriteLine("Sinax Error.Try again");
            Delete(n);
        }

    }
    static void ChangeDelete()
    {
        Console.WriteLine("\nChoose '0' to Exit or choose Form to edit");
        int formNumber = Convert.ToInt32(Console.ReadLine());

        if (formNumber != 0)
        {
            Console.WriteLine("Change(0) or Delete(1)?");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value == 0)
            {
                Console.Clear();
                Change(formNumber - 1);
            }
            else
                if (value == 1)
            {
                Console.Clear();
                Delete(formNumber - 1);
            }
        }

        Menu();
    }

    static void ShowAllForms()
    {
        for (int i = 0; i < Storage.Count; i++)
        {
            Console.WriteLine("[{0}]\n", i + 1);
            Storage[i].PrintData();
            Console.WriteLine("\n");
        }

        ChangeDelete();

    }
    static int Menu()
    {
        Console.WriteLine("1.Add Sportsmen\n2.Show all\n0.Exit");
        string way = Console.ReadLine();

        Console.Clear();

        if (way == "0")
        {
            return 0;
        }
        else
            if (way == "1")
        {
            AddSportsmen();
        }
        else
             if (way == "2")
        {
            ShowAllForms();
        }
        else
        {
            Menu();
        }

        return 0;

    }
    static void Main(string[] args)
    {
        Menu();
        Console.WriteLine();
    }
}
}

 */
