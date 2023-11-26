using System;
using Generadores;

namespace Clientes{
    class ClienteNormal : Persona{
        public ClienteNormal(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Cliente:");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n");
        }
    }
}
