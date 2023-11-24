using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3RLG
{
    public class Nodo
    {
        private string _nombre;
        private int _edad;
        private Nodo _Siguiente;
        private Nodo _anterior;
        
        public Nodo() 
        {
            _nombre = null;
            _edad = 0;
            _Siguiente = null;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public Nodo Siguiente
        { 
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }
        public Nodo Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

    }
}
