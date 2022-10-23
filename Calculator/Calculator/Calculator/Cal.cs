using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Cal
    {

        private int so1 { get; set; }
        public int so2 { get; set; }
       
        public Cal(int x, int y)
        {
            so1 = x;
            so2 = y;
        }
        public int Cong()
        {
            return so1 + so2;
        }
        public int Execute(string z)
        {
            int result = 0;
            switch (z)
            {
                case "+":
                    result = so1 + so2;
                    break;
                case "-":
                    result = so1 - so2;
                    break;
                case "*":
                    result = so1 * this.so2;
                    break;
                case "/":
                    result = so1 / so2;
                    break;
                
            }
            return result;
        }
    }
}
