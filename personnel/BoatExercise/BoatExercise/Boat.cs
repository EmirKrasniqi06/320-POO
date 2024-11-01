using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatExercise
{
    public partial class Boat
    {
        private int _year;              // Année de production du bateau
        private int _tonnage;           // Nombre de ton que le bateau peut transporter
        private string _country;        // Pays du bateau
        public int totalWeight = 0;    // Poids total chargé sur le bateau

        // Liste des containers contenu dans le bateau
        public List <Container> containers = new List <Container> ();
        public Boat(int year, int tonnage, string county)
        {
            _year = year;
            _tonnage = tonnage;
            _country = county;
        }
        public void Load(Container container)
        {
            if (totalWeight + container._weight < _tonnage)
            {
                totalWeight += container._weight;
                containers.Add(container);
            }
        }
        public void Unload(int id)
        {
            if (containers.Find(c => c._id == id) != null)
            {
                totalWeight -= containers.Find(c => c._id == id)._weight;
                containers.Remove(containers.Find(c => c._id == id));
            }
        }
    }
}
