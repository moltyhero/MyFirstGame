using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class GameObject : Animation
    {
        BaseKeys keys;
        #region Varriables
        Page page;
        int frame; // Defines which rectangle will be taken
        int paste = 0; // Defines the animation replace speed 
        Characters character;
        States state;
        #endregion

        public GameObject(BaseKeys keys, Characters character, States state,
            Vector2 position, Vector2 scale, Color color,
            float rotation = 0, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0)
            : base(character, state, position, scale, color, rotation, effects, layerDepth)
        {
            this.keys = keys;
        }

        public void Update()
        {
            if (Globals.keyboardState.IsKeyDown(Keys.Right))
            {
            }

            if (keys.IsLeft())
            {
                this.position -= Vector2.UnitX * 5;
            }
            else if (keys.IsRight())
            {
                this.position += Vector2.UnitX * 5;
            }
        }
    }
}
