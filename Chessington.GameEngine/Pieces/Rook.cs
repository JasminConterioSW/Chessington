using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var availableMoves = new List<Square>();
            var currentPosition = board.FindPiece(this);

            for (var i = 0; i < board.BoardSize; i++)
            {
                availableMoves.Add(new Square(i,currentPosition.Col));
                availableMoves.Add(new Square(currentPosition.Row,i));
            }

            availableMoves.Remove(currentPosition);
            
            return availableMoves;
        }
    }
}