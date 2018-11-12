using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class Drawer
    {
        #region Data
        Texture2D texture;
        protected Vector2 position;
        Rectangle? sourceRectangle;
        Color color;
        float rotation;
        Vector2 origin;
        Vector2 scale;
        SpriteEffects effects;
        float layerDepth; 
        #endregion

        public Drawer(Texture2D texture, Vector2 position,
            Rectangle? sourceRectangle, Color color,
            float rotation, Vector2 origin, Vector2 scale,
            SpriteEffects effects, float layerDepth)
        {

            this.texture = texture;
            this.position = position;
            this.sourceRectangle = sourceRectangle;
            this.color = color;
            this.rotation = rotation;
            this.origin = origin;
            this.scale = scale;
            this.effects = effects;
            this.layerDepth = layerDepth;

        }

        public void Draw()
        {
            Globals.spriteBatch.Draw(texture, position, sourceRectangle, color,
                rotation, origin, scale, effects, layerDepth);
        }
    }
}
