using System;
using Generadores;
using Clientes;

namespace Generadores{
    abstract class Cliente : Persona{
        private string tipoCliente;
        private string[] tipoClientes = {"cliente regular", "cliente emergencia", "cleinte aec"};

        public Cliente(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tipoCliente) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tipoCliente = tipoCliente;
        }

        public string TipoCliente{
            get{return tipoCliente;}
            set{this.tipoCliente = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Cliente:");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Tipo: {TipoCliente}");
        }
    }
}
