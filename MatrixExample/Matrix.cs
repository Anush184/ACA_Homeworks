using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixExample
{
    public class Matrix
    {
        private readonly int[,] _data;
        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Rows and columns must be greater than zero.");
            }

            Rows = rows;
            Columns = columns;
            _data = new int[Rows, Columns];
        }


        public int this[int row, int column]
        {
            get
            {
                CheckIndices(row, column);
                return _data[row, column];
            }
            set
            {
                CheckIndices(row, column);
                _data[row, column] = value;
            }
        }
        private void CheckIndices(int row, int column)
        {
            if (row < 0 || row >= Rows || column < 0 || column >= Columns)
            {
                throw new IndexOutOfRangeException("Invalid matrix indices.");
            }
        }

        public void ShowMatrixElements()
        {
            for(int i = 0; i < Rows; i++) 
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{_data[i,j]} ");
                }
                Console.WriteLine();
            }

           
        }

    }
    }
