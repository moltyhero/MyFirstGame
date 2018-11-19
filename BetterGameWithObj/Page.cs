using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class Page
    {
        Texture2D texture;

        public List<int> blackip = new List<int>();
        public List<Vector2> originsList = new List<Vector2>();
        public List<Rectangle> rectangles = new List<Rectangle>();
        public Page(Characters name, States state)
        {
            this.texture = Globals.contentManager.Load<Texture2D>(name.ToString() + "/" + state.ToString());
            Color[] c = new Color[texture.Width];
            texture.GetData<Color>(0, 
                new Rectangle(0, texture.Height-1, texture.Width, 1),
                c, 0, texture.Width);

            #region Black IP's

            for (int i = 0; i < texture.Width; i++)
            {
                if (c[i] == c[0])
                {
                    blackip.Add(i);
                }
            } 
            #endregion

            #region Origins
            for (int i = 2; i < blackip.Count; i+=2)
            {
                originsList.Add(new Vector2(blackip[i] - blackip[i - 1],
                    texture.Height)); // CHECK WTF IS GOING ON
            } 
            #endregion

            for (int i = 0; i < blackip.Count-2; i+=2)
            {
                rectangles.Add(new Rectangle(blackip[i], 0,
                    blackip[i + 2] - blackip[i],
                    texture.Height-1));
            }
            
        }
    }
}
