using System;
using Generadores;

namespace Trabajadores{
    class Guardia : Persona{
        private string tiempoDeServicio;
        private string correoElectronicoGuardia;
        private string direccionGuardia;

        public Guardia(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tiempoDeServicio, string correoElectronicoGuardia, string direccionGuardia) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tiempoDeServicio = tiempoDeServicio;
            this.correoElectronicoGuardia = correoElectronicoGuardia;
            this.direccionGuardia = direccionGuardia;
        }

        public string TiempoDeServicio{
            get{return tiempoDeServicio;}
            set{this.tiempoDeServicio = value;}
        }

        public string CorreoElectronicoGuardia{
            get{return correoElectronicoGuardia;}
            set{this.correoElectronicoGuardia = value;}
        }

        public string DireccionGuardia{
            get{return direccionGuardia;}
            set{this.direccionGuardia = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Guardia");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo: {CorreoElectronicoGuardia}\n"+
                    $"Direccion: {DireccionGuardia}\n"+
                    $"Tiempo de Sevicio: {TiempoDeServicio}");
        }
    }
}
