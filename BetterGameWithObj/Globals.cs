using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace BetterGameWithObj
{
    static class Globals
    {
        public static ContentManager contentManager;
        public static SpriteBatch spriteBatch;

        public static void Init(ContentManager cm, SpriteBatch sb)
        {
            Globals.contentManager = cm;
            Globals.spriteBatch = sb;
        }
    }
}
