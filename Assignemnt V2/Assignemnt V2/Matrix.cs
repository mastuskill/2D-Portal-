using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_JM_BEEC3
{
    public class Matrix
    {
        private int location_n;
        public int Location_N
        {
            get { return location_n; }
            set { location_n = value; }
        }

        private int visited;
        public int Visited
        {
            get { return visited; }
            set { visited = value; }
        }


        private int counter;
        public int Counter
        {
            get { return counter; }
            set { counter = value; }

        }

        private int userlocation;
        public int UserLocation
        {
            get { return userlocation; }
            set { userlocation = value; }

        }

        private int cakelocation;
        public int CakeLocation
        {
            get { return cakelocation; }
            set { cakelocation = value; }

        }
        private char type;
        public char Type
        {
            get { return type; }
            set { type = value; }

        }

        public Matrix Fillmatrix (string[]data, int y, int x)
        {
            Matrix mylocation = new Matrix();
            mylocation.location_n = counter++;
            if (data[y][x] == 'O')
            {
                mylocation.type = 'O';
                userlocation = mylocation.location_n;
                mylocation.visited = 1;
            }

            if (data[y][x] == 'X')
            {
                mylocation.type = 'X';
                cakelocation = mylocation.location_n;
                mylocation.visited = 0;
            }
            if (data[y][x] == '.')
            {
                mylocation.type = '.';
                mylocation.visited = 0;
            }
            if (data[y][x] == '#')
            {
                mylocation.type = '#';
                mylocation.visited = 1;
            }
            return mylocation;
        }

      
    }
}