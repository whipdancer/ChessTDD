﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    public struct BoardCoordinate
    {
        private readonly int _x;
        public int X { get { return _x; } }

        private readonly int _y;
        public int Y { get { return _y; } }

        public BoardCoordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public bool IsCoordinateValidForBoardSize(int boardSize)
        {
            return IsDimensionValidForBoardSize(X, boardSize) && IsDimensionValidForBoardSize(Y, boardSize);
        }

        public bool Matches(int x, int y)
        {
            return _x == x && _y == y;
        }

        private static bool IsDimensionValidForBoardSize(int dimensionValue, int boardSize)
        {
            return dimensionValue > 0 && dimensionValue <= boardSize;
        }
    }
}
