using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class PlaneClass
    {
        // Grandeur de la console
        public const int WIDTH = 28;
        public const int HEIGHT = 6;

        // Dessin de l'avion sur une table
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        // Attributs de l'avion
        public int x; // positionnement horizontale 
        public int altitude; // Hauteur
        public List<ParaClass> parachutists;

        /// <summary>
        /// Constructeur
        /// </summary>
        public PlaneClass()
        {
            x = 0;
            altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<ParaClass>();
        }
        /// <summary>
        /// Affichage de chaque ligne de la table où se trouve l'avion
        /// </summary>
        public void PlaneDisplay()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.WriteLine(view[i]);
            }
        }
        /// <summary>
        /// Mouvement de l'avion vers droite si il ne se trouve pas dehor la console
        /// </summary>
        public void PlaneMovement()
        {
            if (x >= Config.SCREEN_WIDTH)
            {
                x = 0; // Si l'avion se trouve dehors la console retourner à la position initiale
            }
            else
            {
                x++; // Sinon bouger à droite
            }
        }
        /// <summary>
        /// Embarquer un parachutiste dans l'avion
        /// </summary>
        /// <param name="para"></param>
        public void Board (ParaClass para)
        {
            this.parachutists.Add(para); // Ajouter un parachutiste à la liste
        }
        internal ParaClass DropParachutist()
        {
            ParaClass parachutist = parachutists.First(); // Récupère le premier parachutiste de la liste
            parachutists.Remove(parachutist); // Le supprime car il s'est lancé
            parachutist.x = x; // Reinitialiser la position horizontale avec celle de l'avion
            parachutist.altitude = this.altitude; // Reinitialiser l'hauteur
            return parachutist;
        }
    }


}
