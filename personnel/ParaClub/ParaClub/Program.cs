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

            // Créer le groupe de parachutistes
            List<ParaClass> parachutistsInTheAir = new List<ParaClass>();

            // Pour les interactions utilisateur
            ConsoleKeyInfo keyPressed;

            while (true)
            {
                plane.PlaneMovement();

                Console.Clear();
                plane.PlaneDisplay();

                // Temporiser
                Thread.Sleep(100);
            }

            if (Console.KeyAvailable) // L'utilisateur a pressé une touche
            {
                keyPressed = Console.ReadKey(false);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Spacebar:
                        ParaClass jumper = plane.DropParachutist();
                        parachutistsInTheAir.Add(jumper);
                        break;
                    default:
                        break;
                }
            }

            plane.PlaneMovement();
            foreach (ParaClass para in parachutistsInTheAir)
            {
                para.FallParachutist();
            }

            plane.PlaneDisplay();
            foreach (ParaClass para in parachutistsInTheAir)
            {
                para.parachutistDisplay();
            }
            Thread.Sleep(100);
            Console.ReadLine();
        }
    }
}
