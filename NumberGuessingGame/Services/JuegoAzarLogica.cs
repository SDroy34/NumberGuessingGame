using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Services
{
    internal class JuegoAzarLogica
    {
        enum NivelIntentos
        {
            Easy = 10,
            Mediun = 5,
            Hard = 3
        }
        public void ViewGame()
        {
            Random rand = new Random();
            int numRand = rand.Next(1, 100);
            bool conver;
            int contador = 0;
            int opc;
            MensajesJuego.Bienvenida();
            MensajesJuego.SelecionDif();
            MensajesJuego.MensIngresarNum();
            conver = int.TryParse(Console.ReadLine(), out opc);
            opc = FuncionesJuego.PedirNumUs(conver, opc);

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Opcion 1");
                    FuncionesJuego.BucleJuego(((int)NivelIntentos.Easy), numRand);
                    break;
                case 2:
                    Console.WriteLine("Opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Opcion 3");
                    break;
                case 0:
                case 4:
                    Console.WriteLine("Fuera de rango.");
                    break;
                default:
                    break;
            }
        }
    }
}
