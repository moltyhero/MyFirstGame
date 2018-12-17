using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace BetterGameWithObj
{
    class Drawer
    {
        #region Data
        //public Texture2D Texture { get; set; }
        public List<Texture2D> Textures { get; set; }
        protected int currentTexture = 0;
        protected Vector2 position;
        public Rectangle? SourceRectangle { get; set; }
        Color color;
        float rotation;
        public Vector2 Origin { get; set; }
        Vector2 scale;
        protected SpriteEffects effects;
        float layerDepth; 
        #endregion

        public Drawer(List<Texture2D> textures, Vector2 position,
            Rectangle? sourceRectangle, Color color,
            float rotation, Vector2 origin, Vector2 scale,
            SpriteEffects effects, float layerDepth)
        {

            this.Textures = textures;
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
            Globals.spriteBatch.Draw(Textures[currentTexture], position, SourceRectangle, color,
                rotation, Origin, scale, effects, layerDepth);
        }
    }
}
