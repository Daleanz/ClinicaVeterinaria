using System;
using Generadores;

namespace Clientes{
    class ClienteAEC : Persona{
        private string tipoEnfermedadCronica;
        private int tiempoCronico;
        private string direccionCAEC;
        private string correoElectronicoCAEC;

        public ClienteAEC(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tipoEnfermedadCronica, int tiempoCronico, string direccionCAEC, string correoElectronicoCAEC) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
           this.tipoEnfermedadCronica = tipoEnfermedadCronica;
           this.tiempoCronico = tiempoCronico;
           this.direccionCAEC = direccionCAEC;
           this.correoElectronicoCAEC = correoElectronicoCAEC;
        }

        public string TipoEnfermedadCronica{
            get{return tipoEnfermedadCronica;}
            set{this.tipoEnfermedadCronica = value;}
        }

        public int TiempoCronico{
            get{return tiempoCronico;}
            set{this.tiempoCronico = value;}
        }

        public string DireccionCAEC{
            get{return direccionCAEC;}
            set{this.direccionCAEC = value;}
        }

        public string CorreoElectronicoCAEC{
            get{return correoElectronicoCAEC;}
            set{this.correoElectronicoCAEC = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Cliente AEC:");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo: {CorreoElectronicoCAEC}\n"+
                    $"Direccion: {DireccionCAEC}\n"+
                    $"Tipo Enfermedad Animal: {TipoEnfermedadCronica}\n"+
                    $"Tiempo Cronico: {TiempoCronico}");
        }
    }
}
