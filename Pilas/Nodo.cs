namespace Pilas
{
    public class Nodo
    {
        /*declaro una string para tomar el dato que se va al nodo
         *declaro un tipo Nodo por que la variable se inicializa del ctor
         *
         *Enlace despues se actualiza con un parametro
         */

        private string dato;
        private Nodo enlace;
        public string Dato { get => dato; set => dato = value; }
        public Nodo Enlace { get => enlace; set => enlace = value; }

        //public Nodo()
        //{
        //    //aqui se inicializa en null por que es el último y no apunta a nada
        //    //pero en circulares debe de apuntar al primero.
        //    enlace = null;
            
        //}
    }
}
