﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace Chess.Acceptance
{
    [Binding]
    public class NormalBoardSetupScenarios
    {
        [When(@"there is a chess board set up as")]
        public void SetBoardInContextFromTable(Table table)
        {
            var builderGenerateBoard = BuildBoardFromTable(table);

            SetInContext(builderGenerateBoard);
        }

        [When(@"there is a move from \((.*),(.*)\) to \((.*),(.*)\)")]
        public void ThereIsAMoveFrom(int startX, int startY, int destinationX, int destinationY)
        {
            var board = GetFromContext<Board>();
            board.MovePiece(startX, startY, destinationX, destinationY);
        }
                
        [Then(@"the piece at \((.*),(.*)\) should have exactly the following moves")]
        public void ThenThePieceAtShouldHaveTheFollowingMoves(int xCoordinate, int yCoordinate, Table table)
        {
            var board = GetFromContext<Board>();
            var boardMoves = board.GetMovesFrom(xCoordinate, yCoordinate).ToList();

            var tableCoordinates = GetCoordinatesFromTable(table);

            Assert.IsTrue(DoCollectionsMatch(tableCoordinates, boardMoves));
        }

        private bool DoCollectionsMatch(IList<int[]> firstCollection, IList<int[]> secondCollection)
        {
            return !firstCollection.Any(pair => !secondCollection.Any(p => p[0] == pair[0] && p[1] == pair[1])) &&
                !secondCollection.Any(pair => !firstCollection.Any(p => p[0] == pair[0] && p[1] == pair[1]));
        }

        private Board BuildBoardFromTable(Table table)
        {
            var builder = new AsciiBoardBuilder();
            var indeces = Enumerable.Range(0, 8).ToList();
            indeces.ForEach(ri => indeces.ForEach(ci => AddNonEmptyPiece(builder, table, ri, ci)));
            var builderGenerateBoard = builder.GenerateBoard();
            return builderGenerateBoard;
        }

        private void AddNonEmptyPiece(AsciiBoardBuilder builder, Table table, int rowIndex, int columnIndex)
        {
            var xCoordinate = columnIndex + 1;
            var yCoordinate = 8 - rowIndex;
            var pieceString = table.Rows[rowIndex][columnIndex];

            if (!string.IsNullOrEmpty(pieceString))
                builder.AddPiece(xCoordinate, yCoordinate, pieceString);

        }


        private static T GetFromContext<T>()
        {
            return ScenarioContext.Current.Get<T>();
        }

        private static void SetInContext<T>(T data)
        {
            ScenarioContext.Current.Set<T>(data);
        }

        private static List<int[]> GetCoordinatesFromTable(Table tableOfBoardCoordinates)
        {
            return tableOfBoardCoordinates.Rows.Select(r => new int[] { int.Parse(r[0]), int.Parse(r[1]) }).ToList();
        }
        

    }
}
