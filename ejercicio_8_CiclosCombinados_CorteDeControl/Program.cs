using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPaquete, canPaquetes, canPersonas, conPersonas = 0, precioPersonas, horas, conPrecio = 0, mayorImporte = 0, nuevoImporte = 0,  horasMenor = 0; //nuevaHMenor = 0;
            char aventura, aventuraActual, aventuraHora = 'a';
            Console.WriteLine("Dame la cantidad de personas son: ");
            canPersonas = int.Parse(Console.ReadLine());            
            Console.WriteLine("Dame el precio de cada persona: ");
            precioPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas horas estuvieron: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el tipo de aventura que usaste: ");
            aventura = char.Parse(Console.ReadLine());
            Console.WriteLine("Dame el numero de paquete: ");
            nPaquete = int.Parse(Console.ReadLine());
            conPrecio = precioPersonas * canPersonas;
            Console.WriteLine("EL total facturado de esta venta es de: " + conPrecio);
            Console.WriteLine("\n-------------------------------------------------\n      ---------- Ticket generado ----------\n-------------------------------------------------\n");
            conPersonas+=canPersonas;
            horasMenor = horas;
            if (conPrecio > mayorImporte)
                mayorImporte = conPrecio;
            aventuraHora = aventura;

            while (nPaquete != 0)
            {
                
                aventuraActual = aventura;
                canPaquetes = 0;
                while (aventura == aventuraActual && nPaquete != 0)
                {
                    
                    
                    conPrecio = 0;
                    canPaquetes++;
                    Console.WriteLine("Dame el numero de paquete: ");
                    nPaquete = int.Parse(Console.ReadLine());
                    if(nPaquete==0)
                        break;
                    Console.WriteLine("Dame la cantidad de personas son: ");
                    canPersonas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el precio de cada persona: ");
                    precioPersonas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cuantas horas estuvieron: ");
                    horas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el tipo de aventura que usaste: ");
                    aventura = char.Parse(Console.ReadLine());
                    conPrecio = precioPersonas * canPersonas;
                    Console.WriteLine("EL total facturado de esta venta es de: " + conPrecio);
                    Console.WriteLine("\n-------------------------------------------------\n      ---------- Ticket generado ----------\n-------------------------------------------------\n");
                    conPersonas+=canPersonas;
                    if(aventura != aventuraActual) 
                        nuevoImporte = mayorImporte;
                    if (conPrecio > mayorImporte)
                        mayorImporte = conPrecio;
                    
                    if(horas < horasMenor){
                        horasMenor = horas;
                        aventuraHora = aventura;
                    }

                    
                    

                }
                if(aventura == aventuraActual)
                    Console.WriteLine("La venta de mayor importe fue de: " + mayorImporte);
                else
                    Console.WriteLine("La venta de mayor importe fue de: " + nuevoImporte);
                mayorImporte = conPrecio;
                Console.WriteLine("Se vendieron " + canPaquetes + " de la aventura: " + aventuraActual+"\n");
                // nueva variable para guardar el mayor antes de que cambie
            }
            Console.WriteLine("La cantidad de personas que visitaron las aventuras fueron: " + conPersonas+"\n");
            Console.WriteLine("El tipo de aventura que tuvo menos horas fue " + aventuraHora + " y las horas fueron " + horasMenor);
        }
    }
}

// Una compañía de turismo aventura registró los paquetes vendidos durante la
// última temporada vacacional. Para cada venta se ingresó:
// • Número de paquete (4 dígitos no correlativos).
// • Cantidad de personas incluidas.
// • Precio por persona.
// • Horas totales de actividades.
// • Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.
// “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”,
// Parapente).
// El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con
// número de paquete cero. En el lote no se ingresan registros cuyo tipo de aventura
// no se haya vendido.
// a partir de dichos datos, se solicita informar:

// a. La cantidad de paquetes vendidos de cada tipo de aventura.. xxxxx

// b. La cantidad total de personas que disfrutaron de las aventuras durante la 
// temporada. xxxxx

// c. El total recaudado por cada venta. xxxx

// d. La venta con mayor importe de cada tipo de aventura. XXX

// e. El paquete con menos horas incurridlas y en qué tipo de actividad fue.