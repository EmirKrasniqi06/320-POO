using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        private string[] _openingHours;

        public Store(int width, int depth) : base(width, depth)
        {
            width = 15;
            depth = 15;
        }
    }
}
