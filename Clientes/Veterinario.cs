using System;
using Generadores;

namespace Clientes{
    class Veterinario : Persona {
        //Atributos
        private string correoElectronicoVeterinario;
        private List<Persona> listaClientes;

        //Constructor
        public Veterinario(string nombrePersona,string apellidoPersona,string rutPersona,string telefonoPersona,string correoElectronicoVeterinario,) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.correoElectronicoVeterinario = correoElectronicoVeterinario;
            this.listaClientes = new List<Persona>();//se le pasan objetos tipo clienteRegular
        }

        //Métodos
        public string CorreoElectronicoVeterinario{
            get { return correoElectronicoVeterinario; }
            set { this.correoElectronicoVeterinario=value; }
        }
        public List<Persona> listaClientes{
            get { return this.listaClientes; }
        }

        public override void MostrarInformacion(){
            Console.WriteLine("Información del Veterinario");
            Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo Electronico: {CorreoElectronicoVeterinario}\n"+
                    $"Acargo de los Clientes: ");
                    foreach(var elemento in listaClientes){ //muestra los clientes que el Veterinario tiene acargo
                        elemento.MostrarInformacion();
                    }
        }
    }
}
