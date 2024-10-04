using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        private int _PowerConsumption;
        Random alea = new Random();
        private int productionTimer = 0;
        public Factory(int width, int depth) : base(width, depth)
        {
            width = 30;
            depth = 30;
        }
        public void Update(int interval)
        {
            productionTimer++;
            if (productionTimer > alea.Next(30, 70))
            {
                // Carton produit
                Box box = new Box();
                Console.WriteLine("1 Box of Smarties has been created !");
                // Carton prêt pour être livré
                AirSpace.dispatch.AddBox(box);
                // Carton livré
                AirSpace.dispatch.RetiredBox(box);
                productionTimer = 0;

            }
        }
    }
}
