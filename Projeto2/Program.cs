using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {

            double somaNotas = 0;
            int cont = 0;
            double media =0;      
    do {
      double notas = double.Parse(Console.ReadLine().Replace('.', ','));

      if(notas < 0 || notas > 10) {
        Console.WriteLine("nota invalida");
      } 
      else {
        cont++;
        somaNotas += notas; 
      }
      
    } 
    
    while (cont < 2);

    media = somaNotas / 2;
    
    Console.WriteLine("media = " + media.ToString().Replace(',', '.'));
            
        }

    }
}

