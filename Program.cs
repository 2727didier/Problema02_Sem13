using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02_Sem13
{
    internal class Program
    {
            static int[] respuestasEncuesta = new int[100];
            static int cantidadRespuestas = 0;

            static void Main()
            {
                int opcion;

                do
                {
                    MostrarMenu();
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        ProcesarOpcion(opcion);
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }

                } while (opcion != 5);
            }

            static void MostrarMenu()
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Encuestas de Calidad");
                Console.WriteLine("===============================");
                Console.WriteLine("1: Realizar Encuesta");
                Console.WriteLine("2: Ver datos registrados");
                Console.WriteLine("3: Eliminar un dato");
                Console.WriteLine("4: Ordenar datos de menor a mayor");
                Console.WriteLine("5: Salir");
                Console.WriteLine("===============================");
            }

            static void ProcesarOpcion(int opcion)
            {
                switch (opcion)
                {
                    case 1:
                        RealizarEncuesta();
                        break;
                    case 2:
                        VerDatosRegistrados();
                        break;
                    case 3:
                        EliminarDato();
                        break;
                    case 4:
                        OrdenarDatos();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción del 1 al 5.");
                        break;
                }
            }

            static void RealizarEncuesta()
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Nivel de Satisfacción");
                Console.WriteLine("===============================");
                Console.WriteLine("¿Qué tan satisfecho está con la atención de nuestra tienda?");
                Console.WriteLine("1: Nada satisfecho");
                Console.WriteLine("2: No muy satisfecho");
                Console.WriteLine("3: Tolerable");
                Console.WriteLine("4: Satisfecho");
                Console.WriteLine("5: Muy satisfecho");
                Console.WriteLine("===============================");
                Console.Write("Ingrese una opción: ");

                if (int.TryParse(Console.ReadLine(), out int respuesta) && respuesta >= 1 && respuesta <= 5)
                {
                    respuestasEncuesta[cantidadRespuestas] = respuesta;
                    cantidadRespuestas++;
                    Console.WriteLine("\n¡Gracias por participar!\n");
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese una opción válida (1-5).");
                }
            }

            static void VerDatosRegistrados()
            {
                if (cantidadRespuestas == 0)
                {
                    Console.WriteLine("No hay datos registrados.");
                }
                else
                {
                    Console.WriteLine("Datos registrados:");
                    for (int i = 0; i < cantidadRespuestas; i++)
                    {
                        Console.WriteLine($"Encuesta {i + 1}: {respuestasEncuesta[i]}");
                    }
                }
            }

            static void EliminarDato()
            {
                if (cantidadRespuestas == 0)
                {
                    Console.WriteLine("No hay datos para eliminar.");
                }
                else
                {
                    Console.Write("Ingrese el número de encuesta a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int numeroEncuesta) && numeroEncuesta >= 1 && numeroEncuesta <= cantidadRespuestas)
                    {
                        EliminarEncuesta(numeroEncuesta);
                        Console.WriteLine("Encuesta eliminada con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Número de encuesta no válido. Intente nuevamente.");
                    }
                }
            }

            static void EliminarEncuesta(int numeroEncuesta)
            {
                for (int i = numeroEncuesta - 1; i < cantidadRespuestas - 1; i++)
                {
                    respuestasEncuesta[i] = respuestasEncuesta[i + 1];
                }
                cantidadRespuestas--;
            }

            static void OrdenarDatos()
            {
                if (cantidadRespuestas == 0)
                {
                    Console.WriteLine("No hay datos para ordenar.");
                }
                else
                {
                    Array.Sort(respuestasEncuesta, 0, cantidadRespuestas);
                    Console.WriteLine("Datos ordenados de menor a mayor.");
                }
            }
    }
}


