using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SpireRPGLibrary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace SpireRPG.GameScreens
{
    public abstract partial class BaseGameState : GameState
    {
        #region Fields Region
        protected Game1 GameRef;
        #endregion

        #region Properties Region
        #endregion

        #region Constructor Region
        public BaseGameState(Game game, GameStateManager manager)
            : base(game, manager)
        {
            GameRef = (Game1)game;
        }
        #endregion
    }
}
