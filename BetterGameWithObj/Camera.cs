using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace BetterGameWithObj
{
    interface IFocus
    {
        Vector2 Position { get; }
    }

    class Camera
    {
        public Matrix mat { get; private set; }
        IFocus focus;
        Vector2 position;

        public Camera(IFocus focus)
        {
            this.position = Vector2.Zero;
            this.focus = focus;
            Game1.event_update += Update;
        }

        void Update()
        {
            mat = Matrix.CreateTranslation(-position.X, -position.Y, 0) *
                Matrix.CreateRotationZ(0) *
                Matrix.CreateScale(1) *
                Matrix.CreateTranslation(600, 300, 0);
            position = Vector2.Lerp(position, focus.Position, 0.1f);
        }
    }
}
