using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deplacement_Escargot
{
    internal class snailClass
    {
        // Attributs
        public int lifePoints = 50;      // Vie du escargot
        public int x = 30;               // Position horizontale
        public int y = 10;               // Position verticale
        public string alive = "_@_ö";    // Escargots vivant
        public string dead = "____";     // Escargot 1 mort 
        
        // Constructeur
        public snailClass(int starty)
        {
            y = starty;
        }

        // Méthodes 
        public void Move()
        {
            x++;

        }
        public void Display()
        {
            Console.WriteLine($"{alive}");
        }
    }
}
