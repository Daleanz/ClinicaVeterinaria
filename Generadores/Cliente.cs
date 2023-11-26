using System;
using Generadores;
using Excepciones;
using Clientes;

namespace Generadores{
    abstract class Cliente : Persona{
        private string tipoCliente;
        private string[] tipoClientes = {"cliente regular", "cliente emergencia", "cleinte aec"};

        public Cliente(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tipoCliente) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            if(!VerificarCliente(tipoCliente)){
                throw new ClienteInvalidoExcepcion("Cliente Invalido");
            }

            this.tipoCliente = tipoCliente;
        }

        public string TipoCliente{
            get{return tipoCliente;}
            set{this.tipoCliente = value;}
        }

        private void LlamarConstructor(string tipoCliente){
            int constructor = 0;
            for(int i = 0; i < tipoClientes.Length; i++){
                if(tipoCliente.ToLower() == tipoClientes[i]){
                    constructor = i + 1;
                }
            }
            switch(constructor){
                case 1:
                    ClienteRegular CR = new ClienteRegular();
                case 2:
                    ClienteEmergencia CE = new ClienteEmergencia();
                case 3:
                    ClienteAEC CAEC = new ClienteAEC();
            }
        }

        private bool VerificarCliente(string tipoCliente){
            tipoCliente = tipoCliente.ToLower();

            for(int i = 0; i < tipoClientes.Length; i ++){
                if(tipoClientes[i] == tipoCliente){
                    return true;
                }
            }
            return false;
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
