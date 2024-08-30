namespace Deplacement_Escargot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escargot = "_@_ö";
            Console.WriteLine(escargot);
            int lifePoints = 50;
            Console.SetCursorPosition(50, 5);
            Console.WriteLine(lifePoints);
            int verticalPosition = 10;
            int horizontalPosition = 30;
            Console.SetCursorPosition(horizontalPosition, verticalPosition);
            Console.WriteLine(escargot);
            Console.CursorVisible = false;
            while (lifePoints > 0)
            { 
                Console.Clear();
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("Points de vie : "+lifePoints);
                horizontalPosition++;
                Console.SetCursorPosition(horizontalPosition, verticalPosition);
                Console.WriteLine(escargot);
                lifePoints--;
                Thread.Sleep(100); // Vitesse de l'exécution du programme
            }
            Console.ReadLine();
        }
    }
}
