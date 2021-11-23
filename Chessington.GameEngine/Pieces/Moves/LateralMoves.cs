using System.Collections;
using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces.Moves
{
    public static class LateralMoves
    {
        public static List<Square> AddMovesOverWholeBoard(int boardSize, Square currentPosition)
        {
            var availableMoves = new List<Square>();

            for (var i = 0; i < boardSize; i++)
            {
                availableMoves.Add(new Square(i,currentPosition.Col));
                availableMoves.Add(new Square(currentPosition.Row,i));
            }

            availableMoves.RemoveAll(m => m == currentPosition);
            
            return availableMoves;
        }
        
        public static List<Square> AddSingleStepMoves(Square currentPosition)
        {
            var availableMoves = new List<Square>();

            availableMoves.Add(Square.At(currentPosition.Row, currentPosition.Col + 1));
            availableMoves.Add(Square.At(currentPosition.Row, currentPosition.Col - 1));
            availableMoves.Add(Square.At(currentPosition.Row+1, currentPosition.Col));
            availableMoves.Add(Square.At(currentPosition.Row-1, currentPosition.Col));

            return availableMoves;
        }
        
    }
}