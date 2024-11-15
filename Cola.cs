using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_VeterinariaRamosS.A
{
    internal class Cola
    {
        public NodoMascota frente; //Nodo inicial (primer nodo que se ingresó)
        public NodoMascota final; //Nodo final (último nodo que se ingresó)

        //Constructor
        public Cola()
        {
            //"this" se usa para utilizar un atributo de la clase presente en otra función
            this.frente = null;
            this.final = null;
        }



    }
}
