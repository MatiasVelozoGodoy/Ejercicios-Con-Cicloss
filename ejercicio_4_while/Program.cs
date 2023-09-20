using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, me, ma;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            b = int.Parse(Console.ReadLine());
            if(a > b){
                ma = a;
                me = b;
            } else {
                ma = b;
                me = a;
            }
            Console.WriteLine();
            while(me < ma){
                Console.WriteLine(me);
                me++;
            }
        }
    }
}

// Hacer un programa que solicite dos números y luego muestre los números
// entre el menor y el mayor de ellos. Acordate, usando While.