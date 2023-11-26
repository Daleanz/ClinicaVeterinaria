using System;
using Generadores;

namespace Trabajadores{
    class Cajero : Persona{
        private string tiempoDeServicio;
        private string correoElectronicoCajero;
        private string direccionCajero;

        public Cajero(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tiempoDeServicio, string correoElectronicoCajero, string direccionCajero) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tiempoDeServicio = tiempoDeServicio;
            this.correoElectronicoCajero = correoElectronicoCajero;
            this.direccionCajero = direccionCajero;
        }

        public string CorreoElectronicoCajero{
            get{return correoElectronicoCajero;}
            set{this.correoElectronicoCajero = value;}
        }

        public string DireccionCajero{
            get{return direccionCajero;}
            set{this.direccionCajero = value;}
        }

        public string TiempoDeServicio{
            get{return tiempoDeServicio;}
            set{this.tiempoDeServicio = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Cajero");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo: {CorreoElectronicoCajero}\n"+
                    $"Direccion: {DireccionCajero}\n"+
                    $"Tiempo de Servicio: {TiempoDeServicio}");
        }
    }
}
