using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas
{
    class ColasDobles
    {
        
        private string[] coladob;
        private int frente_izq;
        private int final_izq;
        private int frente_der;
        private int final_der;
        private int limite;
        

        public ColasDobles(int tamanio)
        {
            this.coladob = new string[tamanio]; 
            this.frente_izq = 0;
            this.final_izq = 0;
            this.frente_der = coladob.Length - 1;
            this.final_der = coladob.Length - 1;
            this.limite = tamanio/2;
            
        }

        private bool ValidaVacio()
        {
            //nos muestra que todos los indicadores estan en su posicion inicial
            //y que no hay datos en esas casillas.
            return (
                (frente_izq == final_izq && coladob[frente_izq] == null)
                &&
                (frente_der == final_der && coladob[frente_der] == null)
              ) ? true : false;
        }

        private bool ValidaLleno(bool izquierda=false, bool derecha=true)
        { 
            if (izquierda)
            {
                for (int i = 0; i < limite; i++)
                {
                    if (coladob[i] == null)
                        return false;
                }
            }
            else
            {
                int coladobLength = coladob.Length - 1;
                for (int i = coladobLength; i >= limite; i--)
                {
                    if (coladob[i] == null)
                        return false;
                }
            }

            return true;
        }

        public void AgregarPorIzq(string dato)
        {
            try
            {
                if (ValidaLleno(true))
                    throw new Exception("La cola doble esta llena por izquierda");

                if (ValidaVacio() || (frente_izq == final_izq && coladob[frente_izq] == null))
                {
                    coladob[final_izq] = dato;
                }
                else
                {
                    if(final_izq + 1 == limite )
                    {
                        final_izq = 0;
                    }
                    else
                    {
                        final_izq++;
                    }
                    coladob[final_izq] = dato;
                }

                imprimir(dato, false, true, false, false);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n----------------------" +
                   $"\n[{ex.Message}]" +
                   $"\n----------------------");
                Console.ResetColor();
            }
            
        }

        public void AgregarPorDer(string dato)
        {
            try
            {
                if (ValidaLleno())
                    throw new Exception("La cola doble esta llena por derecha");

                if (ValidaVacio() || (frente_der == final_der && coladob[frente_der] == null))
                {
                    coladob[final_der] = dato;
                }
                else
                {
                   
                    if (final_der == limite)
                    {
                        final_der = coladob.Length-1;
                    }
                    else
                    {
                        final_der--;
                    }
                    coladob[final_der] = dato;

                    

                }
                imprimir(dato, true, false, false, false);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n----------------------" +
                   $"\n[{ex.Message}]" +
                   $"\n----------------------");
                Console.ResetColor();
            }
            

        }

        public void EliminarPorIzq()
        {
            try
            {
                if (ValidaVacio() || (frente_izq == final_izq && coladob[frente_izq] == null))
                {
                    throw new Exception("Estructura vacía por izquierda");
                }

                //si hay datos lo elimina
                coladob[frente_izq] = null;

                //decide como mover el apuntador frente_izq
                if (frente_izq == final_izq)
                {
                    frente_izq = 0;
                    final_izq = 0;
                }
                else
                {
                    if (frente_izq + 1 == limite)
                    {
                        frente_izq = 0;
                    }
                    else
                    {
                        frente_izq++;
                    }
                }

                imprimir(null, false, false, true, false);
                

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n----------------------" +
                   $"\n[{ex.Message}]" +
                   $"\n----------------------");
                Console.ResetColor();
            }
           
        }

        public void EliminarPorDer()
        {
            try
            {
                if (ValidaVacio() || (frente_der == final_der && coladob[frente_der] == null))
                {
                    throw new Exception("Estructura vacía por derecha");
                }

                //si hay datos lo elimina
                coladob[frente_der] = null;

                //decide como mover el apuntador frente_izq
                if (frente_der == final_der)
                {
                    frente_der = coladob.Length-1;
                    final_der = coladob.Length-1;
                }
                else
                {
                    if (frente_der == limite)
                    {
                        frente_der = coladob.Length-1;
                    }
                    else
                    {
                        frente_der--;
                    }
                }

                imprimir(null, false, false, false, true);


            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n----------------------" +
                   $"\n[{ex.Message}]" +
                   $"\n----------------------");
                Console.ResetColor();
            }

        }

        private void imprimir(string dato, bool derecha, bool izq, bool eliminar_izq, bool eliminar_der)
        {
            if (derecha)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n----------------------" +
                   $"\nAgregando Derecha   [{dato}]" +
                   $"\n----------------------");
            }

            if (izq)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n----------------------" +
                   $"\nAgregando Izquierda   [{dato}]" +
                   $"\n----------------------");
            }
            
            if (eliminar_izq)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n----------------------" +
                    $"\nEliminando {coladob[frente_izq]}" +
                    $"\n----------------------");
            }

            if (eliminar_der)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n----------------------" +
                    $"\nEliminando {coladob[frente_der]}" +
                    $"\n----------------------");
            }

            Console.ResetColor();

            Console.WriteLine($"HEAD IZQ[{frente_izq}]  " +
                $"TAIL IZQ[{final_izq}]" +
                $"\nHEAD DER[{frente_der}]  " +
                $"TAIL DER[{final_der}]");

            //Console.WriteLine($"HEAD IZQ[{coladob[frente_izq]}] " +
            //  $"TAIL IZQ[{coladob[final_izq]}] " +
            //  $"\nHEAD DER[{coladob[frente_der]}] " +
            //  $"TAIL DER[{coladob[final_der]}]\n");

            foreach (string elem in coladob)
            {
                if(elem != null)
                {
                    if (elem == coladob[final_izq] || elem == coladob[frente_izq]
                   || elem == coladob[final_der] || elem == coladob[frente_der])
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"[{elem}] ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"[{elem}] ");
                    }
                }
                else
                {
                    Console.Write($"[{elem}] ");
                }
               
            }
            Console.WriteLine();
        }

    }
}
