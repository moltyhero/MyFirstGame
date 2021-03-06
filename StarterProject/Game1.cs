﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StarterProject
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D dragon;
        Texture2D background;
        float rot = 0;
        Vector2 pos;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            dragon = Content.Load<Texture2D>("dragon");
            background = Content.Load<Texture2D>("background");
            pos = new Vector2(300, 300);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            rot += 0.1f;
            pos.X += 10;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null,
                Matrix.CreateTranslation(-pos.X, -pos.Y, 0) *
                Matrix.CreateScale(1f) *
                Matrix.CreateRotationZ(0) *
                Matrix.CreateTranslation(0, 0, 0));
            spriteBatch.Draw(background, Vector2.Zero, null, Color.White, 0,
                 Vector2.Zero, new Vector2(10f, 10f), SpriteEffects.None, 0);
            spriteBatch.Draw(dragon, pos, null, Color.White, rot,
                new Vector2(500, 500), new Vector2(0.1f, 0.1f), SpriteEffects.None, 0);
            

            spriteBatch.End();
            base.Draw(gameTime);

        }
    }
}