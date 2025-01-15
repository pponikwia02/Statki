using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace statki
{
    internal class Board
    {
        char[,] a = new char[10, 10];
        public int x { get; set; }
        public int y { get; set; }

        public bool add(int x, int y)
        {
            if (a[x, y] == '-') { a[x, y] = 's'; return true; }
            else return false;

        }
        public void display_board(int x, int y)
        {

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    a[x, y] = '-';
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine(a[x, y]);
                }
            }
        }
    }

}