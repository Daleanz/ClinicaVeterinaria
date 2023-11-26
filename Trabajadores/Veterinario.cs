using System;
using Generadores;

namespace Trabajadores{
    class Veterinario : Persona{
        private string tipoDeVeterinario;
        private string correoElectronicoVeterinario;
        private string direccionVeterinario;
        private string tiempoDeServicio;

        public Veterinario(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tipoDeVeterinario, string correoElectronicoVeterinario, string direccionVeterinario, string tiempoDeServicio) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tipoDeVeterinario = tipoDeVeterinario;
            this.correoElectronicoVeterinario = correoElectronicoVeterinario;
            this.direccionVeterinario = direccionVeterinario;
            this.tiempoDeServicio = tiempoDeServicio;

        }

        public string TiempoDeServicio{
            get{return tiempoDeServicio;}
            set{this.tiempoDeServicio = value;}
        }

        public string CorreoElectronicoVeterinario{
            get{return correoElectronicoVeterinario;}
            set{this.correoElectronicoVeterinario = value;}
        }

        public string DireccionVeterinario{
            get{return direccionVeterinario;}
            set{this.direccionVeterinario = value;}
        }

        public string TipoDeVeterinario{
            get{return tipoDeVeterinario;}
            set{this.tipoDeVeterinario = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Veterinario");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo: {CorreoElectronicoVeterinario}\n"+
                    $"Direccion: {DireccionVeterinario}\n"+
                    $"Tipo: {TipoDeVeterinario}\n"+
                    $"Tiempo de Servicio: {TiempoDeServicio}");
        }
    }
}
