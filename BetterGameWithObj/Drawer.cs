using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace BetterGameWithObj
{
    class Drawer : IFocus
    {
        #region Data
        public List<Texture2D> Textures { get; set; }
        private Vector2 position;
        public Rectangle? SourceRectangle { get; set; }
        Color color;
        protected float rotation;
        public Vector2 Origin { get; set; }
        public Vector2 Position { get => position; set => position = value; }

        Vector2 scale;
        protected SpriteEffects effects;
        float layerDepth;
        protected int frame; // Defines which rectangle will be taken
        #endregion

        public Drawer(List<Texture2D> textures, Vector2 position,
            Rectangle? sourceRectangle, Color color,
            Vector2 origin, Vector2 scale,
            SpriteEffects effects, float layerDepth,
            float rotation = 0)
        {

            this.Textures = textures;
            this.Position = position;
            this.SourceRectangle = sourceRectangle;
            this.color = color;
            this.rotation = rotation;
            this.Origin = origin;
            this.scale = scale;
            this.effects = effects;
            this.layerDepth = layerDepth;
            frame = 0;

        }

        public Drawer(Vector2 position, Vector2 scale, Color color,
            float rotation = 0,
            SpriteEffects effects = SpriteEffects.None, float layerDepth = 0)
        {

            this.Position = position;
            this.color = color;
            this.rotation = rotation;
            this.scale = scale;
            this.effects = effects;
            this.layerDepth = layerDepth;
            //Game1.event_draw += Draw;

        }

        public void Draw()
        {
            Globals.spriteBatch.Draw(Textures[frame], Position, SourceRectangle, color,
                rotation, Origin, scale, effects, layerDepth);
        }
    }
}
