﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class Animation : Drawer
    {
        #region Varriables
        Page page;
        int paste = 1; // Defines the animation replace speed 
        Characters character;
        protected States state;
        #endregion

        public Animation(Characters character, States state,
            Vector2 position, Vector2 scale, Color color,
            float rotation = 0, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0)
            : base(position, scale, color, rotation, effects, layerDepth)
        {
            this.character = character;
            this.state = state;
            this.frame = 0;
            Game1.event_draw += Animate;
        }

        public void Animate()
        {
            this.page = Dictionary.dic[character][state];
            this.SourceRectangle = page.rectangles[frame];
            this.Origin = page.originsList[frame];
            this.Textures = page.Textures;
            if (paste++ % 10 == 0) // Here you can change the speed of the animation
            {
                this.frame++;
                this.frame %= page.originsList.Count;
            }
            
            base.Draw();
        }

        
    }
}