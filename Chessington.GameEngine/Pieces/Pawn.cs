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
            // ideally, would want to pass in GameSettings to get the board size instead of hardcoding, but it doesn't like that being static
            var availableMoves = new List<Square>();
            var currentPosition = board.FindPiece(this);


            if (Player == Player.White)
            {
                availableMoves.Add(new Square(currentPosition.Row - 1, currentPosition.Col));
                if (currentPosition.Row == board.BoardSize-2)
                {
                    availableMoves.Add(new Square(currentPosition.Row - 2, currentPosition.Col));
                }
            }
            else if (Player == Player.Black)
            {
                availableMoves.Add(new Square(currentPosition.Row + 1, currentPosition.Col));
                if (currentPosition.Row == 1)
                {
                    availableMoves.Add(new Square(currentPosition.Row + 2, currentPosition.Col));
                }
            }
            
            return availableMoves;
        }
    }
}