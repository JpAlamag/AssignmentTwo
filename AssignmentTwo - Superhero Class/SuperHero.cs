using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo___Superhero_Class
{
    class SuperHero: Hero // Inherit from hero class
    {
        // String array ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private string[] superPowers;

        // Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public SuperHero(string name) : base(name)
        {
            this.generateRandomPowers();
        }

        // Private methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void generateRandomPowers()
        {
            string[] attribute = {"Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control"};
            this.superPowers = new string[3];
            int counter = 0;

            // Loop that chooses the super powers randomly 
            while (counter < superPowers.Length)
            {
                Random rand = new Random();
                int number = rand.Next(6);

                if (attribute[number] != "void")
                {
                    superPowers[counter] = attribute[number];
                    attribute[number] = "void";
                    counter++;
                }
            }
        }
        
        // Public methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public void showPowers()
        {
            Console.WriteLine(" _|^|_|^|_|^|_|^|_|^|_|^|_|^|_|^|_|^|_|^|_|^|_");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|             The Hylian Heroine              |");
            Console.WriteLine("|               Princess {0}                |", this.name);
            Console.WriteLine("|                                             |");
            Console.WriteLine("|             Her Current Powers:             |");
            Console.WriteLine("|                                             |");  
        
            for (int counter = 0; counter < this.superPowers.Length; counter++)
            {
                Console.WriteLine("|               {0}                         ", superPowers[counter]);
            }

            Console.WriteLine("|_____________________________________________|");
        }
    }
}
