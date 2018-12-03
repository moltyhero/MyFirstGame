using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    enum States
    {
        walk, jump
    }
    enum Characters
    {
        Wizard
    }

    static class Globals
    {
        public static ContentManager contentManager;
        public static SpriteBatch spriteBatch;
        public static KeyboardState keyboardState;

        public static void Init(ContentManager cm, SpriteBatch sb)
        {
            Globals.contentManager = cm;
            Globals.spriteBatch = sb;
        }

        public static void Update()
        {
            keyboardState = Keyboard.GetState();
        }
    }
}
