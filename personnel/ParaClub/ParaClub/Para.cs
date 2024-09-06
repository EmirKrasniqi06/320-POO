using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class ParaClass
    {
        // View attributes
        private const int PARA_HEIGHT = 6;

        // Table d'affichage du parachutiste sans parachute
        private string[] viewNoParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @" \ / ",
            @"__░__",
            @"  o  ",
        };

        // Table d'affichage du parachutiste avec parachute
        private string[] viewWithParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };

        // Model attributes

        public string name; // Nom parachutiste
        public int x;
        public int altitude;
        public bool parachuteIsOpen; // Bool pour l'ouverture du parachute

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public ParaClass(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Mouvement du parachutiste et utilisation du parachute après avoir dépassé la moitié de l'hauteur de la console
        /// </summary>
        internal void Fallparachutist()
        {
            if (altitude > Config.SCREEN_HEIGHT) // le parachutiste est en air
            {
                if (parachuteIsOpen)
                {
                    altitude--; // Si le parachute est ouvert descendre lentement
                }
                else
                {
                    altitude -= 3; // Si le parachute est fermé descendre rapidement
                }
                if (altitude < Config.SCREEN_HEIGHT/2)
                {
                    parachuteIsOpen = true; // À la moitié de la console faire sortir le parachute
                }
            }
            else // Le parachutiste est descendu
            {
                parachuteIsOpen = false;
            }
        }
        public void parachutistDisplay()
        {
            string[] view = parachuteIsOpen ? viewWithParachute : viewNoParachute; // Si le paracute est ouvert afficher le parachutiste avec le parachute sinon sans
            for (int i = 0; i < view.Length; i++)
            {
                // Afficher le parachutiste au milieu de l'avion et en bas (hauteur de la console - l'hauteur de l'espace en dessous de l'avion +i)
                Console.SetCursorPosition(x + 15, Config.SCREEN_HEIGHT - this.altitude + i);
                Console.WriteLine(view[i]);
            }
            // Afficher le nom du parachutiste
            Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.altitude - 1);
            Console.Write(this.name);
        }
    }
}
