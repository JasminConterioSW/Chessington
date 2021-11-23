using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var availableMoves = new List<Square>();
            var currentPosition = board.FindPiece(this);
            
            availableMoves.AddRange(Moves.LateralMoves.AddSingleStepMoves(currentPosition));
            availableMoves.AddRange(Moves.DiagonalMoves.AddSingleStepMoves(currentPosition));
            
            availableMoves.RemoveAll(m => m == currentPosition);
            
            return availableMoves;
        }
    }
}