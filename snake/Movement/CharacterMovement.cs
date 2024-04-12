using System;
using System.Collections.Generic;

namespace Snake
{
    public class CharacterMovement
    {
        public readonly static CharacterMovement east = new CharacterMovement(1, 0);
        public readonly static CharacterMovement west = new CharacterMovement(-1, 0);
        public readonly static CharacterMovement north = new CharacterMovement(0, -1);
        public readonly static CharacterMovement south = new CharacterMovement(0, 1);

        public readonly static CharacterMovement northeast = new CharacterMovement(1, 1);
        public readonly static CharacterMovement southeast = new CharacterMovement(1, -1);
        public readonly static CharacterMovement northwest = new CharacterMovement(-1, -1);
        public readonly static CharacterMovement southwest = new CharacterMovement(-1, 1);

        public readonly static CharacterMovement right = new CharacterMovement(1, 0);
        public readonly static CharacterMovement left = new CharacterMovement(-1, 0);
        public readonly static CharacterMovement up = new CharacterMovement(0, -1);
        public readonly static CharacterMovement down = new CharacterMovement(0, 1);
        public int X { get; set; }
        public int Y { get; set; }
        private CharacterMovement(int x, int y)
        {
            X = x;
            Y = y;
        }
        public CharacterMovement Opposite()
        {
            return new CharacterMovement(-X, -Y);
        }
        public override bool Equals(object obj)
        {
            return obj is CharacterMovement position &&
                   X == position.X &&
                   Y == position.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
        public static bool operator ==(CharacterMovement left, CharacterMovement right)
        {
            return EqualityComparer<CharacterMovement>.Default.Equals(left, right);
        }

        public static bool operator !=(CharacterMovement left, CharacterMovement right)
        {
            return !(left == right);
        }
    }
}