using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad3RLG
{
    public class Lista
    {
        Nodo Inicio;
        Nodo Final;

        public Lista() 
        {
            Inicio = Final = null;
        }

        public bool EstaVacia()
        {
            return Inicio == null? true: false;
        }


        public void InsertarFinal(string nombre, int edad)
        {
                Nodo actual = Final;
                
                while (actual == null)
                {
                    actual.Nombre = nombre;
                    actual.Edad = edad;
                    if(Final.Nombre ==null && Final.Edad == null
                    && Final.Anterior.Nombre != null && Final.Anterior.Edad != null)
                    {
                        Final.Nombre = actual.Nombre;
                        Final.Edad = actual.Edad;
                        Inicio.Nombre = Final.Nombre;
                        Inicio.Edad = Final.Edad;
                    }
                    else
                    {
                    
                      Final.Anterior.Nombre = actual.Nombre;
                      Final.Anterior.Edad = actual.Edad;
                      Inicio.Nombre = Final.Anterior.Nombre;
                      Inicio.Edad = Final.Anterior.Edad;
                      
                      actual.Nombre = actual.Anterior.Nombre;
                      actual.Edad = actual.Anterior.Edad;
                    }
                      

                
                }
        }

        public void BuscarNombrePosicion(string nombreBuscado)
        {
            bool centinela = false;
            int posicion = 0;
            if (EstaVacia())
            {
                Console.WriteLine("Esta vacia la lista");
            }
            else if (!EstaVacia())
            {
                Nodo actual = Inicio;
                while (actual != null)
                {
                    if (actual.Nombre == nombreBuscado)
                    {
                        posicion++;
                        Console.WriteLine($"El nombre {nombreBuscado} esta en la posicion{posicion}.");
                        centinela = true;
                    }
                    else
                    {
                        posicion++;
                        actual = actual.Siguiente;
                    }
                }
            }
            if(!centinela)
            {
                Console.WriteLine("El nombre no se encuentra en la lista");
            }
        }

        public void ImprimirElementosAscendente()
        {
            Nodo actual = Inicio;
            while (actual != null)
            {
                if (!EstaVacia())
                {
                    Console.WriteLine("NO hay elementos.");
                }
                else
                {
                    if(actual.Edad > actual.Siguiente.Edad)
                    {
                        Console.WriteLine($"Nombre: {actual.Nombre}  Edad: {actual.Edad}");
                        actual.Edad = actual.Siguiente.Edad;
                        actual.Nombre = actual.Siguiente.Nombre;
                    }
                }
            }
        }

    }
}
