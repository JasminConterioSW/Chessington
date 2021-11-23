using System.Collections;
using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces.Moves
{
    public static class LateralMoves
    {
        public static List<Square> AddMoves(int boardSize, Square currentPosition)
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
    }
}