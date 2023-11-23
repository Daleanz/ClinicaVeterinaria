using System;
using Generadores;

namespace Clientes{
    class ClienteRegular : Persona{
        private int tiempoCliente;
        private int citasPromedioCliente;
        private string correoElectronicoCliente;
        private string direccionCliente;

        public ClienteRegular(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, int tiempoCliente, int citasPromedioCliente, string direccionCliente, string correoElectronicoCliente) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tiempoCliente = tiempoCliente;
            this.citasPromedioCliente = citasPromedioCliente;
            this.correoElectronicoCliente = correoElectronicoCliente;
            this.direccionCliente = direccionCliente;
        }

        public int TiempoCliente{
            get{return tiempoCliente;}
            set{this.tiempoCliente = value;}
        }

        public int CitasPromedioCliente{
            get{return citasPromedioCliente;}
            set{this.citasPromedioCliente = value;}
        }

        public string CorreoElectronicoCliente{
            get{return correoElectronicoCliente;}
            set{this.correoElectronicoCliente = value;}
        }

        public string DireccionCliente{
            get{return direccionCliente;}
            set{this.direccionCliente = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Información del Cliente Regular");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                   $"Apellido: {base.ApellidoPersona}\n"+
                   $"Rut: {base.RutPersona}\n"+
                   $"Telefono: {base.TelefonoPersona}\n"+
                   $"Tiempo: {TiempoCliente}\n"+
                   $"Promedio Citas: {CitasPromedioCliente}\n"+
                   $"Correo Electronico: {CorreoElectronicoCliente}\n"+
                   $"Direccion: {DireccionCliente}");
        }
    }
}
