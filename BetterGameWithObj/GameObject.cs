using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class GameObject : Animation
    {
        BaseKeys keys;
        #region Varriables
        // Page page;
        // int frame; // Defines which rectangle will be taken
        // int paste = 0; // Defines the animation replace speed 
        // Characters character;
        #endregion

        public GameObject(BaseKeys keys, Characters character, States state,
            Vector2 position, Vector2 scale, Color color,
            float rotation = 0, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0)
            : base(character, state, position, scale, color, rotation, effects, layerDepth)
        {
            this.keys = keys;
            Game1.event_update += Update;
        }

        public void Update()
        {
            /*if (Globals.keyboardState.IsKeyDown(Keys.))
            {
            }*/


            if (keys.IsLeft())
            {
                if (this.state != States.walk)
                {
                    this.state = States.walk;
                }
                    
                if (this.effects != SpriteEffects.FlipHorizontally)
                {
                    this.effects = SpriteEffects.FlipHorizontally;
                }
                    
                this.position -= Vector2.UnitX * 5;
            }
            else if (keys.IsRight())
            {
                if (this.state != States.walk)
                {
                    this.state = States.walk;
                }
                    
                if (this.effects == SpriteEffects.FlipHorizontally)
                {
                    this.effects = SpriteEffects.None;
                }
                    
                this.position += Vector2.UnitX * 5;
            }
            else this.state = States.idle;
        }
    }
}
