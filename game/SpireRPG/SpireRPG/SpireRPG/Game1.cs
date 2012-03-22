using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using SpireRPGLibrary;
using SpireRPG.GameScreens;

namespace SpireRPG
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        #region XNA Field Region
        GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        #endregion

        #region Game State Region
        GameStateManager stateManager;
        public TitleScreen TitleScreen;
        #endregion

        #region Screen Field Region
        const int screenWidth = 1024;
        const int screenHeight = 768;
        public readonly Rectangle ScreenRectangle;
        #endregion

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;

            ScreenRectangle = new Rectangle(0, 0, screenWidth, screenHeight);

            Content.RootDirectory = "Content";

            Components.Add(new InputHandler(this));
            stateManager = new GameStateManager(this);
            Components.Add(stateManager);

            TitleScreen = new TitleScreen(this, stateManager);
            stateManager.ChangeState(TitleScreen);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.FromNonPremultiplied(92, 148, 252, 255));
            base.Draw(gameTime);
        }
    }
}
