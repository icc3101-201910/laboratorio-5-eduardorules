using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_eduardo_saldivia
{
    public class Calculadora
    {
        int numero;
        List<ICalcular> calculadoras;


        public Calculadora(int numero)
        {
            this.numero = numero;
            Cuadrado cuadrado = new Cuadrado();
            Cubo cubo = new Cubo();
            PerroFactorial perroFactorial = new PerroFactorial();
            RobotFibonacci robotFibonacci = new RobotFibonacci();
            PersonaQueSuma5 personaQueSuma5 = new PersonaQueSuma5();
            calculadoras = new List<ICalcular> {cuadrado, cubo, perroFactorial, robotFibonacci, personaQueSuma5};
        }

        public void Calcular(int index)
        {
            numero = calculadoras[index].Calcular(numero);
        }

        public int GetNumero()
        {
            return numero;
        }
    }
}
