using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class CNodo
    {
        private int dato;

        private CNodo izq;
        private CNodo der;

        private string existo;

        public string Existo 
        { 
            get {return existo;} 
            set {existo = value;} 
        }

        public int Dato { get => dato; set => dato = value; }
        internal CNodo Izq { get => izq; set => izq = value; }
        internal CNodo Der { get => der; set => der = value; }

        public CNodo() // Constructor
        {
            dato = 0;
            izq = null;
            der = null;
            existo = "Si existe.";
        }
    }
}

