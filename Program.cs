using System;

using System.Collections.Generic;
using System.Text;
/* Lesen 1*/

namespace lab3
{
    class Programm
    {
        static List<speciality> Storage = new List<speciality>();

        static void Add(int n)
        {
            //Storage.Add(new People());
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
            string specialy = Console.ReadLine();
            Console.WriteLine("Enter education  : ");
            string education = Console.ReadLine();
            speciality form = new speciality(name, lastname, age, level, team, specialy, education);
            Storage[n] = form;
        }
        static void Add()
        {
            Storage.Add(new speciality());
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
            string specialy = Console.ReadLine();
            Console.WriteLine("Enter education : ");
            string education = Console.ReadLine();
            speciality form = new speciality(name, lastname, age, level, team, specialy, education);
            Storage[Storage.Count - 1] = form;
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
            else
                if (choice == 2)
            {
                Storage[n].Name = Console.ReadLine();
            }
            else
                    if (choice == 3)
            {
                Storage[n].Lastname = Console.ReadLine();
            }
            else
                        if (choice == 4)
            {
                Storage[n].Age = Console.ReadLine();
            }
            else
                            if (choice == 5)
            {
                Storage[n].Level = Console.ReadLine();
            }
            else
                                if (choice == 6)
            {
                Storage[n].Team = Console.ReadLine();
            }
            else
                                    if (choice == 7)
            {
                Storage[n].SpecialyM = Console.ReadLine();
            }
            else
                                        if (choice == 8)
            {
                Storage[n].Education = Console.ReadLine();
            }
            else
                                            if (choice != 0)
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
