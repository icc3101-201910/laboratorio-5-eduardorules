using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_eduardo_saldivia
{
    public class RobotFibonacci : ICalcular
    {
        // definimos el fibonacci de un numero como la posicion que representa en la serie
        // es decir, la serie comienza con sus numeros bases que no se cuentan 0 y 1
        // luego sigue 1, 2, 3, 5, 8, 13, 21, etc
        // entonces el fibonacci de 1 es igual a 1
        // f(2)= 2 ; f(5)= 8 ; f(7)= 21 y a si
        public int Calcular(int numero)
        {
            int NumeroAnterior = 0;
            int NumeroActual = 1;
            int limite = Convert.ToInt32(Math.Min(numero,46));
            for (int i = 0; i < limite; i++)
            {
                int auxiliar = NumeroAnterior;
                NumeroAnterior = NumeroActual;
                NumeroActual = auxiliar + NumeroAnterior;
            }
            return NumeroActual;
        }
    }
}
