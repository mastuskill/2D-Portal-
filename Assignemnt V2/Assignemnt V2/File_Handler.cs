using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_JM_BEEC3
{

    public class File_Handler
    {
        private int cases = 0, rows = 0, coulmns = 0, instance = 0;
        private string line;
        private List<String> list = new List<String>();
        private string[] data = new string[0];
        System.IO.StreamReader file = new System.IO.StreamReader(@"c:\\TestFolder\text.txt");

        public int NoOfCases()
        {
            cases = int.Parse(file.ReadLine());
            return cases;
        }

        public void Size(int casecounter)
        {
            line = file.ReadLine();
            rows = line[0] - 48;
            coulmns = line[2] - 48;
            instance++;
        }

        public void FillArray()
        {
            Array.Resize<string>(ref data, rows);

            for (int p = 0; p < rows; p++)
            {
                line = file.ReadLine();
                data[p] = line;
            }                    
        }

        public int ROW
        {
            get
            {
                return rows;
            }

            set
            {
                rows = value;
            }
        }

        public int COLOUMN 
        {
            get
            {
                return coulmns;
            }

            set
            {
                coulmns = value;
            }
        }
        public string[] DATA
        {
            get
            {
                return data;
            }
            set
            {
               data = value;
            }
        }
    }
}