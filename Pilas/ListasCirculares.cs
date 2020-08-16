using System;

namespace Pilas
{
    public class ListasCirculares
    {
        private Nodo nodoInicial; //me indica el primer nodo.
        private Nodo nodoActual; //es el nodo en donde se está posicionado.


        public ListasCirculares()
        {
            nodoInicial = new Nodo();
            nodoInicial.Enlace = nodoInicial;
        }

        public string RecorrerLista()
        {
            string datos = string.Empty;
            
            nodoActual = nodoInicial;
            
            while (nodoActual.Enlace.Dato != null)
            {
                nodoActual = nodoActual.Enlace;
                datos += $" {nodoActual.Dato} =>";

            }
            return "\n\t"+datos+" "+nodoInicial.Enlace.Dato+"\n";
        }

        public void VaciarLista()
        {
            nodoInicial.Enlace = nodoInicial;
        }

        public bool ValidaVacia()
        {

            return (nodoInicial.Enlace == nodoInicial);
        }

        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;

            //mientras que lo que tenga dato dentro de lo que esta apuntando 
            //el enlace sea diferente de null avanza al siguiente 
            while (nodoActual.Enlace.Dato != null)
            {
                nodoActual = nodoActual.Enlace;
            }


            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = dato;
            nuevoNodo.Enlace = nodoInicial;
            nodoActual.Enlace = nuevoNodo;
        }

        public void AgregarAlInicio(string dato)
        {
            Nodo nuevoNodo = new Nodo(); 
            nuevoNodo.Dato = dato;       
            nuevoNodo.Enlace = nodoInicial.Enlace;
            nodoInicial.Enlace = nuevoNodo;
        }

        public Nodo Buscar(string dato)
        {
            if (ValidaVacia())
            {
                return null;
            }

            Nodo nodoBusqueda = nodoInicial;

            while (nodoBusqueda.Enlace.Dato != null)
            {
                //nodoActual toma el valor del nodo que se encuentra
                //antes del nodo que tiene el valor que buscamos para
                //utilizar la propiedad enlace y dar continuidad a la 
                //lista.

                nodoActual = nodoBusqueda;
                nodoBusqueda = nodoBusqueda.Enlace;
                if (nodoBusqueda.Dato == dato)
                {
                    return nodoBusqueda;
                }
            }
            return null;
        }

        public string Eliminar(string dato)
        {
            Nodo borrarNodo = Buscar(dato);
            if (borrarNodo != null)
            {
                nodoActual.Enlace = borrarNodo.Enlace;
                return borrarNodo.Dato;
            }
            return null;
        }


    }
}


