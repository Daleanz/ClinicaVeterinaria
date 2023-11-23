using System;
using Generadores;

namespace Clientes{
    class ClienteAnimalEnfermoCronico : Persona{
        private string tipoEnfermedadCronica;
        private int tiempoCronico;
        private string direccionClienteAEC;
        private string correoElectronicoClienteAEC;

        public ClienteAnimalEnfermoCronico(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tipoEnfermedadCronica, int tiempoCronico, string direccionClienteAEC, string  correoElectronicoClienteAEC) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tipoEnfermedadCronica = tipoEnfermedadCronica;
            this.tiempoCronico = tiempoCronico;
            this.correoElectronicoClienteAEC = correoElectronicoClienteAEC;
            this.direccionClienteAEC = direccionClienteAEC;
        }

        public string TipoEnfermedadCronica{
            get{return tipoEnfermedadCronica;}
            set{this.tipoEnfermedadCronica = value;}
        }

        public int TiempoCronico{
            get{return tiempoCronico;}
            set{this.tiempoCronico = value;}
        }

        public string DireccionClienteAEC{
            get{return direccionClienteAEC;}
            set{this.direccionClienteAEC = value;}
        }

        public string CorreoElectronicoClienteAEC{
            get{return correoElectronicoClienteAEC;}
            set{this.correoElectronicoClienteAEC = value;}
        }
     
        public override void MostrarInformacion(){
            System.Console.WriteLine("Información del Cliente Regular");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                   $"Apellido: {base.ApellidoPersona}\n"+
                   $"Rut: {base.RutPersona}\n"+
                   $"Telefono: {base.TelefonoPersona}\n"+
                   $"Tipo Enfermedad: {TipoEnfermedadCronica}\n"+
                   $"Tiempo Cronico: {TiempoCronico}\n"+
                   $"Direccion: {DireccionClienteAEC}\n"+
                   $"Correo Electronico: {CorreoElectronicoClienteAEC}");
        }
    }
}
