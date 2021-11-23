using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentPosition = board.FindPiece(this);
            
            var availableMoves = Moves.KnightMoves.AddMoves(board.BoardSize,currentPosition);
            

            availableMoves.RemoveAll(m => m == currentPosition);
            
            
            return availableMoves;
        }
    }
}