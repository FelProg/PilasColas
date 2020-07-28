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
                }

                if (ValidaVacio())
                {
                    colacir[frente] = dato;
                }
                else
                {
                    final++;
                    colacir[final] = dato;
                }

                Console.WriteLine($"el dato[{colacir[final]}], " +
                    $"esta en [{final}] en inicio [{frente}] esta [{colacir[frente]}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }



    }
}
