using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas
{
    class ColasDobles
    {
        //Como se hace esto germán????  hay que leer
        private string[] coladob;
        private int frente_izq;
        private int final_izq;
        private int frente_der;
        private int final_der;

        public ColasDobles(int tamanio)
        {
            this.coladob = new string[tamanio]; //{"uno", null , "uno", "uno", "uno" };
            this.frente_izq = 0;
            this.final_izq = 0;
            this.frente_der = coladob.Length - 1;
            this.final_der = coladob.Length - 1;
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

        private bool ValidaLleno()
        {
            //si al checar el siguiente dato por el lado derecho nos muestra
            //que hay un dato, significa que del otro lado la cola esta llena.
            return (coladob[final_izq + 1] != null) ? true : false;
        }

        public void AgregarPorIzq(string dato)
        {
            try
            {
                if (ValidaLleno())
                    throw new Exception("La cola doble esta llena");

                if (ValidaVacio() || (frente_izq == final_izq && coladob[frente_izq] == null))
                {
                    coladob[frente_izq] = dato;
                }
                else
                {
                    final_izq++;
                    coladob[final_izq] = dato;
                }

                imprimir(dato, false, true);

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
                    throw new Exception("La cola circular esta llena");

                if (ValidaVacio() || (frente_der == final_der && coladob[frente_der] == null))
                {
                    coladob[frente_der] = dato;
                }
                else
                {
                    final_der--;
                    coladob[final_der] = dato;
                }
                imprimir(dato, true, false);
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

        private void imprimir(string dato, bool derecha, bool izq)
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
            /*
            if (eliminar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n----------------------" +
                    $"\nEliminando {colacir[frente]}" +
                    $"\n----------------------");
            }*/

            Console.ResetColor();


            Console.WriteLine($"HEAD IZQ[{coladob[frente_izq]}] " +
              $"TAIL IZQ[{coladob[final_izq]}] " +
              $"\nHEAD DER[{coladob[frente_der]}] " +
              $"TAIL DER[{coladob[final_der]}]\n");

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
