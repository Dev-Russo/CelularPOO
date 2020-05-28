using System;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            celular samsung = new celular();
            samsung.cor = "Prata";
            samsung.modelo = "Galaxy 10";
            samsung.tamanho = 7;
            samsung.ligado = false;

            Console.WriteLine (samsung.modelo + " " +samsung.cor);

            Console.WriteLine (samsung.Ligar());

            Console.WriteLine (samsung.FazerLigacao());

            Console.WriteLine (samsung.EnviarMensagem());

            Console.WriteLine (samsung.Desligar());
        }
    }
}