using Drones.Helpers;
using Drones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        private Color _buidlingColor = Color.Green; // La couleur
        private int _x = GlobalHelpers.alea.Next(100, 1100); // Position horizontale aléatoire
        private int _y = GlobalHelpers.alea.Next(50, 550); // Position verticale aléatoire
        private int _width;
        private int _depth;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        // Constructeur
        public Building(int width, int depth)
        {
            _width = width;
            _depth = depth;
            _buildingBrush = new Pen(new SolidBrush(_buidlingColor), 3);
        }
        public Color BuildingColor
        {
            get => _buidlingColor;
            set
            {
                _buidlingColor = value;
                _buildingBrush = new Pen(new SolidBrush(BuildingColor), 3);
            }
        }
        public int Width { get => _width; set => _width = value; }
        public int Depth { get => _depth; set => _depth = value; }
    }
}
