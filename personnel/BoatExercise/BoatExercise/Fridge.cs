using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatExercise
{
    public partial class Fridge : Container
    {
        private int _temperature;   // Temperature du container
        public Fridge(int id, int weight, int temperature) : base(id, weight)
        {
            _temperature = temperature;
        }
    }
}
