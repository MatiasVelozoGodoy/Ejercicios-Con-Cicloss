using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n, con, maxP = 0;
            bool primo = true;
            for(int x = 0; x < 4; x++){
                Console.WriteLine("dame un numero");
                n = int.Parse(Console.ReadLine());
                con = 0;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    con++;
                }

                if(con == 0)
                    if(!primo){
                    maxP = n;
                    primo = true;
                } else if(n > maxP){
                    maxP = n;
                }
                
                }
                if(!primo)
                Console.WriteLine("no hay primos");
                else 
                Console.WriteLine("el numero primo mas grande es "+ maxP);
                
            

        }
    }
}

// Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
// de los primos de la lista. En caso de no haber ningún número primo, deberá
// aclararlo con un cartel.