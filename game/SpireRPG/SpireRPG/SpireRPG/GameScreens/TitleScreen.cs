using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using SpireRPGLibrary;

namespace SpireRPG.GameScreens
{
    public class TitleScreen : BaseGameState
    {
        #region Field Region
        Texture2D backgroundImage;
        public Rectangle tBackground;
        #endregion

        #region Constructor Region
        public TitleScreen(Game game, GameStateManager manager)
            : base(game, manager)
        {

        }
        #endregion

        #region XNA Method Region
        protected override void LoadContent()
        {
            ContentManager Content = GameRef.Content;
            backgroundImage = Content.Load<Texture2D>(@"Backgrounds\River");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            tBackground = new Rectangle(0,512,1024,256); 
            GameRef.spriteBatch.Begin();
            base.Draw(gameTime);
            GameRef.spriteBatch.Draw(backgroundImage,tBackground,Color.White);
            GameRef.spriteBatch.End();
        }
        #endregion
    }
}
