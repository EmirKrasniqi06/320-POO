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

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            fleet.Add(new Drone(AirSpace.WIDTH/2, AirSpace.HEIGHT/2, "Emir"));

            // Cr�ation bat�ments

            List<Building> buildings = new List<Building>();
            for (int i=0; i<5; i++)
            {
                Building building = new Building(50,50);
                buildings.Add(new Factory(30,30));
                buildings.Add(new Store(15,15));
            }
           try
            {
                // D�marrage
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}