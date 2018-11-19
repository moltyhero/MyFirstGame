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
        public Rectangle? SourceRectangle { get; set; }
        Color color;
        float rotation;
        public Vector2 Origin { get; set; }
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
            this.SourceRectangle = sourceRectangle;
            this.color = color;
            this.rotation = rotation;
            this.Origin = origin;
            this.scale = scale;
            this.effects = effects;
            this.layerDepth = layerDepth;

        }

        public Drawer(Vector2 position, Vector2 scale, Color color,
            float rotation = 0,
            SpriteEffects effects = SpriteEffects.None, float layerDepth = 0)
        {

            this.position = position;
            this.color = color;
            this.rotation = rotation;
            this.scale = scale;
            this.effects = effects;
            this.layerDepth = layerDepth;

        }

        public void Draw()
        {
            Globals.spriteBatch.Draw(texture, position, SourceRectangle, color,
                rotation, Origin, scale, effects, layerDepth);
        }
    }
}
