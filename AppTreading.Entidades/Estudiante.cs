using System;
using System.Globalization;

namespace AppTreading.Entidades
{
    public class Estudiante
    {
        //Propiedades
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        //Metodos
        public int CalcularFibonacci(bool valor)
        {

            int x = 1, y = 0;
            int resultado = 1;
            Console.Out.WriteLine($"Calculo Fibonacci : {1}");
            for (int contador = 0; contador < 25; contador++)
            {

                resultado = x + y;
                Console.Out.WriteLine($"Calculo Fibonacci : {resultado}");
                y = x;
                x = resultado;
            }
            
            return Convert.ToInt32(resultado);
        }
    }
}
