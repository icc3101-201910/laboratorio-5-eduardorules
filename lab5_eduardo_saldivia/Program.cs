using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_eduardo_saldivia
{
    class Program
    {

        // en la clase robot fibonacci hay un comentario sobre que se supuso que es el fibonacci de un numero.
        static void Main(string[] args)
        {
            //parte 3
            /*
            
            Random random = new Random();
            //pedimos el numero sobre el cual operaar, el parametro que recibira el constructor de calculadora
            Console.WriteLine("Sobre que numero deseas operar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            //pedimos el numero de operaciones que se quiere realizar, sirve para contar las iteraciones
            Console.WriteLine("cuantas operaciones deseas realizar");
            int repeticiones = Convert.ToInt32(Console.ReadLine());
            //intanciamos la calculadora con numero como valor inicial
            Calculadora calculadora = new Calculadora(numero);

            for (; repeticiones > 0; repeticiones--)
            {
                int r = random.Next(0, 5);
                calculadora.Calcular(r);
                Console.WriteLine("resultado actual = {0}",calculadora.GetNumero());
            }
            Console.ReadKey();

            */

            //PARTE 4!!
            do
            {
                Console.Write("-----------------------------------------------------------------------------------------------------------------\n" +
                              "-----------------------------------------------------------------------------------------------------------------\n" +
                              "----------------------------SPOILER ALERT: AL FINAL DE LA BIBLIA TODOS MUEREN!!----------------------------------\n" +
                              "-----------------------------------------------------------------------------------------------------------------\n" +
                              "-----------------------------------------------------------------------------------------------------------------\n" +
                              "escriba el numero correspondiente a la operacion que desea realizar\n" +
                              "1 para Cuadrado\n" +
                              "2 para Cubo\n" +
                              "3 para PerroFactorial\n" +
                              "4 para RobotFibonacci\n" +
                              "5 para PersonaQueSuma5\n" +
                              "cualquier otro digito\n");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k != 1 && k != 2 && k != 3 && k != 4 && k != 5) break; 
                int index = k;
                Console.WriteLine("a que numero desea aplicarle dicha operacion: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Calculadora calculadora = new Calculadora(numero);
                calculadora.Calcular(index-1);
                Console.WriteLine("\n \n \n \nRESULTADO = {0} !!!", calculadora.GetNumero());
            } while (true);


        }
    }
}
