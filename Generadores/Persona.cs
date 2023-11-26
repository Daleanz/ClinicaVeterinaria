using System;

namespace Generadores{
    abstract class Persona{
        private string nombrePersona;
        private string apellidoPersona;
        private string rutPersona;
        private string telefonoPersona;

        public Persona(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona){
            this.nombrePersona = nombrePersona;
            this.apellidoPersona = apellidoPersona;
            this.rutPersona = rutPersona;
            this.telefonoPersona = telefonoPersona;
        }

        public string NombrePersona{
            get{return nombrePersona;}
            set{this.nombrePersona = value;}
        }

        public string ApellidoPersona{
            get{return apellidoPersona;}
            set{this.apellidoPersona = value;}
        }

        public string RutPersona{
            get{return rutPersona;}
            set{this.rutPersona = value;}
        }

        public string TelefonoPersona{
            get{return telefonoPersona;}
            set{this.telefonoPersona = value;}
        }
        
        public abstract void MostrarInformacion();
    }
}
