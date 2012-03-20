using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpireRPG.TileEngine
{
    class Engine
    {
        #region Field Region

        static int tileWidth;
        static int tileHeight;

        #endregion

        #region Property Region

        public static int TileWidth
        {
            get { return tileWidth; }

        }

        public static int TileHeight
        {
            get { return tileHeight; }
        }

        #endregion

        #region Constructors

        public static Point VectorToCell(Vector2 position)
        {
            return new Point((int)position.X / tileWidth, (int)position.Y / tileHeight);
        }

        #endregion

    }
}
