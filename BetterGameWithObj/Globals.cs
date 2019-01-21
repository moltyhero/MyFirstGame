using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.IO;

namespace BetterGameWithObj
{
    public delegate void DlgUpdate();
    public delegate void DlgDraw();

    enum States
    {
        walk, idle
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
        public static Dictionary<Characters, Dictionary<States, Page>> dic;

        public static void Init(ContentManager cm)
        {
            Globals.contentManager = cm;
            // Globals.spriteBatch = sb;
            create_dic();
            Game1.event_update += Update;
        }

        public static void Update()
        {
            keyboardState = Keyboard.GetState();
        }

        public static void create_dic()
        {
            dic = new Dictionary<Characters, Dictionary<States, Page>>();
            foreach (Characters h in Enum.GetValues(typeof(Characters)))
            {
                Dictionary<States, Page> hdic = new Dictionary<States, Page>();
                foreach (States s in Enum.GetValues(typeof(States)))
                {
                    string path = Directory.GetCurrentDirectory() +
                          "/Content/" + h.ToString() + "/" + s.ToString() + ".xnb";

                    if (File.Exists(path))
                    {
                        Page p = new Page(h, s);
                        hdic.Add(s, p);
                    }
                }
                dic.Add(h, hdic);
            }

        }
    }
}
