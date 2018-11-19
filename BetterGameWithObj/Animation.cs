using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class Animation : Drawer
    {
        Page page;
        int frame; // Defines which rectangle will be taken
        int paste = 0; // Defines the animation replace speed

        public Animation(Characters character, States state,
            Vector2 position, Vector2 scale, Color color,
            float rotation = 0, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0)
            : base(position, scale, color, rotation, effects, layerDepth)
        {
            this.page = new Page(character, state);
            this.frame = 0;
        }

        public void Animate()
        {
            this.SourceRectangle = page.rectangles[frame];
            this.Origin = page.originsList[frame];
            if (paste++ % 10 == 0) // Here you can change the speed of the animation
            {
                this.frame++;
                this.frame %= page.originsList.Count;
            }
            
            base.Draw();
        }

        
    }
}