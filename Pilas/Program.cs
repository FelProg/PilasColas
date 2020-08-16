using System;
using System.Reflection.Metadata.Ecma335;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListasCirculares lista = new ListasCirculares();

            lista.AgregarNodo("primero");
            lista.AgregarNodo("segundo");
            lista.AgregarNodo("tercero");
            Console.WriteLine(lista.RecorrerLista());
            lista.AgregarAlInicio("cero");
            Console.WriteLine(lista.RecorrerLista());
            lista.AgregarNodo("cuarto");
            Console.WriteLine(lista.RecorrerLista());
            Nodo  respuesta = lista.Buscar("tercero");
            if(respuesta != null)
            {
                Console.WriteLine("Si se encontro");
            }
            else
            {
                Console.WriteLine("No se encontro");
            }
            Console.WriteLine($"el dato {lista.Eliminar("primero")} fue eliminado");
            Console.WriteLine(lista.RecorrerLista());
            Console.WriteLine($"el dato {lista.Eliminar("cero")} fue eliminado");
            Console.WriteLine(lista.RecorrerLista());
            lista.AgregarAlInicio("primero");
            lista.AgregarAlInicio("cero");
            Console.WriteLine(lista.RecorrerLista());
        }

        static void Pilas()
        {
            try
            {
                ArrayPilas pila = new ArrayPilas(5);

                pila.Agregar("Cero");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Uno");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Dos");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Tres");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("Cuatro");
                Console.WriteLine(pila.Imprimir());


                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Colas()
        {
            try
            {
                Colas colas = new Colas(5);

                Console.WriteLine(colas.Imprimir());
                colas.Agregar("Cero");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("Uno");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("Dos");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("Tres");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("Cuatro");
                Console.WriteLine(colas.Imprimir());


                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ColasCirculares()
        {
           
            ColasCirculares arreglo = new ColasCirculares(5);


            arreglo.Agregar("Uno");
            arreglo.Agregar("Dos");
            arreglo.Agregar("Tres");
            arreglo.Agregar("Cuatro");
            arreglo.Agregar("Cinco");
            arreglo.Agregar("truena");
                
            arreglo.Eliminar();
            arreglo.Eliminar();

            arreglo.Agregar("Seis");
            arreglo.Agregar("Siete");

            arreglo.Agregar("truena");
            

          

            
        }

        static void ColasDobles()
        {
            ColasDobles arreglo = new ColasDobles(8);

            //arreglo.AgregarPorDer("1");
            //arreglo.AgregarPorDer("1");
            //arreglo.AgregarPorDer("1");
            //arreglo.AgregarPorDer("1");
            //arreglo.AgregarPorDer("1");

            //arreglo.EliminarPorDer();
            //arreglo.EliminarPorDer();
            //arreglo.EliminarPorDer();
            //arreglo.EliminarPorDer();

            arreglo.AgregarPorIzq("1");
            arreglo.AgregarPorIzq("1");
            arreglo.AgregarPorIzq("1");
            arreglo.AgregarPorIzq("1");

            //arreglo.EliminarPorIzq();
            //arreglo.EliminarPorIzq();
            //arreglo.EliminarPorIzq();
            arreglo.AgregarPorDer("2");
            arreglo.AgregarPorDer("2");
            arreglo.AgregarPorDer("2");
            arreglo.AgregarPorDer("2");
            
          




        }
    }
    
}
