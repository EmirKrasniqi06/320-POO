using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatExercise
{
    public partial class Radioactive : Container
    {
        private int _randMax;   
        public Radioactive(int id, int weight, int randMax) :  base(id, weight)
        {
            _randMax = randMax;
        }
    }
}
