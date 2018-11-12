using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{

    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D matan4D;
        Texture2D back1;
        float rot = 0;
        Vector2 pos;
        Vector2 bgScale;
        Vector2 bgPos;
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            new SDFSD();
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            matan4D = Content.Load<Texture2D>("Dragon");
            back1 = Content.Load<Texture2D>("Background");
            //  pos = new Vector2(373*10,340*3);
            bgScale = new Vector2(10, 3);
            bgPos = new Vector2(0);
            pos = new Vector2(300*bgScale.X,300*bgScale.Y);
           

            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                pos.X -= 40;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                pos.X += 40;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                pos.Y -= 40;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                pos.Y += 40;
            }
            if (pos.X < (bgPos.X / 1024 * bgScale.X))
            {
                bgPos.X =-1024 * bgScale.X;
            }
            


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
          // spriteBatch.Begin();
          //  TODO: Add your drawing code here
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null,
                Matrix.CreateTranslation(-pos.X, -pos.Y, 0) *
                Matrix.CreateScale(0.5f) *
                Matrix.CreateRotationZ(0) *
                Matrix.CreateTranslation(400, 300, 0));
            spriteBatch.Draw(back1, bgPos, null, Color.White, 0,
                 Vector2.Zero, bgScale, SpriteEffects.None, 0);
            spriteBatch.Draw(back1, new Vector2(bgPos.X-1024*bgScale.X,bgPos.Y), null, Color.White, 0,
                 Vector2.Zero, bgScale, SpriteEffects.None, 0);
            spriteBatch.Draw(matan4D, pos, null, Color.White, rot,
                new Vector2(500, 500), new Vector2(0.1f, 0.1f), SpriteEffects.None, 0);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
