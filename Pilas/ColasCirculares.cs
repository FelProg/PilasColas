using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas
{
    
    class ColasCirculares
    {
        private string[] colacir;
        private int max;
        private int frente;
        private int final;

        public ColasCirculares(int tamanio)
        {
            this.colacir = new string[tamanio];
            this.max = colacir.Length - 1;
            this.frente = 0;
            this.final = 0;
        }

        private bool ValidaVacio()
        {
            return (frente == final && colacir[frente]==null) ? true : false;
        }

        
        private bool ValidaLleno()
        {
            return ((final == max) && (frente == 0)) || ((final + 1) == frente) ? true : false;
        }

        public void Agregar(string dato)
        {
            try
            {
                if (ValidaLleno())
                {
                    throw new Exception("Arreglo lleno");
                }

                if (final == max)
                {
                    final = 0;
                    colacir[final] = dato;
                }
                else
                {
                    if (ValidaVacio())
                    {
                        colacir[frente] = dato;
                    }
                    else
                    {
                        final++;
                        colacir[final] = dato;
                    }

                }

                imprimir(dato, true);

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

        public void Eliminar()
        {
            try
            {
                if (ValidaVacio())
                    throw new Exception("La cola circular está vacía");

                string dato = colacir[frente];
                colacir[frente] = null;
               

                if (frente == final)
                {
                    frente = 0;
                    final = 0;
                    
                }
                else
                {
                    if (frente == max)
                    {
                        frente = 0;
                        
                    }
                    else
                    {
                       
                        frente++;
                    }
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

        private void imprimir(string dato, bool agregar = false, bool eliminar = false)
        {
            if (agregar)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n----------------------" +
                   $"\nAgregando [{dato}]" +
                   $"\n----------------------");
               
            }

            if (eliminar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n----------------------" +
                    $"\nEliminando {dato}" +
                    $"\n----------------------");
            }

            Console.ResetColor();


            Console.WriteLine($"frente[{frente}]=[{colacir[frente]}], " +
              $"final[{final}]=[{colacir[final]}]");

            foreach (string elem in colacir)
            {
                if (elem != null)
                {
                    if (elem == colacir[final] || elem == colacir[frente])
                   
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
        }
    }
}
