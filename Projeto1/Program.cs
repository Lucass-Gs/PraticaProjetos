using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaousuario;
        
            int alcool=0 ;
            int gasolina=0;
            int diesel=0;
    
                
            do
            {
                Console.WriteLine("digite para abastecer as opcoes: ");
                Console.WriteLine("1 - alcool ");
                Console.WriteLine("2 - gasolina ");
                Console.WriteLine("3 - Diesel ");
                Console.WriteLine("4 - sair ");
                
                opcaousuario = Convert.ToInt32(Console.ReadLine());                
                
                switch (opcaousuario)
                {
                    case 1:
                    alcool++ ;
                    continue;
                    
                    case 2:
                    gasolina++;
                    continue;
                      
                    case 3:
                    diesel++;                    
                    continue;

                    case 4:
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Alcool: "+alcool);
                    Console.WriteLine("Gasolina: "+gasolina);
                    Console.WriteLine("Diesel: "+diesel);
                    break;
                    
                    default:
                    if(opcaousuario < 1 && opcaousuario > 4)
                    {                    
                    throw new ArgumentOutOfRangeException("Digite uma opcao correto");                    
                    }
                    continue;
                    
                        
                        
                    
                }
            }
       
         while (opcaousuario !=4);
        }
    }
}
