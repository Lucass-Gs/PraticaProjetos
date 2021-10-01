using System;
using System.Linq;
using System.Globalization;

namespace Projeto3
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            string[] vet = Console.ReadLine().Split(' ');                     
            string[] decre = vet.OrderByDescending(x => x).ToArray();
                  
            string n1 = decre[0];
            string n2 = decre[1];
            string n3 = decre[2];

            double a = Double.Parse(n1);
            double b = Double.Parse(n2); 
            double c = Double.Parse(n3);                 
                                    
            if ( a >= (b + c) ){
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
                
            else if ( a*a == (b*b) + (c*c) ){
                Console.WriteLine("TRIANGULO RETANGULO");
            }
                
            else if ( a*a > (b*b) + (c*c) ){
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
                
            else if ( a*a < (b*b) + (c*c) )
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");}
                

            if ( a == b && a == c )
            {
                Console.WriteLine("TRIANGULO EQUILATERO");}
                
            
            if ( a != b && b==c || a != c && c==b || a==c && c!=b || a==b && b!=c )
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }                    
                      
          
              
            
        }
    }
}
