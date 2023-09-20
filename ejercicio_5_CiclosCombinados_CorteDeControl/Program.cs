using System;

namespace ejercicio_5
{
    class Program
    {
        private const int V = 0;
        private const bool V1 = true;

        static void Main(string[] args)
        {
            // PUNTO A
            int n, porcentajeImpares, pTotalImpares = 0, nG = 0, con, maxPorcentaje = -1, min, grupoOrdenado = 0;
            //PUNTO B
            int numeroPrimo = 0, primo, ordenPrimos, conNumeroPrimo = 0;
            // PUNTO C
            bool banderaOrdenados;
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Dame un numero");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                porcentajeImpares = 0;
                con = 0;
                min = n;               
                banderaOrdenados = true;
                ordenPrimos = 0;
                conNumeroPrimo = 0;
                while (n != 0)
                {
                    // PUNTO A
                    con++;
                    numeroPrimo = 0;
                    primo =1;
                    
                    if (n % 2 != 0)
                    {
                        porcentajeImpares++;
                    }
                    // PUNTO B
                    while (primo <= n){
                        if(n % primo == 0)
                        {
                            numeroPrimo++;
                        }
                        primo++;
                    }
                    if(numeroPrimo == 2)
                    {
                        conNumeroPrimo++;
                        ordenPrimos = con;
                    }
                    // PUNTO C
                    if(n <= min)
                        min = n;
                    else
                        banderaOrdenados = false;

                    Console.WriteLine("Dame un numero");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                }

                pTotalImpares = porcentajeImpares*100/con;
                if (pTotalImpares > maxPorcentaje){
                    maxPorcentaje = pTotalImpares;
                    nG = i+1;
                }

                if(banderaOrdenados)
                    grupoOrdenado++;

                Console.WriteLine("--------------------------------------------------------------------------------------------");
                if(conNumeroPrimo != 0){
                    Console.WriteLine("Hay numeros primos y aparecio en el orden " + ordenPrimos);
                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                }
                
                else{
                    Console.WriteLine("NO hay numeros primos en el grupo");
                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                }

            
            }

            Console.WriteLine("el mayor numero de porcentaje de impares es " + maxPorcentaje + "% y esta en el grupo " + nG);
            if (grupoOrdenado == 0)
                Console.WriteLine("No hay grupos ordenados");
            else
                Console.WriteLine("Hay " + grupoOrdenado + " grupos ordenados");
        }
    }
}

// 1. Se dispone de una lista de 10 grupos de números enteros separados entre ellos por ceros. XX
// a. El número de grupo con mayor porcentaje de números impares positivos respecto al total de números que forman el grupo. XX
// b. Para cada grupo, el último número primo y en qué orden apareció en ese grupo. Si en un grupo no hubiera números primos, informarlo con un cartel aclaratorio.
// c. Informar cuántos grupos están formados por todos números ordenados de mayor a menor. XX