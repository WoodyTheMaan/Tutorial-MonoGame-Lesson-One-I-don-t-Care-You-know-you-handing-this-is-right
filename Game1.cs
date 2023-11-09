using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tutorial_MonoGame_Lesson_One_I_don_t_Care_You_know_you_handing_this_is_right
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D nameYourVariable, yourMother, background, Jedi;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 600;
            _graphics.PreferredBackBufferHeight = 400;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {

            _spriteBatch = new SpriteBatch(GraphicsDevice);
            nameYourVariable = Content.Load<Texture2D>("Helllo Speech");
            background = Content.Load<Texture2D>("image");
            yourMother = Content.Load<Texture2D>("500MovieClone-1 (1)");
            Jedi = Content.Load<Texture2D>("MasterJediSir");


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(background, new Vector2(0,0), Color.White);
            _spriteBatch.Draw(yourMother, new Vector2(40,30), Color.White);
            _spriteBatch.Draw(nameYourVariable, new Vector2(12, 10), Color.White);
            _spriteBatch.Draw(Jedi, new Vector2(200, 10), Color.White); 


            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}