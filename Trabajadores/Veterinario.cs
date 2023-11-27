using System;
using Generadores;
using Interfaces;

namespace Trabajadores{
    class Veterinario : Persona{
        private string tipoDeVeterinario;
        private string correoElectronicoVeterinario;
        private string direccionVeterinario;
        private string tiempoDeServicio;
        private List<ICliente> clientes;

        public Veterinario(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tipoDeVeterinario, string correoElectronicoVeterinario, string direccionVeterinario, string tiempoDeServicio) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tipoDeVeterinario = tipoDeVeterinario;
            this.correoElectronicoVeterinario = correoElectronicoVeterinario;
            this.direccionVeterinario = direccionVeterinario;
            this.tiempoDeServicio = tiempoDeServicio;
            this.clientes = new List<ICliente>();
        }

        public void AgregarCliente(ICliente cliente){
            if(clientes.Count == 0){
                clientes.Add(cliente);
                System.Console.WriteLine($"Se asigno correctamente el Cliente al Veterinario: {base.NombrePersona}");
            }
            if(clientes.Contains(cliente)){
                System.Console.WriteLine($"No se puede asignar el mismo cliente.");
                cliente.MostrarInformacion();
            }
        }

        public void EliminarCliente(ICliente cliente){
            if(clientes.Count == 0){
                System.Console.WriteLine($"No tiene ningun paciente asignado el Veterniario: {base.NombrePersona}");
            }
            if(clientes.Contains(cliente)){
                clientes.Remove(cliente);
                System.Console.WriteLine($"Se ha eliminado correctamente el paciente de: {base.NombrePersona}");
            }
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
