using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace BetterGameWithObj
{
    static class Globals
    {
        public static ContentManager contentManager;

        public static void Init(ContentManager cm)
        {
            Globals.contentManager = cm;
        }
    }
}
