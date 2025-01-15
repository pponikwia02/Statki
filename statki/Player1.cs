using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statki
{//Gracz 1 nie będący AI
    internal class Player1 : Player
    {
        private int stat1 = 5;
        private int stat2 = 4;
        private int stat3 = 3;
        private int stat4 = 2;
        private int stat5 = 1;
        Player1(Board board)
        {
            player1_Board = board;
        }

        private Board player1_Board;
       // private Board player2_Board;
        public void Postaw()
        {
            int wybrany = WyborStatku();
            Console.WriteLine("Podaj współrzędne x i y");
            while (true)
            {
                int x; int y;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                if (x < 0 || y < 0 )// x > player1_Board.x || y > player1_Board.y)
                {
                     
                    Console.WriteLine("Podano niepoprawne wsp!");
                }
                else
                {

                   /* if (!player1_Board.Add(x, y))
                    {
                        Console.WriteLine("W tych wsp. już znajduje sie statek! ");
                        break;

                        
                    }
                   */

                }
            }
           
            
        }
        public void Strzel()
        {

        }
        public bool Ready()
        {
            bool flag = false;
            if (stat1 == 0 && stat2 == 0 && stat3 == 0 && stat4 == 0 && stat5 == 0) flag = true;
            return flag ;
        }

        public int WyborStatku()
        {
            while(true)
            {
                int[] avaiable = new int[5];
                avaiable[0] = stat1;
                avaiable[1] = stat2;
                avaiable[2] = stat3;
                avaiable[3] = stat4;
                avaiable[4] = stat5;
                while (true)
                {
                    Console.WriteLine("Podaj nr. statku który chcesz wybrać. Numer statku odpowiada wielkości zajmowanego przezń miejsca");
                    if (avaiable[0] != 0)
                        Console.WriteLine("nr.1 Statek 1");
                    if (avaiable[1] != 0)
                        Console.WriteLine("nr.2 Statek 2");
                    if (avaiable[2] != 0)
                        Console.WriteLine("nr.3 Statek 3");
                    if (avaiable[3] != 0)
                        Console.WriteLine("nr.4 Statek 4");
                    if (avaiable[4] != 0)
                        Console.WriteLine("nr.5 Statek 5");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (avaiable[0] <= 0)
                                continue;
                            else avaiable[0]--;
                            break;
                        case 2:
                            if (avaiable[1] <= 0)
                                continue;
                            else avaiable[1]--;
                            break;
                        case 3:
                            if (avaiable[2] <= 0)
                                continue;
                            else avaiable[2]--;
                            break;
                        case 4:
                            if (avaiable[3] <= 0)
                                continue;
                            else avaiable[3]--;
                            break;
                        case 5:
                            if (avaiable[4] <= 0)
                                continue;
                            else avaiable[4]--;
                            break;
                        default: Console.WriteLine("Podaj liczbę z zakresu 1-5"); break;

                    }
                    return choice;
                }
            }

        }
    }
}
