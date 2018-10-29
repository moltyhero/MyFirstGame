using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class Drawer
    {
        Texture2D texture;
        Vector2 position;
        Rectangle? sourceRectangle;
        Color color;
        float rotation;
        Vector2 origin;
        float scale;
        SpriteEffects effects;
        float layerDepth;

        public Drawer(Texture2D texture, Vector2 position,
            Rectangle? sourceRectangle, Color color,
            float rotation, Vector2 origin, float scale,
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
            Game1.spriteBatch.Draw(texture, position, sourceRectangle, color,
                rotation, origin, scale, effects, layerDepth);
        }
    }
}
