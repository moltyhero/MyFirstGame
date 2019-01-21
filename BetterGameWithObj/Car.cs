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
    class Engine
    {
        float maxForwardSpeed;
        float maxReverseSpeed;
        float accelerate;
        float currentSpeed;
        float friction;

        public Engine(float maxForwardSpeed, float maxReverseSpeed, float accelerate, float currentSpeed, float friction)
        {
            this.maxForwardSpeed = maxForwardSpeed;
            this.maxReverseSpeed = maxReverseSpeed;
            this.accelerate = accelerate;
            this.currentSpeed = currentSpeed;
            this.friction = friction;
        }
    }

    
    class Car
    {

    }
}
