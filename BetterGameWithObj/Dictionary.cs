using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BetterGameWithObj
{
    static class Dictionary
    {
        public static Dictionary<Characters, Dictionary<States, Page>> dic = 
            new Dictionary<Characters, Dictionary<States, Page>>();

        public static void init()
        {
            foreach (Characters character in Enum.GetValues(typeof(Characters)))
            {
                Dictionary<States, Page> characterDict = new Dictionary<States, Page>();
                foreach (States state in Enum.GetValues(typeof(States)))
                {
                    string path = Directory.GetCurrentDirectory() + @"\Content\" + character.ToString() + @"\" + state.ToString() + @".xnb";

                    if (File.Exists(path))
                    {
                        Page p = new Page(character, state);
                        characterDict.Add(state, p);
                    }
                }
                dic.Add(character, characterDict);
            }
            
        }
    }
}
