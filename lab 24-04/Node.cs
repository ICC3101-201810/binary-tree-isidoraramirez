using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_24_04
{
    public class Node<T>
    {
        public int posicion;
        public Node<T> h_izq, h_der, padre;
        public T objeto; 

        public Node(int posicion, Node<T> h_izq, Node<T> h_der, Node<T> padre, T objeto)
        {
            this.posicion = posicion;
            this.h_izq = null;
            this.h_der = null;
            this.padre = padre;
            this.objeto = objeto;
        }
        public void AgregarInfo(T objeto)
        {
            this.objeto = objeto;
        }

        public void AgregarHijo(Node<T> nodo )
        {
            Node<T> node = new Node<T>;

        }
    }
}
