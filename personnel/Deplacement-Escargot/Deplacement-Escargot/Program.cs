using Deplacement_Escargot;
namespace Deplacement_Escargot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Voir le fichier snailClass.cs

            // Liste des escargots
            List<snailClass> snails = new List<snailClass>();

            // Demande à l'utilisateur le nombre d'escargots à afficher
            Console.WriteLine("Combien d'escargot voulez-vous afficher ?");
            int nbEscargot = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nbEscargot; i++)
            {
                snailClass newSnail = new snailClass(starty: i + 2);
                snails.Add(newSnail);
            }
            foreach (snailClass snail in snails)
            {
                snail.Display();
            }


            //// Affichage escargot 1
            //Console.SetCursorPosition(snail1.x, 10);
            //Console.WriteLine(snail1.alive);

            //// affichage escargot 2
            //Console.SetCursorPosition(snail2.x, 10);
            //Console.WriteLine(snail2.alive);

            //while (snail1.lifePoints > 0)
            //{
            //    // Affichage des points de vie de l'escargot 1
            //    Console.SetCursorPosition(50, 5);
            //    Console.WriteLine("Points de vie : " + snail1.lifePoints);

            //    // Affichage des points de vie de l'escargot 2
            //    Console.SetCursorPosition(50, 5);
            //    Console.WriteLine("Points de vie : "+ snail2.lifePoints);

            //    // Methode qui ajoute +1 à la position horizontale
            //    snail1.Move();
            //    Console.SetCursorPosition(snail1.x, 10);
            //    Console.WriteLine(snail1.alive);
            //    Console.SetCursorPosition(snail1.x, 12);
            //    Console.WriteLine(snail1.alive);
            //    snail1.lifePoints--;
            //    Thread.Sleep(50); // Vitesse de l'exécution du programme
            //    Console.Clear();
            //}
            //Console.SetCursorPosition(50, 5);
            //Console.WriteLine("L'escargot il est mort !");
            //Console.SetCursorPosition(snail1.x, 10);
            //Console.WriteLine(snail1.dead);
            //Console.SetCursorPosition(snail1.x, 12);
            //Console.WriteLine(snail1.dead);
            //Console.ReadLine();
        }
    }
}
