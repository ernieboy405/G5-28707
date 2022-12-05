using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class CArbolBB
    {
        private CNodo raiz;
        private CNodo trabajo; //variable de apoyo para el trabajo en las operaciones

        private int i = 0; //valor de interación

        public CArbolBB()
        {
            raiz = null;
        }
        internal CNodo Raiz { get => raiz; set => raiz = value; }

        //Insertar

        public CNodo Insertar(int pDato, CNodo pNodo) //Necesita del dato y el nodo al que se hará la inserción
        {
            CNodo temp = null;

            //Si no hay a quien insertar entonces creamos el nodo
            if (pNodo == null)
            {
                temp = new CNodo();
                temp.Dato = pDato;

                return temp;
            }

            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
            }

            if (pDato > pNodo.Dato)
            {
                pNodo.Der = Insertar(pDato, pNodo.Der);
            }

            return pNodo;
        } 

        //transversa (Generar el arbol)
        public void Transversa(CNodo pNodo)
        {
            if (pNodo==null)
                return;

            //Me proceso primero a mí
            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            //Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(pNodo.Izq);
                i--;
            }

            //Si tengo derecha, proceso a la derecha
            if (pNodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(pNodo.Der);
                i--;
            }

        }

        public CNodo Buscar(int pDato, CNodo pNodo)
        {

            CNodo temp = new()
            { 
                Existo = "No Existe."
            };

            if (pNodo == null)
                return temp;

            //verifico si soy el número
            if (pNodo.Dato == pDato)
                    return pNodo;

            //Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null && pDato < pNodo.Dato)
            {
                temp = Buscar(pDato, pNodo.Izq);
            }

            //Si tengo derecha, proceso a la derecha
            if (pNodo.Der != null && pDato > pNodo.Dato)
            {
                temp = Buscar(pDato, pNodo.Der);
            }

            return temp;
        }

        public CNodo BuscarPadre (int pDato, CNodo pNodo)
        {
            CNodo temp = null;

            if (pNodo == null)
                return null;

            //verifico si soy el padre
            if (pNodo.Izq != null)
                if (pNodo.Izq.Dato == pDato)
                    return pNodo;

            if (pNodo.Der != null)
                if (pNodo.Der.Dato == pDato)
                    return pNodo;

            //Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null && pDato < pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Izq);
            }

            //Si tengo derecha, proceso a la derecha
            if (pNodo.Der != null && pDato > pNodo.Der.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Der);
            }

            return temp;
        }

        
        public int EncuentraMinimo (CNodo pNodo)
        {
            if (pNodo == null)
                return 0;
            
            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return minimo;
        }

        public CNodo EncuentraNodoMinimo(CNodo pNodo)
        {
            if (pNodo == null)
                return null;

            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return trabajo;
        }

    }
    

}
