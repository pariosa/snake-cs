using System.Collections.Generic;
using System;

namespace Snake
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Position(int x, int y)  {
            X = x;
            Y = y;  
        }
        public Position Translate(CharacterMovement movement)
        {
            return new Position(X + movement.X, Y + movement.Y);
        }

        public override bool Equals(object obj){
            return obj is Position position &&
                   X == position.X &&
                   Y == position.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
    }
}