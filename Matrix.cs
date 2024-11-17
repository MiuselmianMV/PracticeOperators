using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOperators
{
    public class Matrix
    {
        private int Rows { get; set; }
        private int Columns { get; set; }
        private int[,] IntsMatrix { get; set; }


        public Matrix(int Rows, int Columns)
        {
            this.Rows = Rows;
            this.Columns = Columns;

            IntsMatrix = new int[Rows, Columns];
        }

        public void FillValues()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int w = 0; w < Columns; w++)
                {
                    IntsMatrix[i, w] = rnd.Next(0, 9);
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                Console.WriteLine();
                for (int w = 0; w < Columns; w++)
                {
                    Console.Write(IntsMatrix[i, w] + ", ");
                }
            }
        }

        public static Matrix operator + (Matrix left, Matrix right)
        {
            if (left.Columns != right.Columns || left.Rows!= right.Rows)
            {
                Console.WriteLine("Matrixes are different sized, so we added to the indexes of the smallest matrix");
            }
            for (int i = 0; i < Math.Min(left.Rows, right.Rows); i++)
            {
                for (int j = 0;  j < Math.Min(left.Columns, right.Columns); j++)
                {
                    left.IntsMatrix[i,j] += right.IntsMatrix[i,j]; 
                } 
            }
            return left;
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            if (left.Columns != right.Columns || left.Rows != right.Rows)
            {
                Console.WriteLine("Matrixes are different sized, so we added to the indexes of the smallest matrix");
            }
            for (int i = 0; i < Math.Min(left.Rows, right.Rows); i++)
            {
                for (int j = 0; j < Math.Min(left.Columns, right.Columns); j++)
                {
                    left.IntsMatrix[i, j] -= right.IntsMatrix[i, j];
                }
            }
            return left;
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left.Columns != right.Columns || left.Rows != right.Rows)
            {
                Console.WriteLine("Matrixes are different sized, so we added to the indexes of the smallest matrix");
            }
            for (int i = 0; i < Math.Min(left.Rows, right.Rows); i++)
            {
                for (int j = 0; j < Math.Min(left.Columns, right.Columns); j++)
                {
                    left.IntsMatrix[i, j] *= right.IntsMatrix[i, j];
                }
            }
            return left;
        }

        public static Matrix operator *(Matrix left,int number)
        {
            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < left.Columns; j++)
                {
                    left.IntsMatrix[i, j] *= number;
                }
            }
            return left;
        }

        public static bool operator == (Matrix left, Matrix right)
        {
            if (left.Rows == right.Rows && left.Columns == right.Columns) 
            {
                for (int i = 0; i < left.Rows; i++)
                {
                    for (int j = 0; j < left.Columns; j++)
                    {
                        if (left.IntsMatrix[i,j]!= right.IntsMatrix[i,j])
                            return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static bool operator != (Matrix left, Matrix right)
        {
            if (left.Rows == right.Rows && left.Columns == right.Columns)
            {
                for (int i = 0; i < left.Rows; i++)
                {
                    for (int j = 0; j < left.Columns; j++)
                    {
                        if (left.IntsMatrix[i, j] == right.IntsMatrix[i, j])
                            return false;
                    }
                }
                return true;
            }
            return true;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Matrix matrix)
            {
                return this == matrix;
            }
            return false;
        }
    }
}
