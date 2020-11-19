using System;

namespace Programa_que_escreve_50_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que exiba todos os números inteiros de 0 a 50.
            for(int conta=0; conta<=50; conta++){
                Console.WriteLine(conta);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
