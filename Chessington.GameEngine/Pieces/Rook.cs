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
            const int boardSize = 8;
            
            var availableMoves = new List<Square>();
            var currentPosition = board.FindPiece(this);

            for (var i = 0; i < boardSize; i++)
            {
                availableMoves.Add(new Square(i,currentPosition.Col));
                availableMoves.Add(new Square(currentPosition.Row,i));
            }

            availableMoves.Remove(currentPosition);
            
            return availableMoves;
        }
    }
}