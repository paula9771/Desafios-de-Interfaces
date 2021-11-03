using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Foto : Imprimible
    {
        private string _mensaje;
        public Foto()
        {
            _mensaje = "Soy una selfie pal' insta";
        }
        public void Imprimir()
        {
            Console.WriteLine(_mensaje);
        }
    }
}
