using System;
using System.Collections.Generic;
using System.Linq;
namespace Singleton.Servicio
{
    public class Unico
    {
        private Unico() { }

        private static Unico _instancia;

        public static Unico ObtenerInstancia()
        {
            if(_instancia==null)
                _instancia = new Unico();
            return _instancia;
        }

        public static void RealizarLogica()
        {

        }
    }
}
