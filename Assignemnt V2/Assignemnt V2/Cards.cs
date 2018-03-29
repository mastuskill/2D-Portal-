using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_JM_BEEC3
{
    public class Cards
    {
        private int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private int location_number;
        public int Location_Number
        {
            get { return location_number; }
            set { location_number = value; }
        }

        private char typeC;
        public char TypeC
        {
            get { return typeC; }
            set { typeC = value; }
        }
        public Cards FillCards(int i,  Matrix[,] mymatrix, int y, int x)
        {
            Cards mycards = new Cards();

                    if (mymatrix[y, x].Type == 'X')
                    {
                        mycards.cost = 1000;
                        mycards.location_number = mymatrix[y, x].Location_N;
                        mycards.typeC = mymatrix[y, x].Type;
                    }
                    if (mymatrix[y, x].Type == 'O')
                    {
                        mycards.cost = 0;
                        mycards.location_number = mymatrix[y, x].Location_N;
                        mycards.typeC = mymatrix[y, x].Type;

                    }
                    if (mymatrix[y, x].Type == '.')
                    {
                        mycards.cost = 1000;
                        mycards.location_number = mymatrix[y, x].Location_N;
                        mycards.typeC = mymatrix[y, x].Type;
                    }
            return mycards;  
       }
    }
}