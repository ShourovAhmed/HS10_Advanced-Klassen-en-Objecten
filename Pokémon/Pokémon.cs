using System;
using System.Collections.Generic;
using System.Text;

namespace Pokémon_Tester
{
    class Pokémon
    {

        //BASE STATS

        private int hp_base;

        public int HP_Base
        {
            get { return hp_base; }
            set { hp_base = value; }
        }

        private int attack_base;

        public int Attack_Base
        {
            get { return attack_base; }
            set { attack_base = value; }
        }

        private int defense_base;

        public int Defense_Base
        {
            get { return defense_base; }
            set { defense_base = value; }
        }

        private int specialAttack_base;

        public int SpecialAttack_Base
        {
            get { return specialAttack_base; }
            set { specialAttack_base = value; }
        }

        private int specialDefense_base;

        public int SpecialDefense_Base
        {
            get { return specialDefense_base; }
            set { specialDefense_base = value; }
        }

        private int speed_base;

        public int Speed_Base
        {
            get { return speed_base; }
            set { speed_base = value; }
        }

        //Extra Stats
        public string Name { get; set; } = "Unknown";
        public string Type { get; set; } = "Unknown Type";
        public int Number { get; set; } = -1;

        //READ-ONLY
        public double Average
        {
            get
            { return (Total / 6.0); }
        }
        public int Total
        {
            get
            { return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base); }
        }

        //LEVEL BASED STATS
        private int level = 1;

        public int Level
        {
            get { return level; }
            private set { level = value; }
        }

        public int HP_Full
        {
            get
            { return (((HP_Base + 50) * Level) / 50) + 10; }
        }

        public int Attack_Full
        {
            get
            {
                return ((Attack_Base * Level) / 50) + 5;
            }
        }

        public int Defense_Full
        {
            get
            {
                return ((Defense_Base * Level) / 50) + 5;
            }
        }

        public int SpecialAttack_Full
        {
            get
            {
                return ((SpecialAttack_Base * Level) / 50) + 5;
            }
        }

        public int SpecialDefense_Full
        {
            get
            {
                return ((SpecialDefense_Base * Level) / 50) + 5;
            }
        }

        public int Speed_Full
        {
            get
            {
                return ((Speed_Base * Level) / 50) + 5;
            }
        }


        //METHODEN
        public void VerhoogLevel()
        {
            Level++;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} (level {Level})");
            Console.WriteLine("Base Stats:");
            Console.WriteLine($"\t* Health = {HP_Base}");
            Console.WriteLine($"\t* Attack = {Attack_Base}");
            Console.WriteLine($"\t* Defense = {Defense_Base}");
            Console.WriteLine($"\t* Special Attack = {SpecialAttack_Base}");
            Console.WriteLine($"\t* Special Defense = {SpecialDefense_Base}");
            Console.WriteLine($"\t* Speed = {Speed_Base}");
            Console.WriteLine("");
            Console.WriteLine($"\t* Total = {Total}");
            Console.WriteLine($"\t* Average = {Average:F2}");

            Console.WriteLine("");

            Console.WriteLine("Full Stats:");
            Console.WriteLine($"\t* Health = {HP_Full}");
            Console.WriteLine($"\t* Attack = {Attack_Full}");
            Console.WriteLine($"\t* Defense = {Defense_Full}");
            Console.WriteLine($"\t* Special Attack = {SpecialAttack_Full}");
            Console.WriteLine($"\t* Special Defense = {SpecialDefense_Full}");
            Console.WriteLine($"\t* Speed = {Speed_Full}");
            Console.WriteLine("");
            Console.WriteLine($"\t* Total = {Total}");
            Console.WriteLine($"\t* Average = {Average:F2}");

            Console.WriteLine("\n");

        }




    }
}
