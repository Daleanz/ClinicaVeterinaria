using System;
using Generadores;

namespace Clientes{
    class ClienteEmergencia : Persona{
        private string categorizacionClienteEmergencia;
        private string direccionClienteEmergencia;
        private string correoElectronicoClienteEmergencia;

        public ClienteEmergencia(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string direccionClienteEmergencia, string correoElectronicoClienteEmergencia, string categorizacionClienteEmergencia) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
           this.categorizacionClienteEmergencia = categorizacionClienteEmergencia;
           this.direccionClienteEmergencia = direccionClienteEmergencia;
           this.correoElectronicoClienteEmergencia = correoElectronicoClienteEmergencia;
        }

        public string CategorizacionClienteEmergencia{
            get{return categorizacionClienteEmergencia;}
            set{this.categorizacionClienteEmergencia = value;}
        } 

        public string DireccionClienteEmergencia{
            get{return direccionClienteEmergencia;}
            set{this.direccionClienteEmergencia = value;}
        }

        public string CorreoElectronicoClienteEmergencia{
            get{return correoElectronicoClienteEmergencia;}
            set{this.correoElectronicoClienteEmergencia = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Información del Cliente Regular");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                   $"Apellido: {base.ApellidoPersona}\n"+
                   $"Rut: {base.RutPersona}\n"+
                   $"Telefono: {base.TelefonoPersona}\n"+
                   $"Categorizacion: {CategorizacionClienteEmergencia}\n"+
                   $"Correo Electronico: {CorreoElectronicoClienteEmergencia}\n"+
                   $"Direccion: {DireccionClienteEmergencia}");
        }

    }
} 
