using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Services
{
    public static class MensajesJuego
    {
        public static void Bienvenida()
        {
            Console.WriteLine("Bienvenido a el Number Guessing Game!");
            Console.WriteLine("tienes que encontrar un numero del 1 al 100.");
            Console.WriteLine("segun la dificultad vas a tener un numero de oportunidades");
        }
        public static void SelecionDif()
        {
            Console.WriteLine("Seleciona una dificultad");
            Console.WriteLine("1. Esay (10 oportunidades)");
            Console.WriteLine("2. Medium (5 oportunidades)");
            Console.WriteLine("3. Hard (3 oportunidades)");
        }
        public static void MensIngresarNum()
        {
            Console.Write("Ingresa un numero: ");
        }
        public static void MenNumErronio()
        {
            Console.Write("Ingresate un caracter invalido, ingresa de nuevo un numero: ");
        }
    }
}
