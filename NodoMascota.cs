using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_VeterinariaRamosS.A
{
    internal class NodoMascota
    {
        //Declaramos los atributos del nodo de la veterinaria
        public int CodigoMascota { get; set; } //"set" es para poder enviar el valor de la variable a otra clase y "get" es para poder colocarle valor a la variable desde otra clase
        public int CodigoCliente { get; set; }
        public string Cliente { get; set; }
        public string AliasMascota { get; set; }
        public int Peso { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }

        public NodoMascota siguiente; // Nodo siguiente para la pila o cola
        public NodoMascota izquierda; // Nodo siguiente para la pila o cola
        public NodoMascota derecha; // Nodo siguiente para la pila o cola
   


        //Constructor (para construir el objeto de tipo "NodoVet" con sus atributos)
        public NodoMascota(int codigoMascota, int codigoCliente, string cliente, string aliasMascota, int peso, int edad, string raza, string sexo)
        {
            CodigoMascota = codigoMascota;
            CodigoCliente = codigoCliente;
            Cliente = cliente;
            AliasMascota = aliasMascota;
            Peso = peso;
            Edad = edad;
            Raza = raza;
            Sexo = sexo;
        }
    }
}
