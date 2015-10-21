using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class CoolMatrix
    {
        public Size Size;
        public bool IsSquare;
        private readonly int[,] _matrix;

        public CoolMatrix(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException();
            Size = new Size(matrix.GetUpperBound(0) + 1, matrix.GetUpperBound(1) + 1);
            IsSquare = Size.IsSquare;
            this._matrix = matrix;

        }

        public int[,] GetMatrix()
        {
            return _matrix;
        }

        public static implicit operator CoolMatrix(int[,] matrix) // Implicit conversion operator
        {
            return new CoolMatrix(matrix);
        }

        public int this[int a, int b] //Indexer
        {
            get
            {
                if (a > Size.Height || b > Size.Width)
                    throw new IndexOutOfRangeException();
                return _matrix[a, b]; 
            }
            set { _matrix[a, b] = value; }
        }

        public static bool operator == (CoolMatrix a, CoolMatrix b)
        {
            if (a.Size != b.Size)
                return false;

            for(var i = 0; i < a.Size.Height; i++)
                for (var j = 0; j < a.Size.Width; j++)
                    if (a[i,j] != b[i,j])
                        return false;
            return true;
        }

        public static bool operator != (CoolMatrix a, CoolMatrix b)
        {
            bool isEqual = true;
            for (var i = 0; i < a.Size.Height; i++)
                for (var j = 0; j < a.Size.Width; j++)
                    if (a[i, j] != b[i, j])
                        isEqual = false;
            return !isEqual;
        }

        public static CoolMatrix operator * (CoolMatrix a, int number)
        {
            int[,] result = new int[a.Size.Height, a.Size.Width];

            for (int i = 0; i < a.Size.Height; i++)
                for (int j = 0; j < a.Size.Width; j++)
                    result[i, j] = a._matrix[i, j] * number;
            return new CoolMatrix(result);
        }

        public static CoolMatrix operator + (CoolMatrix a, CoolMatrix b)
        {
            if (a.Size != b.Size)
                throw new ArgumentException();

            int[,] result = new int[a.Size.Height, a.Size.Width];

            for (int i = 0; i < a.Size.Height; i++)
                for (int j = 0; j < a.Size.Width; j++)
                    result[i, j] = a._matrix[i, j] + b._matrix[i,j];

            return new CoolMatrix(result);
        }

        public override string ToString()
        {
            var rows = new string[Size.Height]; // Creating massive of rows

            for (int i = 0; i < Size.Height; i++)
            {
                var column = new int[Size.Width]; // Creating column
                for (int j = 0; j < Size.Width; j++)
                {
                    column[j] = _matrix[i, j];
                }
                rows[i] = $"[{String.Join(", ", column)}]";
            }
            return String.Join(Environment.NewLine, rows);
        }

        public CoolMatrix Transpose() 
        {
            var result = new CoolMatrix(new int[Size.Width, Size.Height]);

            for (var i = 0; i < Size.Height; i++)
            {
                for (var j = 0; j < Size.Width; j++)
                {
                    result._matrix[j, i] = this[i, j];
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is CoolMatrix)
            {
                return this == (CoolMatrix)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            CoolMatrix matrix = new [,]
            {
                { 1, 2 },
                { 3, 4 }
            };
            Console.WriteLine(matrix.ToString() + "\n");
            matrix = matrix.Transpose();
            Console.WriteLine(matrix.ToString());

            Console.Read();
        }
    }
}
