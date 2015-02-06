using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo___Superhero_Class
{
    class Hero
    {
                // PRIVATE PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private int strength;
        private int speed;
        private int health;
        private int hitStrength;
        private bool attempt;

        // Random number generator for any method that requires one
        private static Random randomNum = new Random(); 


        // PUBLIC PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public string name;


        // CONSTRUCTOR ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
        }


        // PRIVATE METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Random skill points generated from 0-100
        private void generateAbilities()
        {
            this.strength = randomNum.Next(0, 100) + 1;
            this.speed = randomNum.Next(0, 100) + 1;
            this.health = randomNum.Next(0, 100) + 1;

        }

        // Determines if hit is landed or not (20% chance)
        private bool hitAttempt()
        {
                if (randomNum.Next(0, 6) == 1)
                {
                    this.attempt = true;
                }
                else
                {
                    this.attempt = false;
                }
            return this.attempt;
        }

        // Calculates amount of damage dealt to enemy (random number from 1-6)
        private int hitDamage()
        {
            Random damage = new Random ();
            this.hitStrength = this.strength * (damage.Next (0, 6) + 1);
            return hitStrength;
        }

        // PUBLIC METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Simulates combat
        public void fight()
        {
                if (this.attempt == true)
                {
                    hitDamage();
                    Console.WriteLine("{0} damage dealt! Nice hit!", this.hitStrength);
                }
                else
                {
                    Console.WriteLine("You missed! Try again, Princess ;)");
                }
        }

        // Shows heroine's randomly generated stats
        public void show()
        {
            Console.WriteLine(" _|^|_|^|_|^|_|^|_|^|_|^|_|^|_");
            Console.WriteLine("|                             |");
            Console.WriteLine("|     The Hylian Heroine      |");
            Console.WriteLine("|       Princess {0}        |", this.name);
            Console.WriteLine("|                             |");
            Console.WriteLine("|        Strength: {0}", this.strength);
            Console.WriteLine("|        Speed: {0}", this.speed);
            Console.WriteLine("|        Health: {0}", this.health);
            Console.WriteLine("|_____________________________|");
        }
    }
}
