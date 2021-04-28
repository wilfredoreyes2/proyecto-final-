using System;

namespace proyecto_final_relodel
{
    class Program
    {
        static void Main(string[] args)
        {
            //declacion de variables 
            float pago;
            float interesPagado;
            float capitalPagado;
            float valance;
            float tazaAnual;
            float tazaMensual;

            int fila, tiempo, i;
            //peticiones de datos 
            Console.Write("Introduce el monto del prestamo: ");
            float.TryParse(Console.ReadLine(), out valance );
            Console.Write("Introduce la tasa de interes anual: ");
            float.TryParse(Console.ReadLine(), out tazaAnual);
            Console.Write("Introduce el tiempo en meses: ");
            int.TryParse(Console.ReadLine(), out tiempo);

            //Calculo del interes mensual
            tazaMensual = (tazaAnual / 100) / 12;


            //Calculo de la cuota mensual
            pago = tazaMensual + 1;
            pago = (float)Math.Pow(pago, tiempo);
            pago = pago - 1;
            pago = tazaMensual / pago;
            pago = tazaMensual + pago;
            pago = valance  * pago;



            //inprecion de filas 
            Console.WriteLine();
            fila = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Numero de pago \t");
            Console.Write("Pago \t\t");
            Console.Write("Intereses Pagados \t\t");
            Console.Write("Capital Pagado \t\t");
            Console.Write("Monto del prestamo \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", valance );

              //bucle de calculo e imprecion
            for (i = 1; i <= tiempo; i++)
            {


                Console.Write("\t{0}\t\t", fila);


                Console.Write("{0}\t", pago);


                interesPagado = tazaMensual * valance ;
                Console.Write("{0}\t\t", interesPagado);


                capitalPagado = pago - interesPagado;
                Console.Write("\t{0}\t", capitalPagado);


                valance  = valance  - capitalPagado;
                Console.Write("\t{0}\t", valance );

                fila = fila + 1;
                Console.WriteLine();

            }
            Console.ReadLine();



        }
    }
}
