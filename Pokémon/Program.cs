using System;

namespace Pokémon_Tester
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            Pokémon Bulbasaur = new Pokémon();
            Bulbasaur.Name = "Bulbasaur";
            Bulbasaur.Type = "Grass/Poison";
            Bulbasaur.Number = 1;

            Bulbasaur.HP_Base = 45;
            Bulbasaur.Attack_Base = 49;
            Bulbasaur.Defense_Base = 49;
            Bulbasaur.SpecialAttack_Base = 65;
            Bulbasaur.SpecialDefense_Base = 65;
            Bulbasaur.Speed_Base = 45;

            Pokémon Charmander = new Pokémon();
            Charmander.Name = "Charmander";
            Charmander.Type = "Fire";
            Charmander.Number = 4;

            Charmander.HP_Base = 39;
            Charmander.Attack_Base = 52;
            Charmander.Defense_Base = 43;
            Charmander.SpecialAttack_Base = 60;
            Charmander.SpecialDefense_Base = 50;
            Charmander.Speed_Base = 65;

            Pokémon Squirtle = new Pokémon();
            Squirtle.Name = "Squirtle";
            Squirtle.Type = "Water";
            Squirtle.Number = 7;
            Squirtle.HP_Base = 44;
            Squirtle.Attack_Base = 48;
            Squirtle.Defense_Base = 65;
            Squirtle.SpecialAttack_Base = 50;
            Squirtle.SpecialDefense_Base = 64;
            Squirtle.Speed_Base = 43;

            Bulbasaur.ShowInfo();
            Charmander.ShowInfo();
            Squirtle.ShowInfo();

            Console.WriteLine("Hoe vaak wil je de pokémons levelen?");
            int levelup = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<levelup; i++)
            {
                Squirtle.VerhoogLevel();
                Charmander.VerhoogLevel();
                Bulbasaur.VerhoogLevel();
            }

            Console.WriteLine($"Na {levelup} keer te verhogen");

            Bulbasaur.ShowInfo();
            Charmander.ShowInfo();
            Squirtle.ShowInfo();
            */

            //Vervang 1 of beide door 'null' om exceptions uit te testen!
            Pokémon pok1 = GeneratorPokémon("Pok1");
            Pokémon pok2 = GeneratorPokémon("Pok2");

            Battle(pok1, pok2);


        }

        static Pokémon GeneratorPokémon(string naamin)
        {
            Random r = new Random();
            Pokémon rpoké = new Pokémon();

            rpoké.Name = naamin;
            rpoké.HP_Base = r.Next(40, 70);
            rpoké.Attack_Base = r.Next(40, 70);
            rpoké.Defense_Base = r.Next(40, 70);
            rpoké.SpecialAttack_Base = r.Next(40, 70);
            rpoké.SpecialDefense_Base = r.Next(40, 70);
            rpoké.Speed_Base = r.Next(40, 70);

            return rpoké;

        }

        static int Battle(Pokémon poké1, Pokémon poké2)
        {
            int win = -1;

            if (poké1 != null && poké2 != null)
            {
                if (poké1.Average > poké2.Average)
                {
                    win = 1;
                    Console.WriteLine($"{poké1.Name} heeft gewonnen!");
                    Console.WriteLine($"Average stats score {poké1.Name}: {poké1.Average}");
                    Console.WriteLine($"Average stats score {poké2.Name}: {poké2.Average}");
                    return win;
                }

                else if (poké2.Average > poké1.Average)
                {
                    win = 2;
                    Console.WriteLine($"{poké2.Name} heeft gewonnen!");
                    Console.WriteLine($"Average stats score {poké2.Name}: {poké2.Average}");
                    Console.WriteLine($"Average stats score {poké1.Name}: {poké1.Average}");
                    return win;
                }
                else //Als beide gelijk zijn
                {
                    win = 0;
                    Console.WriteLine($"Niemand heeft gewonnen of verloren, they were evenly matched!");
                    Console.WriteLine($"Average stats score {poké1.Name}: {poké1.Average}");
                    Console.WriteLine($"Average stats score {poké2.Name}: {poké2.Average}");
                    return win;
                }
            }
            else // als (één van) beide dus wel null zijn
            {
                if (poké1 == null && poké2 != null)
                {
                    Console.WriteLine("De eerste Pokémon is nog niet volledig aangemaakt/gedclareerd!");
                    return 2;
                }
                else if (poké2 == null && poké1 != null)
                {
                    Console.WriteLine("De tweede Pokémon is nog niet volledig aangemaakt/gedclareerd!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Beide pokémons zijn nog niet volledig aangemaakt en gedclareerd!");
                }
                Console.WriteLine("NULL ERRROR");
                return 0;
                
            }
        }
    }
}
