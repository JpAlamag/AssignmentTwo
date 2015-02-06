using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: John Paul Alamag - 300792027
 * Program: Assignment Two - SuperHero Class
 * Date last modified: 2/06/2015
 * Revision History: Main Class created, showPowers method edited
 */

namespace AssignmentTwo___Superhero_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero myhero = new SuperHero("Zelda");
            myhero.showPowers();
            Console.WriteLine();
            myhero.fight();
        }
    }
}
