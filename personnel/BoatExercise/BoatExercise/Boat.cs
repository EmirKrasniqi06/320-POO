using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatExercise
{
    public partial class Boat
    {
        private int _year;          // Année de production du bateau
        private int _tonnage;       // Nombre de ton que le bateau peut transporter
        private string _country;    // Pays du bateau

        // Liste des containers contenu dans le bateau
        private List <Container> containers = new List <Container> ();
        public Boat(int year, int tonnage, string county)
        {
            _year = year;
            _tonnage = tonnage;
            _country = county;
        }
        private void Load(int weight)
        {

        }
        private void Unload(int id)
        {

        }
    }
}
