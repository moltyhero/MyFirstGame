using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BetterGameWithObj
{
    abstract class BaseKeys
    {
        public abstract bool IsLeft();
        public abstract bool IsRight();
        public abstract bool IsUp();
        public abstract bool IsDown();
    }
    
    class UserKeys:BaseKeys
    {
        Keys left, right, up, down;

        public UserKeys(Keys left, Keys right, Keys up, Keys down)
        {
            this.left = left;
            this.right = right;
            this.up = up;
            this.down = down;
        }

        public override bool IsDown()
        {
            return Globals.keyboardState.IsKeyDown(down);
        }

        public override bool IsLeft()
        {
            return Globals.keyboardState.IsKeyDown(left);
        }

        public override bool IsRight()
        {
            return Globals.keyboardState.IsKeyDown(right);
        }

        public override bool IsUp()
        {
            return Globals.keyboardState.IsKeyDown(up);
        }
    }
}
