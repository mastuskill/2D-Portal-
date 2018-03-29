using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_JM_BEEC3
{
    public class Algortihim
    {
        private int flag_cake = 0;
        public int Flag_Cake
        {
            get { return flag_cake; }
            set { flag_cake = value; }

        }
        
        public Cards[] BubbleSort(Cards[] card, int i)
        {
            Cards temp = new Assignment_JM_BEEC3.Cards();

            for (int write = 0; write < i; write++)
            {
                for (int sort = 0; sort < i - 1; sort++)
                {
                    if (card[sort].Cost > card[sort + 1].Cost)
                    {
                        temp = card[sort + 1];
                        card[sort + 1] = card[sort];
                        card[sort] = temp;
                    }

                }
            }
            return card;
        }
         

        public Cards[] manipulation(Matrix[,] my_matrix, Cards[] my_cards, int ROW, int COLOUMN, int array_size,int case_n)
        {
            int l_number;
            int f = 0;
            int m = 0;
            
            l_number = my_cards[0].Location_Number;
            
                for (int y = 0; y < ROW; y++)
                {
                    for (int x = 0; x < COLOUMN; x++)
                    {
                    if (my_matrix[y, x].Location_N == l_number)
                    {
                        my_matrix[y, x].Visited = 1;
                        /////////////////////////////////////left////////////////////////////////
                        f = x - 1;
                        if (f >= 0)
                        {
                            if (my_matrix[y, f].Type != '#' && my_matrix[y, f].Visited != 1)      //left
                            {
                                if (my_matrix[y, f].Type == 'X' && my_cards[0].Cost < 1000)
                                {
                                    flag_cake = 1;
                                    my_cards[0].Cost++;
                                    Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                    return my_cards;
                                }
                                for (int i = 0; i < array_size; i++)
                                {
                                    if (my_cards[i].Location_Number == my_matrix[y, x - 1].Location_N && my_cards[i].Cost > my_cards[0].Cost + 1)
                                    {
                                        my_cards[i].Cost = my_cards[0].Cost + 1;
                                        break;
                                    }
                                }
                            }
                        }
                        m = x;
                        if (m + 1 == COLOUMN || my_matrix[y, m + 1].Type == '#')
                        {
                            while (my_matrix[y, m].Type != '#' && m != 0)
                            {
                                m--;
                            }
                            for (int i = 0; i < array_size; i++)
                            {
                                if (my_matrix[y, m].Type == 'X'&&my_cards[0].Cost < 1000)
                                {
                                    flag_cake = 1;
                                    my_cards[0].Cost++;
                                    Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                    return my_cards;
                                }
                                if (my_cards[i].Location_Number == my_matrix[y, m].Location_N && my_cards[i] != my_cards[0] && my_cards[i].Cost > my_cards[0].Cost + 1 )
                                {
                                    my_cards[i].Cost = my_cards[0].Cost + 1;
                                    break;
                                }
                            }
                        }
                            /////////////////////////////////////////////////right////////////////////////////
                            f = x + 1;
                            if (f < COLOUMN)
                            {
                                if (my_matrix[y, f].Type != '#' && my_matrix[y, f].Visited != 1)    //right
                                {
                                    if (my_matrix[y, f].Type == 'X' && my_cards[0].Cost < 1000)
                                    {
                                        flag_cake = 1;
                                        my_cards[0].Cost++;
                                        Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                        return my_cards;
                                    }
                                    for (int i = 0; i < array_size; i++)
                                    {
                                        if (my_cards[i].Location_Number == my_matrix[y, x + 1].Location_N && my_cards[i].Cost > my_cards[0].Cost + 1)
                                        {
                                            my_cards[i].Cost = my_cards[0].Cost + 1;
                                            break;
                                        }
                                    }
                                }
                            }
                            m = x;//// from here buddy
                                
                            if (m == 0)
                            {
                            while (m != COLOUMN && my_matrix[y, m].Type != '#')
                            {
                                m++;
                            }
                            for (int i = 0; i < array_size; i++)
                            {
                                if (my_matrix[y, m - 1].Type == 'X' && my_cards[0].Cost < 1000)
                                {
                                    flag_cake = 1;
                                    my_cards[0].Cost++;
                                    Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                    return my_cards;
                                }
                                if (my_cards[i].Location_Number == my_matrix[y, m - 1].Location_N && my_cards[i] != my_cards[0] && my_cards[i].Cost > my_cards[0].Cost + 1)
                                {
                                    my_cards[i].Cost = my_cards[0].Cost + 1;
                                    break;
                                }
                            }
                        }
                        m = x;
                        if (m != 0)
                        {
                            if (my_matrix[y, m - 1].Type == '#')
                            {
                                while (m != COLOUMN && my_matrix[y, m].Type != '#')
                                {
                                    m++;
                                }
                                for (int i = 0; i < array_size; i++)
                                {
                                    if (my_matrix[y, m - 1].Type == 'X' && my_cards[0].Cost < 1000)
                                    {
                                        flag_cake = 1;
                                        my_cards[0].Cost++;
                                        Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                        return my_cards;
                                    }
                                    if (my_cards[i].Location_Number == my_matrix[y, m - 1].Location_N && my_cards[i] != my_cards[0] && my_cards[i].Cost > my_cards[0].Cost + 1)
                                    {
                                        my_cards[i].Cost = my_cards[0].Cost + 1;
                                        break;
                                    }
                                }
                            }
                        }
      
                        
                        
                            //////////////////////////////////////////////////////////////////////down
                            f = y + 1;
                            if (f < ROW)
                            {
                                if (my_matrix[f, x].Type != '#' && my_matrix[f, x].Visited != 1) //down
                                {
                                    if (my_matrix[f,x].Type == 'X' && my_cards[0].Cost < 1000)
                                    {
                                        flag_cake = 1;
                                        my_cards[0].Cost++;
                                        Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                        return my_cards;
                                    }
                                    for (int i = 0; i < array_size; i++)
                                    {
                                        if (my_cards[i].Location_Number == my_matrix[y + 1, x].Location_N && my_cards[i].Cost > my_cards[0].Cost + 1)
                                        {
                                            my_cards[i].Cost = my_cards[0].Cost + 1;
                                            break;
                                        }
                                    }
                                }
                            }
                            m = y;
                            if (m == 0)
                        {
                            while (m != ROW && my_matrix[m, x].Type != '#')
                            {
                                m++;
                            }
                            for (int i = 0; i < array_size; i++)
                            {
                                if (my_matrix[m - 1, x].Type == 'X' && my_cards[0].Cost < 1000)
                                {
                                    flag_cake = 1;
                                    my_cards[0].Cost++;
                                    Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                    return my_cards;
                                }
                                if (my_cards[i].Location_Number == my_matrix[m - 1, x].Location_N && my_cards[i] != my_cards[0] && my_cards[i].Cost > my_cards[0].Cost + 1)//////
                                {
                                    my_cards[i].Cost = my_cards[0].Cost + 1;
                                    break;
                                }
                            }
                        }
                        m = y;
                        if (m != 0)
                        {
                            if (my_matrix[m - 1, x].Type == '#')
                            {
                                while (m != ROW && my_matrix[m, x].Type != '#')
                                {
                                    m++;
                                }
                                for (int i = 0; i < array_size; i++)
                                {
                                    if (my_matrix[m - 1, x].Type == 'X' && my_cards[0].Cost < 1000)
                                    {
                                        flag_cake = 1;
                                        my_cards[0].Cost++;
                                        Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                        return my_cards;
                                    }
                                    if (my_cards[i].Location_Number == my_matrix[m - 1, x].Location_N && my_cards[i] != my_cards[0] && my_cards[i].Cost > my_cards[0].Cost + 1)//////
                                    {
                                        my_cards[i].Cost = my_cards[0].Cost + 1;
                                        break;
                                    }
                                }
                            }
                        }
                        
                        
                        /////////////////////////////////////////////////////////////////////////////up
                        f = y - 1;
                            if (f >= 0)
                            {
                                if (my_matrix[f, x].Type != '#' && my_matrix[f, x].Visited != 1)  //up
                                {
                                    if (my_matrix[f, x].Type == 'X' && my_cards[0].Cost < 1000)
                                    {
                                        flag_cake = 1;
                                        my_cards[0].Cost++;
                                        Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                        return my_cards;
                                    }
                                    for (int i = 0; i < array_size; i++)
                                    {
                                        if (my_cards[i].Location_Number == my_matrix[y - 1, x].Location_N && my_cards[i].Cost > my_cards[0].Cost + 1)
                                        {
                                            my_cards[i].Cost = my_cards[0].Cost + 1;
                                            break;
                                        }
                                    }

                                }
                            }
                            m = y;
                        if (m + 1 == ROW || my_matrix[m+1, x].Type == '#')
                        {
                            while (my_matrix[m, x].Type != '#' && m != 0)
                            {
                                m--;
                            }
                            for (int i = 0; i < array_size; i++)
                            {
                                if (my_matrix[m, x].Type == 'X' && my_cards[0].Cost < 1000)
                                {
                                    flag_cake = 1;
                                    my_cards[0].Cost++;
                                    Console.WriteLine("Case #{0}: {1}", case_n + 1, my_cards[0].Cost);
                                    return my_cards;
                                }
                                if (my_cards[i].Location_Number == my_matrix[m, x].Location_N && my_cards[i] != my_cards[0] && my_cards[i].Cost > my_cards[0].Cost + 1 )
                                {
                                    my_cards[i].Cost = my_cards[0].Cost + 1;
                                    break;
                                }
                            }
                        }

                    }

                    
                    }
                }

                for (int i = 0; i < array_size - 1; i++)
                {
                    my_cards[i] = my_cards[i + 1];
                }

                Array.Resize<Cards>(ref my_cards, array_size - 1);

                
            return my_cards;
        }
    }
    }
