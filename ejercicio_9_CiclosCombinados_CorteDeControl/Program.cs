using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nProvedor, nProvedorActual = 0, dia, mes, nProducto, cantidadComprada, cantidadCompradaMax, precioUnitario, monto, montoMax = 0, nProvedorMax = 0, acuA = 0, acuB = 0, acuC = 0, agosto = 0, agostoNP = 0, agostoMin = 0, acuCompras = 0, nproductoMax = 0, nProvedorActualMax = 0;
            char tipoFactura;
            Console.WriteLine("dame el numero del provedor");
            nProvedor = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el dia");
            dia = int.Parse(Console.ReadLine());
            while(dia < 1 || dia > 31){ 
                Console.WriteLine("dia, no existe, dame el dia");
                dia = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("dame el precio unitario");
            precioUnitario = int.Parse(Console.ReadLine());
            Console.WriteLine("dame la cantidad comprada");
            cantidadComprada = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el numero del producto");
            nProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el mes");
            mes = int.Parse(Console.ReadLine());
            while(mes < 1 || mes > 12){
                Console.WriteLine("mes no existe, dame el mes");
                mes = int.Parse(Console.ReadLine());
            }
            if(mes == 7)
                agosto++;
                agostoNP = nProducto;
                

            monto = precioUnitario*cantidadComprada;
            Console.WriteLine("dame el tipo de factura");
            tipoFactura = char.Parse(Console.ReadLine());
            if(tipoFactura == 'a')
                acuA+= monto;
            else if(tipoFactura == 'b')
                acuB+= monto;
            else if(tipoFactura == 'c')
                acuC+= monto;
            Console.WriteLine("---------------------------\nCompra realizada con exito!\n---------------------------");     
            agostoMin = monto;
            cantidadCompradaMax = cantidadComprada;
            
            

            while(nProvedor!=0)
            {
                acuCompras = 0;
                montoMax = 0;
                nProvedorActual = nProvedor;
                while (nProvedor == nProvedorActual && nProvedor != 0)
                {
                    acuCompras++;
                    if(cantidadComprada > cantidadCompradaMax){
                        cantidadCompradaMax = cantidadComprada;
                        nproductoMax = nProducto;
                        nProvedorActualMax = nProvedorActual;
                    }

                    if (monto < agostoMin){
                        agostoMin = monto;
                        agostoNP = nProducto;
                    }

                    if(monto > montoMax)
                    {
                        montoMax = monto;
                        nProvedorMax = nProvedorActual;
                    }
                    Console.WriteLine("dame el numero del provedor");
                    nProvedor = int.Parse(Console.ReadLine());
                    if(nProvedor == 0)
                        break;

                    Console.WriteLine("dame el dia");
                    dia = int.Parse(Console.ReadLine());
                    while(dia < 1 || dia > 31){ 
                        Console.WriteLine("dia, no existe, dame el dia");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("dame el precio unitario");
                    precioUnitario = int.Parse(Console.ReadLine());
                    Console.WriteLine("dame la cantidad comprada");
                    cantidadComprada = int.Parse(Console.ReadLine());
                    Console.WriteLine("dame el numero del producto");
                    nProducto = int.Parse(Console.ReadLine());
                    monto = cantidadComprada * precioUnitario;
                    Console.WriteLine("dame el mes");
                    mes = int.Parse(Console.ReadLine());
                    while(mes < 1 || mes > 12){
                        Console.WriteLine("mes no existe, dame el mes");
                        mes = int.Parse(Console.ReadLine());
                    }
                    if(mes == 7)
                        agosto++;
                    Console.WriteLine("dame el tipo de factura");
                    tipoFactura = char.Parse(Console.ReadLine());
                    if(tipoFactura == 'a')
                        acuA+= monto;
                    else if(tipoFactura == 'b')
                        acuB+= monto;
                    else if(tipoFactura == 'c')
                        acuC+= monto;
                    Console.WriteLine("---------------------------\nCompra realizada con exito!\n---------------------------");
                    
                }
                Console.WriteLine("El monto maximo registado en una sola compra por el proveedor " + nProvedorMax + " es de: " + montoMax);
                Console.WriteLine("La cantidad de compras que se le realizo al provedor " + nProvedorActual + " es de " + acuCompras);
            }
            Console.WriteLine("La inversion de la factura de Responsable inscripto es de: "+ acuA);
            Console.WriteLine("La inversion de la factura de Consumidor Final es de: "+ acuB);
            Console.WriteLine("La inversion de la factura de Monotributo es de: "+ acuC);
            if(agosto>0)
            Console.WriteLine("En el mes de agosto la compra minima fue de: " + agostoMin + " y el numero de producto es: " + agostoNP);
            else
                Console.WriteLine("En el mes de agosto no se vendio nada");
            Console.WriteLine("El numero de producto con mayor cantidad comprada es: " + nproductoMax + " y al provedor que se le compro es al: " + nProvedorActualMax);

        }
    }
}



// a. El monto máximo registrado en una sola compra por cada proveedor y el
// número de proveedor al que se le compró. XXXXXX

// b. La inversión total de todo el año discriminada por tipo de factura. XXXX

// c. La compra con menor monto registrada durante el mes de Agosto junto al
// número de producto comprado. XXXX

// d. La cantidad de compras que se realizaron a cada proveedor. XXXX

// e. El número de producto con mayor cantidad comprada en una sola compra y
// en qué proveedor se compró.