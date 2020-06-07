using System;
using System.Collections.Generic;
using System.Text;

namespace Magic
{
    enum Color { White, Black, Red, Green, Blue}
    class Magic_Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Give player a name");
                }
                else
                    name = value;
            }
        }

        private int cards = 7;

        public int Cards
        {
            get { return cards; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Can't have less than 0 cards!");
                else
                    cards = value;
            }
        }

        private Color mana;

        public Color Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        private int health = 20;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private bool didMulligan;

        public bool DidMulligan
        {
            get { return didMulligan; }
            set { didMulligan = value; }
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks opponent");
        }

        public void CreatureSpawn()
        {
            Console.WriteLine($"{Name} casts a creature spell");
        }

        public void Mulligan()
        {
            if (DidMulligan == true)
            {
                Console.WriteLine($"{Name} did mulligan in the beginning");
            }
            else
            {
                Console.WriteLine($"{Name} kept his hand of {Cards} cards");
            }
        }

        public void SetUp(string nameset, int cardsset, Color manaset, int healthset, bool mulliganset)
        {
            Name = nameset;
            Cards = cardsset;
            Mana = manaset;
            health = healthset;
            DidMulligan = mulliganset;
        }

        public void Info()
        {
            Console.WriteLine("Player");
            Console.WriteLine("~~~~~~~~~~~");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Cards in hand: " + Cards);
            Console.WriteLine("Deck Color (mana): " + Mana);
            Console.WriteLine("Mulligan?: " + DidMulligan);
        }

        // static methods
        static void SimuleerSpeler(Magic_Player testspeler)
        {
            for (int i = 0; i < 3; i++)
            {
                testspeler.Attack();
            }
            for (int i = 0; i < 3; i++)
            {
                testspeler.CreatureSpawn();
            }
        }

        static void SimuleerWedstrijd(Magic_Player speler1, Magic_Player speler2)
        {
            Random r = new Random();

            if (r.Next(0,11) < 5)
            {
                Console.WriteLine($"{speler1.name} wint!");
            }
            else
            {
                Console.WriteLine($"{speler2.name} wint!");
            }
        }

        static Magic_Player BesteSpeler(Magic_Player speler1, Magic_Player speler2)
        {
            Random r = new Random();

            if (r.Next(0, 11) < 5)
            {
                Console.WriteLine($"{speler1.name} is de beste!");
                return speler1;
            }
            else
            {
                Console.WriteLine($"{speler2.name} is de beste!");
                return speler2;
            }
        }
    }
    
    }
}
