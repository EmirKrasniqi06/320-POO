using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Box
    {
        // Attributs
        public int id;
        public int weight; // en kilo
        public Color color; // couleur des smarties
        private Color[] colors = new Color[5] { Color.Red, Color.Yellow, Color.Blue, Color.Brown, Color.Orange };
        
        Random alea = new Random();

        public Box ()
        {
            id = alea.Next(10000, 99999);
            weight = alea.Next(5, 10);
            color = colors[alea.Next(0, 5)];
        }
    }
}
