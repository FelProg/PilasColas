using System;
using System.Reflection.Metadata.Ecma335;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            ColasDobles();
            //ColasCirculares();
            //Colas();
            //Pilas();
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

            arreglo.Eliminar();

            arreglo.Agregar("Uno");
            arreglo.Eliminar();
            arreglo.Eliminar();
            arreglo.Agregar("Uno de nuevo");
            arreglo.Agregar("Dos");
            arreglo.Agregar("Tres");
            arreglo.Agregar("Cuatro");
            arreglo.Agregar("Cinco");
                
            arreglo.Eliminar();
            arreglo.Eliminar();

            arreglo.Agregar("Seis");
            arreglo.Agregar("Siete");
            arreglo.Agregar("truena");

            arreglo.Eliminar();
            arreglo.Agregar("Si se pudo");

            
        }

        static void ColasDobles()
        {
            ColasDobles arreglo = new ColasDobles(6);

            arreglo.AgregarPorDer("Uno");
            arreglo.AgregarPorDer("Dos");
            arreglo.AgregarPorIzq("Tres");
            arreglo.AgregarPorIzq("Cuatro");
            arreglo.AgregarPorIzq("Cinco");
            arreglo.AgregarPorIzq("Seis");
            arreglo.AgregarPorDer("Truena");
           
        }
    }
    
}
