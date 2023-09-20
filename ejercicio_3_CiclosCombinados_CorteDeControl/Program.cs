using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acuI, con, pAcuI=0, mP=-1, gPm=0, gO=0, min;
            bool bandera;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dame un numero");
                n = int.Parse(Console.ReadLine());
                acuI=0;
                con=0;
                min = n;
                bandera = true;
                while (n !=0)
                {
                    con++;
                    if (n%2!=0)
                        acuI++;

                    if(min >= n)
                        min = n;
                    else
                        bandera = false;
                    Console.WriteLine("Dame un numero");
                    n = int.Parse(Console.ReadLine());
                }//Fin del while
                pAcuI=acuI*100/con;
                if (pAcuI > mP){
                    mP = pAcuI;
                    gPm = i+1;
                }
                if(bandera)
                    gO++;

            }//Fin del for
            Console.WriteLine("el mayor numero de porcentaje de impares es " + mP + "% y esta en el grupo " + gPm);
            if(gO==0)
                Console.WriteLine("no hay grupos ordenados");
            else
                Console.WriteLine("la cantidad de grupos ordenados son " + gO);
        }
    }
}



// 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar: 

// El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
// Informar cuántos grupos están formados por todos números ordenados de mayor a menor.