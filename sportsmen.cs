
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class sportsmen : People
    {
        private string level;

        private string team;

        protected sportsmen(string level,
                           string team,
                            string name,
                             string lastname,
                              string age) : base(name, lastname, age)
        {
            this.level = level;
            this.team = team;

        }                                                //constructor initialization

        protected sportsmen() : base()
        {
            level = "underfined";
            team = "underfined";
        }

        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Team
        {
            get { return team; }
            set { team = value; }
        }

        protected void PrintSportsmen()
        {
            PrintPeople();
            Console.WriteLine("Team : {0}", team);
            Console.WriteLine("Level : {0}", level);
        }

    }
}

