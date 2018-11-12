using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class GameObject : Animation
    {
        public GameObject(Texture2D texture, Vector2 position,
            Rectangle? sourceRectangle, Color color,
            float rotation, Vector2 origin, float scale,
            SpriteEffects effects, float layerDepth) :
            base(texture, position,
              sourceRectangle, color,
             rotation, origin, scale,
             effects, layerDepth)
        {
          
        }
        public void update()
        {
            position.X += 10;
            
        }
    }
}