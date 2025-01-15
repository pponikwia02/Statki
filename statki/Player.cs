using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace statki
{
    internal interface Player
    {
        //statki 5:1d, 4:2d, 3:3d, 2:4d , 1:5d
       public void Postaw();
        public void Strzel();
        public bool Ready();
        public int WyborStatku(); // zwraca jak duzy ma byc statek. jak zwroci 1 to znaczy ze statek jest najmniejszy jak 5 to najwiekszy
        
         

    }
}
