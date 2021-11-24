using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces.Moves
{
    public class PawnMoves
    {
        public static List<Square> AddMoves(Board board, Square currentPosition, Player player)
        {
            var availableMoves = new List<Square>();
            int boardSize = board.BoardSize;

            if (player == Player.White && board.GetPiece(new Square (currentPosition.Row - 1, currentPosition.Col))==null)
            {
                availableMoves.Add(new Square(currentPosition.Row - 1, currentPosition.Col));
                if (currentPosition.Row == boardSize-2 && board.GetPiece(new Square (currentPosition.Row - 2, currentPosition.Col))==null)
                {
                    availableMoves.Add(new Square(currentPosition.Row - 2, currentPosition.Col));
                }
            }
            else if (player == Player.Black && board.GetPiece(new Square (currentPosition.Row + 1, currentPosition.Col))==null)
            {
                availableMoves.Add(new Square(currentPosition.Row + 1, currentPosition.Col));
                if (currentPosition.Row == 1 && board.GetPiece(new Square (currentPosition.Row +2 , currentPosition.Col))==null)
                {
                    availableMoves.Add(new Square(currentPosition.Row + 2, currentPosition.Col));
                }
            }
            
            return availableMoves;
        }
    }
}