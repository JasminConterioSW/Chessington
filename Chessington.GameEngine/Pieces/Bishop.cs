using System;
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
            
            var currentPosition = board.FindPiece(this);
            
            var availableMoves = Moves.DiagonalMoves.AddMoves(board.BoardSize,currentPosition);
            

            availableMoves.RemoveAll(m => m == currentPosition);
            
            
            return availableMoves;
        }
    }
}