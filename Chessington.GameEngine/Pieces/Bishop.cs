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
            var availableMoves = new List<Square>();
            var currentPosition = board.FindPiece(this);

            // indices for iteration
            var i1 = currentPosition.Row;
            var i2 = currentPosition.Row;
            var j1 = currentPosition.Col;
            var j2 = currentPosition.Col;
            var j3 = currentPosition.Col;
            var j4 = currentPosition.Col;
            
            while (i1 < board.BoardSize || i2 >=0)
            {
                if (i1 < board.BoardSize)
                {
                    if (j1 < board.BoardSize)
                    {
                        availableMoves.Add(Square.At(i1,j1));
                        j1 += 1;
                    }
                    if (j2 >= 0)
                    {
                        availableMoves.Add(Square.At(i1,j2));
                        j2 -= 1;
                    }
                
                    i1 += 1;
                }
                
                if (i2 >= 0)
                {
                    if (j3 < board.BoardSize)
                    {
                        availableMoves.Add(Square.At(i2,j3));
                        j3 += 1;
                    }
                    if (j4 >= 0)
                    {
                        availableMoves.Add(Square.At(i2,j4));
                        j4 -= 1;
                    }
                
                    i2 -= 1;
                }
            }

            /*while (i < board.BoardSize && j < board.BoardSize)
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
            
            while (i >= 0 && j < board.BoardSize)
            {
                availableMoves.Add(Square.At(i,j));
                i -= 1;
                j += 1;
            }
            
            i = currentPosition.Row;
            j = currentPosition.Col;
            
            while (i <board.BoardSize  && j>=0)
            {
                availableMoves.Add(Square.At(i,j));
                i += 1;
                j -= 1;
            }*/

            availableMoves.RemoveAll(m => m == currentPosition);
            
            
            return availableMoves;
        }
    }
}