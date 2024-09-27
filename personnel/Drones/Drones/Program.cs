using Drones;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            for (int i = 0; i < 1; i++)
            {
                Drone drone = new Drone(500, 500, "Emir");
                fleet.Add(drone);
            }

            // Création batîments
            List<Building> buildings = new List<Building>();
            for (int i=0; i<5; i++)
            {
                Building building = new Building(50,50);
                buildings.Add(new Factory(30,30));
                buildings.Add(new Store(15,15));
            }

            // Démarrage
            try
            {
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // Console.WriteLine(e.ToString());
                Console.ReadKey();
            }


        }
    }
}