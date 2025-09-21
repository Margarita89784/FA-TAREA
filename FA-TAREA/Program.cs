using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_TAREA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJER1: precio con descuento 
            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el código de descuento (1=estudiante, 2=empleado, 3=cliente frecuente): ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            double descuento = 0;

            // Determinar el descuento base
            if (codigo == 1)
            {
                descuento = 0.10;
            }
            else
            if (codigo == 2)
            {
                descuento = 0.15;
            }
            else

            if (codigo == 3)
            {
                descuento = 0.20;
            }
            else
            {
                Console.WriteLine("Código inválido. No se aplicará descuento.");
            }
            double precioDescuento = precio * (1 - descuento);

            // Aplicar descuento adicional si el precio es mayor a 500
            if (precio > 500)
            {
                precioDescuento *= 0.95;
            }
            Console.WriteLine($"Precio final: {precioDescuento:F2}");
            Console.WriteLine();


            // ejer2: evaluacion de la nota
            Console.WriteLine("EJERCICIO 2: Evaluación de nota");
            Console.Write("Ingrese la nota (0 a 20): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            // Validación de rango
            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("Nota fuera de rango. Ingrese un valor entre 0 y 20.");
            }
            else
            {
                // Clasificación con switch
                switch (nota)
                {
                    case int n when (n >= 0 && n <= 10):
                        Console.WriteLine("Desaprobado");
                        break;
                    case int n when (n >= 11 && n <= 13):
                        Console.WriteLine("Regular");
                        break;
                    case int n when (n >= 14 && n <= 17):
                        Console.WriteLine("Bueno");
                        break;
                    case int n when (n >= 18 && n <= 20):
                        Console.WriteLine("Excelente");
                        break;
                }

                // Condicionales adicionales
                if (nota >= 14 && nota % 2 == 0)
                {
                    Console.WriteLine("Buen desempeño con nota par");
                }

                if (nota % 2 != 0 || nota < 11)
                {
                    Console.WriteLine("Necesita reforzar");
                }

                // Cálculos matemáticos
                double raiz = Math.Sqrt(nota);
                double cubo = Math.Pow(nota, 3);

                Console.WriteLine("Raíz cuadrada: " + Math.Round(raiz, 1));
                Console.WriteLine("Potencia al cubo: " + cubo);

            }

            Console.ReadKey();





        }
    }
}
