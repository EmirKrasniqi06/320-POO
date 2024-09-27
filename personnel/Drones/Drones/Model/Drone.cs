namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        Random alea = new Random();

        private int charge = 1000;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x ;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private EvacuationState _state;
        Rectangle droneZone;


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées

        public Drone (int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
            droneZone = new Rectangle(_x - 4, _y - 2, 8, 8);
            _state= EvacuationState.Free;
        }
        public Drone(int x, int y)
        {
            _x = x;
            _y = y;
            droneZone = new Rectangle(_x - 4, _y - 2, 8, 8);
            _state = EvacuationState.Free;
        }

        public bool Evacuate(Rectangle zone)
        {
            if (zone.IntersectsWith(droneZone))
            {
                _state = EvacuationState.Evacuating;
                return false;
            }
            else
            {
                _state = EvacuationState.Evacuated;
                return true;
            }
        }

        public void FreeFlight()
        {
            _state = EvacuationState.Free;
        }

        public EvacuationState GetEvacuationState()
        {
            return _state;
        }

        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
