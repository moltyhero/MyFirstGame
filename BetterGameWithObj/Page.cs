using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class Page
    {
        Texture2D texture;
        List<Rectangle> recList = new List<Rectangle>();
        List<Vector2> originsList = new List<Vector2>();
        public Page(string name, string mode)
        {
            this.texture = Globals.contentManager.Load<Texture2D>(name + "/" + mode);
        }
    }
}
