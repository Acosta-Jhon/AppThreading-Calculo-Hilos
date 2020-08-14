using AppTreading.Entidades;
using System;
using System.Threading;

namespace AppTreading.Consola
{
    class Program
    {
        private static bool valor = true; // = false - no ejecuta - Ejecucion de Hilos
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------CALCULO FIBONACCI-----------------------------");



            Estudiante estudiante = new Estudiante();
            Console.ForegroundColor = ConsoleColor.Green;
            estudiante.CalcularFibonacci(valor);


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------HILO e HILOS MULTIPLES-----------------------------");
            int numeroHilos = 0;

            //Crea multiples hilos
            for (numeroHilos = 0; numeroHilos < 5; numeroHilos++)
            {
                Thread primerHilo = new Thread(PrimerHilo);
                primerHilo.Start(numeroHilos);
            }
            //Primer Hilo
            int numero = 0;
            while (valor)
            {
                Console.ForegroundColor = ConsoleColor.Gray; // <= Color de Hilo
                Console.WriteLine("Accion realizada desde el Hilo 1 - numero : {0}", numero);
                numero++;

                if (numero == 15)
                    valor = false;
            }


        }
        // Hilo/multiple
        static void PrimerHilo(object entrada)
        {
            int incrementar = 0;
            while (valor)
            {
                Console.ForegroundColor = ConsoleColor.Blue; // Color de Hilo
                Console.WriteLine("Accion realizada desde el Hilo {0} con {1}", entrada, incrementar);
                incrementar++;
            }
        }

    }
}
