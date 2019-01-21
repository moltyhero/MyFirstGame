﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BetterGameWithObj
{
    class Engine
    {
        float maxForwardSpeed;
        float maxReverseSpeed;
        float accel;
        private float currentSpeed;
        public float CurrentSpeed { get => currentSpeed; private set => currentSpeed = value; }
        float friction;

        public Engine(float maxForwardSpeed, float maxReverseSpeed, float accelerate, float currentSpeed, float friction)
        {
            this.maxForwardSpeed = maxForwardSpeed;
            this.maxReverseSpeed = maxReverseSpeed;
            this.accel = accelerate;
            this.CurrentSpeed = currentSpeed;
            this.friction = friction;
            Game1.event_update += Update;
        }

        void Update()
        {
            currentSpeed *= friction;
        }

        public void Accelerate(bool forward)
        {
            if (forward)
            {
                CurrentSpeed += accel;
                if (CurrentSpeed > maxForwardSpeed)
                {
                    CurrentSpeed = maxForwardSpeed;
                }
            }
            else
            {
                CurrentSpeed -= accel;
                if (CurrentSpeed < maxReverseSpeed)
                {
                    CurrentSpeed = maxReverseSpeed;
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


        public Car(Vector2 origin, Texture2D tex, Vector2 position, Vector2 scale, Color color,
            float roadFriction, BaseKeys keys, Engine engine,
            float rotation = 0)
                : base(position, scale, color)
        {
            this.Origin = origin;
            this.Textures = new List<Texture2D>();
            this.Textures.Add(tex);
            this.velocity = Vector2.Zero;
            this.roadFriction = roadFriction;
            this.keys = keys;
            this.engine = engine;
            Game1.event_update += Update;
        }

        public void Update()
        {
            drot = 0;
            if (Math.Abs(engine.CurrentSpeed) > 1f)
            {
                if (keys.IsRight())
                {
                    drot += 0.035f * engine.CurrentSpeed < 0 ? -1 : 1;
                }

                if (keys.IsLeft())
                {
                    drot -= 0.035f * engine.CurrentSpeed < 0 ? -1 : 1;
                }
            }
            if (keys.IsUp())
            {
                engine.Accelerate(true);
            }
            else if (keys.IsDown())
            {
                engine.Accelerate(false);
            }

            rotation += drot;
            Vector2 direction = Globals.rotXVector(rotation);
            velocity = direction * engine.CurrentSpeed;
            Position += velocity;
            velocity *= roadFriction;

        }
    }
}
