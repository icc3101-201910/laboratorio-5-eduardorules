using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_eduardo_saldivia
{
    public class Cubo : ICalcular
    {
        public int Calcular(int numero)
        {
            return numero * numero * numero;
        }
    }
}
