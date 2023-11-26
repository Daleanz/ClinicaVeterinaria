using System;
using Generadores;

namespace Clientes{
    class ClienteEmergencia : Persona{
        private string categoriaCE;
        private string direccionCE;
        private string correoElectronicoCE;

        public ClienteEmergencia(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string categoriaEC, string direccionCE, string correoElectronicoCE) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.categoriaCE = categoriaCE;
            this.direccionCE = direccionCE;
            this.correoElectronicoCE = correoElectronicoCE;
        }

        public string CategoriaEC{
            get{return categoriaCE;}
            set{this.categoriaCE = value;}
        }

        public string DireccionCE{
            get{return direccionCE;}
            set{this.direccionCE = value;}
        }

        public string CorreoElectronicoCE{
            get{return correoElectronicoCE;}
            set{this.correoElectronicoCE = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Cliente Emergencia:");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo: {CorreoElectronicoCE}\n"+
                    $"Direccion: {DireccionCE}\n"+
                    $"Categoria: {CategoriaEC}");
        }
    }
}
