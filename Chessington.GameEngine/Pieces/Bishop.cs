using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            const int boardSize = 8;
            
            var availableMoves = new List<Square>();
            var currentPosition = board.FindPiece(this);

            var i = currentPosition.Row;
            var j = currentPosition.Col;

            while (i < boardSize && j < boardSize)
            {
                availableMoves.Add(Square.At(i,j));
                i += 1;
                j += 1;
            }
            
            i = currentPosition.Row;
            j = currentPosition.Col;
            
            while (i >= 0 && j >= 0)
            {
                availableMoves.Add(Square.At(i,j));
                i -= 1;
                j -= 1;
            }
            
            i = currentPosition.Row;
            j = currentPosition.Col;
            
            while (i >= 0 && j < boardSize)
            {
                availableMoves.Add(Square.At(i,j));
                i -= 1;
                j += 1;
            }
            
            i = currentPosition.Row;
            j = currentPosition.Col;
            
            while (i <boardSize  && j>=0)
            {
                availableMoves.Add(Square.At(i,j));
                i += 1;
                j -= 1;
            }

            availableMoves.RemoveAll(m => m == currentPosition);
            
            return availableMoves;
        }
    }
}