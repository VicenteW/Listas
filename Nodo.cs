using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Nodo
    {

        public string Nombre;
        public int NoControl;

        public Nodo siguiente;
        //constructor de clase
        public Nodo(int NoControl, string Nombre)
        {
            this.NoControl = NoControl;
            this.Nombre = Nombre;
            this.siguiente = null;
        }   
    }
}
