using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class Page
    {
        public Texture2D Texture { get; set; }

        public List<int> blackip = new List<int>();
        public List<Vector2> originsList = new List<Vector2>();
        public List<Rectangle> rectangles = new List<Rectangle>();
        public Page(Characters name, States state)
        {
            this.Texture = Globals.contentManager.Load<Texture2D>(name.ToString() + 
                "/" + state.ToString());
            Color[] c = new Color[Texture.Width];
            Texture.GetData<Color>(0, 
                new Rectangle(0, Texture.Height-1, Texture.Width, 1),
                c, 0, Texture.Width);

            #region Black IP's

            for (int i = 0; i < Texture.Width; i++)
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
                    Texture.Height)); // CHECK WTF IS GOING ON
            }
            #endregion

            #region Rectangles
            for (int i = 0; i < blackip.Count - 2; i += 2)
            {
                rectangles.Add(new Rectangle(blackip[i], 0,
                    blackip[i + 2] - blackip[i],
                    Texture.Height - 1));
            }
            #endregion

            #region Clear Background Color
            c = new Color[Texture.Width * Texture.Height];
            
            Texture.GetData<Color>(c);

            Color trans = c[0];

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i]== trans)
                {
                    c[i] = Color.Transparent;
                }
            }
            Texture.SetData<Color>(c);

            #endregion

        }
    }
}
