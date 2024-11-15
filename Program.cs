using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_VeterinariaRamosS.A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veterinaria vet = new Veterinaria();

            //int opcion;
            Menus.Presentacion();
            Console.ForegroundColor = ConsoleColor.Yellow; 
            /*
            do
            {
                Console.Clear();
                Console.WriteLine("");
                opcion = Menus.MenuPrincipal();
                
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Menus.Encabezado(" Agregando mascota");
                        vet.AgregarMascota();
                        break;

                    case 2:
                        Console.Clear();
                        vet.MostrarMascotas();
                        break;
                    case 3:
                        Console.Clear();
                        vet.EliminarMascotaPorCodigo();
                        break;
                    case 4:
                        Console.Clear();
                        vet.ModificarMascotaPorCodigo();
                        break;

                    case 5:
                        Console.Clear();
                        Menus.Encabezado(" Pasando a pila");
                        vet.BuscarMascotaPorCodigo();
                        break;

                    case 6:
                        Console.Clear();
                        vet.PasarColaAPila();
                        break;

                    case 7:
                        Console.Clear();
                        vet.insertarDatosPorDefecto();
                        break;

                    case 8:
                        Console.Clear();
                        vet.GenerarReporte();
                        break;

                    case 9:
                        Console.WriteLine("\n\t\t\t\t\t ¡Hasta luego!\n");
                        return; // Termina el programa

                    default:
                        Console.WriteLine("\n\t\t\t\t\t Opción no válida, intenta de nuevo.");
                        break;
                }

                if (opcion == 2 || opcion == 6 || opcion == 4 || opcion == 8 || opcion == 7) Console.Write("\n  Presione cualquier tecla para regresar...");
                else Console.Write("\n\t\t\t\t\t Presione cualquier tecla para regresar...");
                Console.ReadKey();
                Console.Clear();
            }
            while (opcion != 9);*/
        }
    }
}
