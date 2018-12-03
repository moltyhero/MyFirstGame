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
        public Keys Left { get; private set; }
        public Keys Right { get; private set; }
        public Keys Up { get; private set; }
        public Keys Down { get; private set; }

        public UserKeys(Keys left, Keys right, Keys up, Keys down)
        {
            this.Left = left;
            this.Right = right;
            this.Up = up;
            this.Down = down;
        }

        

        public override bool IsDown()
        {
            return Globals.keyboardState.IsKeyDown(Down);
        }

        public override bool IsLeft()
        {
            return Globals.keyboardState.IsKeyDown(Left);
        }

        public override bool IsRight()
        {
            return Globals.keyboardState.IsKeyDown(Right);
        }

        public override bool IsUp()
        {
            return Globals.keyboardState.IsKeyDown(Up);
        }
    }

    class BotKeys : BaseKeys
    {
        public bool Left { get; private set; }
        public bool Right { get; private set; }
        public bool Up { get; private set; }
        public bool Down { get; private set; }

        public BotKeys(int s, bool left = true, bool right = false, bool up = false, bool down = false)
        {
            Left = left;
            Right = right;
            Up = up;
            Down = down;
        }

        public override bool IsLeft()
        {
            throw new NotImplementedException();
        }

        public override bool IsRight()
        {
            throw new NotImplementedException();
        }

        public override bool IsUp()
        {
            throw new NotImplementedException();
        }

        public override bool IsDown()
        {
            throw new NotImplementedException();
        }
    }
}
