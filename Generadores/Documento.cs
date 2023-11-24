using System;
using Generadores;

namespace Generadores{
    abstract class Documento{
        private DateTime fechaDocumento;
        private string nombreClinica;
        private string direccionClinica;
        private string telefonoClinica;
        private string correoElectronicoClinica;

// Agregar numero de documento, hacer uso de alguna interface.

        public Documento(string nombreClinica, string direccionClinica, string telefonoClinica, string correoElectronicoClinica, int numeroDocumento){
            this.fechaDocumento = DateTime.Now;
            this.nombreClinica = nombreClinica;
            this.direccionClinica = direccionClinica;
            this.telefonoClinica = telefonoClinica;
            this.correoElectronicoClinica = correoElectronicoClinica;
        }

        public Documento(string nombreClinica, string direccionClinica, string telefonoClinica){
            this.nombreClinica = nombreClinica;
            this.direccionClinica = direccionClinica;
            this.telefonoClinica = telefonoClinica;
            this.fechaDocumento = DateTime.Now;
            this.correoElectronicoClinica = " ";
        }

        public DateTime FechaDocumento{
            get{return fechaDocumento;}
            set{this.fechaDocumento = value;}
        }

        public string NombreClinica{
            get{return nombreClinica;}
            set{this.nombreClinica = value;}
        }

        public string DireccionClinica{
            get{return direccionClinica;}
            set{this.direccionClinica = value;}
        }

        public string TelefonoClinica{
            get{return telefonoClinica;}
            set{this.telefonoClinica = value;}
        }

        public string CorreoElectronicoClinica{
            get{return correoElectronicoClinica;}
            set{this.correoElectronicoClinica = value;}
        }

        public abstract void MostrarInformacionDocumento();
    }
}
