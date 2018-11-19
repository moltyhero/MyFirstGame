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
            Color[] c = new Color[texture.Width];
            texture.GetData<Color>(0, 
                new Rectangle(0, texture.Height-1, texture.Width, 1),
                c, 0, texture.Width);

            List<int> blackip = new List<int>();
            for (int i = 0; i < texture.Width; i++)
            {
                if(c[i]==c[0])
                {
                    blackip.Add(i);
                }
            }
        }
    }
}
