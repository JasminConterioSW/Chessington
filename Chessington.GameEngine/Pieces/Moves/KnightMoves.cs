using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces.Moves
{
    public class KnightMoves
    {
        public static List<Square> AddMoves(int boardSize, Square currentPosition)
        {
            var availableMoves = new List<Square>();

            availableMoves.Add(new Square(currentPosition.Row+1,currentPosition.Col+2));
            availableMoves.Add(new Square(currentPosition.Row+1,currentPosition.Col-2));
            availableMoves.Add(new Square(currentPosition.Row-1,currentPosition.Col+2));
            availableMoves.Add(new Square(currentPosition.Row-1,currentPosition.Col-2));
            availableMoves.Add(new Square(currentPosition.Row+2,currentPosition.Col+1));
            availableMoves.Add(new Square(currentPosition.Row+2,currentPosition.Col-1));
            availableMoves.Add(new Square(currentPosition.Row-2,currentPosition.Col+1));
            availableMoves.Add(new Square(currentPosition.Row-2,currentPosition.Col-1));

            
            return availableMoves;
        }
    }
}