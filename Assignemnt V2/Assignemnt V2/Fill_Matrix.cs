﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_JM_BEEC3
{
    public class Fill_Matrix
    {
        private int viablecounter = 0;
        Cell[,] ResizeArray<Cell>(Cell[,] original, int rows, int cols)
        {
            var newArray = new Cell[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }
        public int Viablecounter
        {
            get { return viablecounter; }
            set { viablecounter = value; }
        }

    }
}