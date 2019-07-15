using Core.Entities;
using Core.Entities.Math;
using Core.ProcessManager.Interfaces;

namespace Core.Model
{
    public class Spaceship : IRenderable
    {
        public DisplayObject View { get; set; }

        public Vector2d Point { get; set; }

        public Vector2d Destination { get; set; }

        public void Render()
        {
            View.X = Point.X;
            View.Y = Point.Y;
        }

    }
}
