using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            
            var currentPosition = board.FindPiece(this);

            var availableMoves = Moves.PawnMoves.AddMoves(board,currentPosition,Player);
            
            
            return availableMoves;
        }
    }
}