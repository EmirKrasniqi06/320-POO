using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Dispatch : IDispatchable
    {
        public List<Box> boxesToDispatch = new List<Box>();

        public void AddBox(Box box)
        {
            boxesToDispatch.Add(box);
            Console.WriteLine("The box is ready to dispatch !");
        }
        public void RetiredBox(Box box)
        {
            boxesToDispatch.Remove(box);
            Console.WriteLine("The box has been dispatched !");                
        }
    }
}
