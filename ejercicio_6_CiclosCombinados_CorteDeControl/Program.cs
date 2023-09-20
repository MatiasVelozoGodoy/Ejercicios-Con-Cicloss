using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int zona, zonaActual = 1, nCliente, conCliente = 0;
            float kv = 0,  totalFacturado = 0;
            Console.WriteLine("Dame el numero de zona");
            zona = int.Parse(Console.ReadLine());

            while (zona != 0)
            {
                totalFacturado = 0;
                conCliente = 0;
                zonaActual = zona;

                while (zona == zonaActual)
                {
                    conCliente++;
                    Console.WriteLine("Dame el numero de cliente");
                    nCliente = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cuantos kv gasto?");
                    kv = float.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el numero de zona");
                    zona = int.Parse(Console.ReadLine());
                    totalFacturado += kv;
                }
            if(kv <= 100)
                totalFacturado *= 0.10F;
            else if(kv > 100 && kv <= 200)
                totalFacturado *= 0.12F;
            else
                totalFacturado *= 0.15F;

            Console.WriteLine("Zona: " + zonaActual);
            Console.WriteLine("Cantidad de usuarios de la zona " + zonaActual + ": "  + conCliente);
            Console.WriteLine("Total facturado en la zona " + zonaActual + ": " + totalFacturado.ToString(".00"));
            }
            
        }
    }
}


// 2. Una compañía de electricidad necesita calcular anualmente el consumo que ha
// registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
// Para ello tiene un lote de registros por cada uno de los usuarios con los
// siguientes datos:
// • Zona (numérico entero).
// • Número de cliente (número de cuatro dígitos no correlativos).
// • Cantidad de kilovatios consumidos en el periodo.
// El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro
// con zona igual a cero.
// Se pide generar un listado con el siguiente formato:

// Zona: XX
// Cantidad de usuarios de la zona: XX
// Total facturado en la zona: XX

// Zona: XX
// Cantidad de usuarios de la zona: XX
// Total facturado en la zona: XX

// El precio es escalonado según la siguiente escala:
// • $ 0.10 por kv por los primeros 100 kv de consumo.
// • $ 0.12 por kv por el consumo de 101 a 200 kvs.
// • $ 0.15 por kv por el consumo de 201 kvs en adelante.