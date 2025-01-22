using NumberGuessingGame.Services;
using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var juegoView = new JuegoAzarLogica();
            juegoView.ViewGame();
        }
    }
}