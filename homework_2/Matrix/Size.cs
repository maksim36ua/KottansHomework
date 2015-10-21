using System;

namespace Matrix
{
    public struct Size
    {
        public readonly int Height;
        public readonly int Width;
        public readonly bool IsSquare;

        public Size(int height, int width)
        {
            Height = height;
            Width = width;
            IsSquare = (height == width) ? true : false;
        }

        public static bool operator == (Size a, Size b)
        {
            return (a.Height == b.Height && a.Width == b.Width);
        }

        public static bool operator != (Size a, Size b)
        {
            return !(a.Height == b.Height && a.Width == b.Width);
        }

        public override bool Equals(object obj)
        {
            if (obj is Size)
            {
                return this == (Size)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

}