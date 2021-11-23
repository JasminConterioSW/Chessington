using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces.Moves
{
    public class PawnMoves
    {
        public static List<Square> AddMoves(int boardSize, Square currentPosition, Player player)
        {
            var availableMoves = new List<Square>();

            if (player == Player.White)
            {
                availableMoves.Add(new Square(currentPosition.Row - 1, currentPosition.Col));
                if (currentPosition.Row == boardSize-2)
                {
                    availableMoves.Add(new Square(currentPosition.Row - 2, currentPosition.Col));
                }
            }
            else if (player == Player.Black)
            {
                availableMoves.Add(new Square(currentPosition.Row + 1, currentPosition.Col));
                if (currentPosition.Row == 1)
                {
                    availableMoves.Add(new Square(currentPosition.Row + 2, currentPosition.Col));
                }
            }
            
            return availableMoves;
        }
    }
}