using System;
using System.Collections.Generic;
using System.Text;

namespace Checkers
{
    public class Piece : IPiece
    {
        public virtual Status Status => throw new NotImplementedException();

        public virtual Color Color => throw new NotImplementedException();

        public virtual int Position => throw new NotImplementedException();

        public virtual IEnumerable<int> CapturingMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

        public virtual void Move(int destination)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<int> NormalMoves(IBoard board)
        {
            throw new NotImplementedException();
        }
    }

    public class King : Piece
    {
    }
}
