using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Consola
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
        static void NumNaturales()
        {
            //variable que contiene el numero que se está probando
            int n = 2;
            //variable que contiene el total de numeros primos encontrados
            int total = 1;
            //iterar mientras el total de numeros primos no se mayor a 10
            while (total <= 10)
            {

                //variable que indica si un numero es primo o no
                bool esPrimo = true;

                //se divide el numero (n) entre todos los numeros anterios a el
                //si el modulo de la division es 0 significa que el numero no es primo
                //y se marca la variable esPrimo = false y se termina el ciclo for
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                //si despues de ejecutar el ciclo for la variable esPrimo sigue
                //teniendo un valor true entonces se imprime el numero y se incrementa
                // el contador de numeros encontrados total++
                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                //se incrementa para evaluar el siguiente número
                n++;
            }

        }
        static double CelToFar(double temp)
        {
            var result = (9 * temp / 5) + 32;
            return result;
        }
        static double FarToCel(double temp)
        {
            var result = (5*(temp - 32))/9;
            return result;
        }
        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicacion de dos números");
                Console.WriteLine("[4] Division de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros numeros naturales");
                Console.WriteLine("[7] Cambia de celsius a fahrenheit");
                Console.WriteLine("[8] Cambia de fahrenheit a celsius");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        if(h == 0)
                        {
                            Console.WriteLine("No se puede dividir entre 0");
                        }
                        else
                        {
                            Console.WriteLine("La division de {0} y {1} es {2}", g, h, Division(g, h));
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        NumNaturales();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la temperatura en celsius");
                        double tempC = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} celsius a fahrenheit es {1}", tempC, CelToFar(tempC));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese la temperatura en fahrenheit");
                        double tempF = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} fahrenheit a celsius es {1}", tempF, FarToCel(tempF));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }

    }
}
