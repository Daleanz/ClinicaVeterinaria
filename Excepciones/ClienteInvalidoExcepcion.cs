using System;

namespace Excepciones{
    class ClienteInvalidoExcepcion : Exception{
        public ClienteInvalidoExcepcion(string mensaje) : base(mensaje){
        }
    }
}
