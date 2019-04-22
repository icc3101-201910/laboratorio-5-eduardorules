using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_eduardo_saldivia
{
    public class PerroFactorial : ICalcular
    {    
        public int Calcular(int numero)
        {
            int factorial(int number)
            {
                if (number == 1)
                    return 1;
                else
                    return number * factorial(number - 1);
            }
            return factorial(Convert.ToInt32(Math.Min(numero, 12)));
        }
    }
}
