using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_24_04
{
    class Node<T>
    {
        public int posicion;
        public Node<T> h_izq, h_der, padre;
        T objeto; 

        public Node(int posicion, Node<T> h_izq, Node<T> h_der, Node<T> padre, T objeto)
        {
            this.posicion = posicion;
            this.h_izq = h_izq;
            this.h_der = h_der;
            this.padre = null;
            this.objeto = objeto;

        }
    }
}
