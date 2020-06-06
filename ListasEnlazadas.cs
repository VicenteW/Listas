using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class ListasEnlazadas
    {
        private Nodo primero;
        private int size;
        public static string Nom;
        public static int Control;

        public ListasEnlazadas()
        {
            this.primero = null;
            this.size = 0;
        }

        public void agregarNodo(int NoControl, string Nombre)
        {
            Nodo nuevo = new Nodo(NoControl, Nombre);
            nuevo.siguiente = primero;
            primero = nuevo;
            size++;
        }
        public int Size()
        {
            return size;
        }
        public void Listar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.NoControl+" "+actual.Nombre);
                actual = actual.siguiente;
            }
        }
        //Verificar si la lista está vacia
        public void ListaVacia()
        {
            if(primero == null)
            {
                Console.WriteLine("La lista está vacia");
            }
            else
            {
                Console.WriteLine("La lista tiene datos");
            }
        }
        public void Ingresar()
        {
            Console.WriteLine("Ingrese el nombre del Alumno");
            Nom = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de control");
            Control = int.Parse(Console.ReadLine()); 
        }
        /*static void Main(string[] args)
        {
            ListasEnlazadas lista = new ListasEnlazadas();
            lista.ListaVacia();
            Console.WriteLine("¿Cuantos alumnos quiere ingresar?");
            int NoAlumnos = int.Parse(Console.ReadLine());
            for(int i=0; i<NoAlumnos; i++)
            {
                lista.Ingresar();
                
                lista.agregarNodo(Control, Nom);
            }
            lista.Listar();
            Console.WriteLine("tamaño " + lista.Size());
            lista.ListaVacia();
            Console.ReadKey();
        }*/
    }
}