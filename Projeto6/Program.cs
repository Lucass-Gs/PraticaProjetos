using System;

namespace Projeto6
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int MAIORAB =0;
            int MAIOR =0;
          
            if(a > b)
            {
            MAIORAB = a;
            }else
            {
            MAIORAB = b;
            }
            if(MAIORAB > c)
            {
            MAIOR = MAIORAB;
            }else
            {
              MAIOR=c;
            }
            Console.WriteLine($"{MAIOR} eh o maior");
        }
    }
}
