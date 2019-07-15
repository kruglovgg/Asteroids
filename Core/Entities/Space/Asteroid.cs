using Core.Entities.Math;

namespace Core.Entities.Space
{
    public class Asteroid
    {
        public Asteroid()
        {
            Direction = new Vector2d();
            Position = new Vector2d();
        }

        public Vector2d Direction { get; set; }
        public Vector2d Position { get; set; }
        public enum Size { Small, Medium, Large }
        public double Speed { get; set; }

        private void Normalize()
        {
            Speed = System.Math.Sqrt(Direction.X * Direction.X + Direction.Y * Direction.Y);
            Direction.X *= 1 / Speed;
            Direction.Y *= 1 / Speed;
        }

        public void AddVector(Vector2d newDirection, float newSpeed)
        {
            var unnormVec = new Vector2d();
            var newVec = new Vector2d();

            unnormVec.X = Direction.X * Speed;
            unnormVec.Y = Direction.Y * Speed;

            newVec.X = newDirection.X * newSpeed;
            newVec.Y = newDirection.Y * newSpeed;

            Direction.X = unnormVec.X + newVec.X;
            Direction.Y = unnormVec.Y + newVec.Y;

            Normalize();

        }

        public void Move()
        {
            Position.X += Direction.X * Speed;
            Position.Y += Direction.Y * Speed;
        }

    }

}
