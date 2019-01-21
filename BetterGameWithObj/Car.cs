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
        float accel;
        float currentSpeed;
        float friction;

        public Engine(float maxForwardSpeed, float maxReverseSpeed, float accelerate, float currentSpeed, float friction)
        {
            this.maxForwardSpeed = maxForwardSpeed;
            this.maxReverseSpeed = maxReverseSpeed;
            this.accel = accelerate;
            this.currentSpeed = currentSpeed;
            this.friction = friction;
        }

        public void accelerate(bool forward)
        {
            if (forward)
            {
                currentSpeed += accel;
                if (currentSpeed > maxForwardSpeed)
                {
                    currentSpeed = maxForwardSpeed;
                }
            }
            else
            {
                currentSpeed -= accel;
                if (currentSpeed < maxReverseSpeed)
                {
                    currentSpeed = maxReverseSpeed;
                }
            }

        }
    }

    
    class Car : Drawer
    {
        float drot;
        Vector2 velocity;
        float roadFriction;
        BaseKeys keys;
        Engine engine;


        public Car(Texture2D tex, Vector2 position, Vector2 scale, Color color,
            float roadFriction, BaseKeys keys, Engine engine,
            float rotation = 0)
                : base(position, scale, color)
        {
            this.Textures = new List<Texture2D>();
            this.Textures.Add(tex);
            this.velocity = Vector2.Zero;
            this.roadFriction = roadFriction;
            this.keys = keys;
            this.engine = engine;
        }
    }
}
