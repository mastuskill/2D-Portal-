using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_JM_BEEC3
{

    class Program
    {

        static void Main(string[] args)
        {
            int casecounter = 0, p = 0, i =0;
            

            File_Handler text = new File_Handler();

            casecounter = text.NoOfCases();

            for (p = 0; p<casecounter; p++)
            {
                
                text.Size(casecounter);
                text.FillArray();
                Matrix dummy_M = new Matrix();
                Matrix[,] mymatrix = new Matrix[text.ROW,text.COLOUMN];
                int viablecounter = 0;
                i = 0;
                for (int y=0;y<text.ROW;y++)
                {
                    for (int x = 0; x < text.COLOUMN; x++)
                    {
                        mymatrix[y,x] = dummy_M.Fillmatrix(text.DATA,y,x);
                        if (mymatrix[y,x].Type == 'X' || mymatrix[y, x].Type == 'O' || mymatrix[y, x].Type == '.')
                        {
                            viablecounter++;
                        }

                    }
                }
                Cards dummy_C = new Cards();
                Cards[] mycards = new Cards[viablecounter];
                for (int y = 0; y < text.ROW; y++)
                {
                    for (int x = 0; x < text.COLOUMN; x++)

                    {
                        if (mymatrix[y, x].Type != '#')
                        {
                            mycards[i] = dummy_C.FillCards(i, mymatrix, y, x);
                            i++;
                        }
                    }
                }

                Algortihim alg = new Algortihim();
                mycards = alg.BubbleSort(mycards, i);
                for (int j = 0; j < viablecounter; j++)
                {
                    mycards = alg.manipulation(mymatrix, mycards, text.ROW, text.COLOUMN, i, p);
                    mycards = alg.BubbleSort(mycards, mycards.Length);
                    i--;
                    if(alg.Flag_Cake ==1 || i<2)
                    {
                        break;
                    }
                    
                    
                }
               if(alg.Flag_Cake != 1)
                {
                    Console.WriteLine("Case #{0}: CAKE IS A LIE", p + 1);
                }
                
            }
       }
    }
}
