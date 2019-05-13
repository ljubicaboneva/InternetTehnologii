using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Scene
    {
        private List<Circle> circles;
        public Color CurrentColor { get; set; }
        public Scene()
        {
            circles = new List<Circle>();
            CurrentColor = Color.BlueViolet;
        }
        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.Draw(g);
            }
        }

        public void AddCircle(Point position)
        {
            Circle circle = new Circle(position, CurrentColor);
            circles.Add(circle);
        }
    }
}
