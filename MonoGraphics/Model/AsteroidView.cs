using Core.Entities.Space;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGraphics.Model
{
    public class AsteroidView
    {

        public readonly Asteroid AsteroidModel = new Asteroid();

        public Texture2D Texture { get; set; }
    }
}
