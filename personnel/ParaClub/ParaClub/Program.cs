using System.Numerics;
using ParaClub;
namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialiser la console
            Console.Clear();
            Console.CursorVisible = false;
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            // Déclaration et creation des objets
            PlaneClass plane = new PlaneClass(); // Instancier un objet de type Plane dans la variable plane (qui fait partie de la classe Plane)

            while (true)
            {
                plane.PlaneMovement();

                Console.Clear();
                plane.PlaneDisplay();

                // Temporiser
                Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
