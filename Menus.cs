﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_VeterinariaRamosS.A
{
    class Menus
    {
        //Menú de presentación de la empresa
        static public void Presentacion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Cambiamos el color de letra a celeste
            Console.WriteLine("\n\t\t\t\t=============================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t||                                                         ||");
            Console.WriteLine("\t\t\t\t||                                                         ||");
            Console.WriteLine("\t\t\t\t||                     ████      ████                      ||");
            Console.WriteLine("\t\t\t\t||                   ████████  ████████                    ||");
            Console.WriteLine("\t\t\t\t||                   ████████  ████████                    ||");
            Console.WriteLine("\t\t\t\t||                   ████████  ████████                    ||");
            Console.WriteLine("\t\t\t\t||             ████    ████      ████    ████              ||");
            Console.WriteLine("\t\t\t\t||           ████████                  ████████            ||");
            Console.WriteLine("\t\t\t\t||           ████████                  ████████            ||");
            Console.WriteLine("\t\t\t\t||           ████████      ██████      ████████            ||");
            Console.WriteLine("\t\t\t\t||             ████      ██████████      ████              ||");
            Console.WriteLine("\t\t\t\t||                     ██████████████                      ||");
            Console.WriteLine("\t\t\t\t||                   ██████████████████                    ||");
            Console.WriteLine("\t\t\t\t||                 ██████████████████████                  ||");
            Console.WriteLine("\t\t\t\t||                 ██████████████████████                  ||");
            Console.WriteLine("\t\t\t\t||                 ██████████████████████                  ||");
            Console.WriteLine("\t\t\t\t||                   ██████████████████                    ||");
            Console.WriteLine("\t\t\t\t||                     ██████  ██████                      ||");
            Console.WriteLine("\t\t\t\t||                                                         ||");
            Console.WriteLine("\t\t\t\t||                                                         ||");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t\t=============================================================");
            Console.WriteLine("\t\t\t\t|-                 VETERINARIA RAMOS S.A.                  -|");
            Console.WriteLine("\t\t\t\t=============================================================");
            Console.WriteLine("\n\t\t\t\t\t\t\t----------------");
            Console.WriteLine("\t\t\t\t\t\t\t  ¡Bienvenido!  ");
            Console.WriteLine("\t\t\t\t\t\t\t----------------");
            Console.Write("\t\t\t\t\t\t\t    Entrar...   ");
            Console.ReadKey();
            Console.Clear();
        }

        //Menú principal
        static public int MenuPrincipal()
        {
            int opcion = 0;
            bool flag = false;
            int contDeRecursividad = 0;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\t\t\t\t\t========= Menú Veterinaria =========");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t\t |1| Agregar Mascota a la cola");
            Console.WriteLine("\n\t\t\t\t\t |2| Insertar en la cola valores por defecto");
            Console.WriteLine("\n\t\t\t\t\t |3| Mostrar Mascotas de la cola");
            Console.WriteLine("\n\t\t\t\t\t |4| Generar árbol por código de mascota y mostrar árbol");
            Console.WriteLine("\n\t\t\t\t\t |5| Eliminar por código");
            Console.WriteLine("\n\t\t\t\t\t |5| Buscar mascota por código y actualizar");
            Console.WriteLine("\n\t\t\t\t\t |6| Recorrer el árbol en InOrder (menor a mayor)");
            Console.WriteLine("\n\t\t\t\t\t |7| Altura del árbol");
            Console.WriteLine("\n\t\t\t\t\t |8| Generar Reporte de Mascotas");
            Console.WriteLine("\n\t\t\t\t\t |9| Salir");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t\t\t\t====================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\t\t\t\t\tElija una opción: ");
            string opcion1 = Console.ReadLine();
            //Validamos si la opción es entera mandando "flag" como referencia para que se modifique dentro de la función
            //Validaciones.Entero(opcion1, ref flag);
            //Si no es, por recursividad volvemos al menú principal
            if (flag == false)
            {
                Console.WriteLine("\n\t\t\t\t\t¡Error! Ingrese un número entero...");
                Console.ReadKey();
                Console.Clear();
                opcion = MenuPrincipal();
                contDeRecursividad += 1;
            }
            //Si es la primera vez que se llama a la función, entonces se le agrega el
            //valor (que sería un entero ya que solo vuelve a llamar a la misma función cuando no es de este tipo de variable)
            if (contDeRecursividad == 0)
            {
                opcion = int.Parse(opcion1);
            }
            return opcion;
        }

        //Menú secundario
        static public void Encabezado(string encabezado)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t\t\t\t===========================================");
            Console.WriteLine($"\n\t\t\t\t\t {encabezado}...");
            Console.WriteLine("\n\t\t\t\t\t===========================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
