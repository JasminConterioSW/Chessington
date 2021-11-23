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
            
            var availableMoves = new List<Square>();
            
            var currentPosition = board.FindPiece(this);


            if (Player == Player.White)
            {
                availableMoves.Add(new Square(currentPosition.Row - 1, currentPosition.Col));
            }
            else if (Player == Player.Black)
            {
                availableMoves.Add(new Square(currentPosition.Row + 1, currentPosition.Col));
            }
            
            return availableMoves;
        }
    }
}