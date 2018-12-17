using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    class Page
    {
        public int num = 5;
        public List<Texture2D> Textures = new List<Texture2D>(); 

        public List<Vector2> originsList = new List<Vector2>();
        public List<Rectangle> rectangles = new List<Rectangle>();
        public int originsNum = 5;

        public Page(Characters name, States state)
        {
            for (int i = 1; i < num; i++)
            {
                Textures.Add(Globals.contentManager.Load<Texture2D>(name.ToString() +
                "/" + state.ToString() + "/" + i));
            }

            #region Origins
            foreach (Texture2D texture in Textures)
            {
                originsList.Add(new Vector2(texture.Width / 2, texture.Height));
            }
            #endregion

            #region Rectangles
            foreach (Texture2D texture in Textures)
            {
                rectangles.Add(new Rectangle(0, 0, texture.Width, texture.Height));
            }
            #endregion

            #region Clear Background Color
            //c = new Color[Texture.Width * Texture.Height];
            
            //Texture.GetData<Color>(c);

            //Color trans = c[0];

            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (c[i]== trans)
            //    {
            //        c[i] = Color.Transparent;
            //    }
            //}
            //Texture.SetData<Color>(c);

            #endregion

        }
    }
}
