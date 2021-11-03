using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Documento : Imprimible
    {
        private string _mensaje;
       public Documento()
        {
            _mensaje = "Soy un documento de word";
        }
        public void Imprimir()
        {
            Console.WriteLine(_mensaje);
        }
    }
}
