using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var availableMoves = new List<Square>();
            var currentPosition = board.FindPiece(this);
            
            availableMoves.AddRange(Moves.LateralMoves.AddMovesOverWholeBoard(board.BoardSize,currentPosition));
            availableMoves.AddRange(Moves.DiagonalMoves.AddMovesOverWholeBoard(board.BoardSize,currentPosition));
            
            availableMoves.RemoveAll(m => m == currentPosition);
            
            return availableMoves;
        }
        

    }
}