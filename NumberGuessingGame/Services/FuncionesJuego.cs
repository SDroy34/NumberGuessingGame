using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Services
{
    public class FuncionesJuego
    {
        protected int PedirNumUs(bool conver, int numUs)
        {
            bool band = true;
            int num = numUs;
            if (conver == false)
            {
                do
                {
                    MensajesJuego.MenNumErronio();
                    conver = int.TryParse(Console.ReadLine(), out num);
                    if (conver == true)
                    {
                        band = false;

                    }
                    else
                        band = true;
                } while (band);
            }
            return num;
        }

        protected static void BucleJuego(int intetos, int numRandom)
        {
            bool conver, band = true;
            int contador = 0, numUs;
            var fun = new FuncionesJuego();
            do
            {
                MensajesJuego.MensIngresarNum();
                conver = int.TryParse(Console.ReadLine(), out numUs);
                numUs = fun.PedirNumUs(conver, numUs);
                if (numUs == numRandom)
                {
                    band = false;
                    Console.WriteLine($"Felicidades encontraste el numero alaetorio {numRandom} en el intetno {contador}.");
                }
                else if (contador == intetos)
                {
                    band = false;
                    Console.WriteLine($"El numero aleatorio era {numRandom}");
                }
                contador++;
                band = true;


            }
            while (band);
        }
    }
}
