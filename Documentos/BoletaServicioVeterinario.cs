using System;
using Documentos;
using Generadores;

namespace Documentos{
    class BoletaServicioVeterinario : Documento{
        private string consultaVeterinaria;
        private List<Tratamiento> tratamientos;
        private List<Cirugia> cirugias;
        private List<Radiografia> radiografias;

        public BoletaServicioVeterinario(string nombreClinica, string direccionClinica, string telefonoClinica, string correoElectronicoClinica, string consultaVeterinaria) : base(nombreClinica, direccionClinica, telefonoClinica, correoElectronicoClinica){
            this.consultaVeterinaria = consultaVeterinaria;
            this.tratamientos = new List<Tratamiento>();
            this.cirugias = new List<Cirugia>();
            this.radiografias = new List<Radiografia>();
        }

        public string ConsultaVeterinaria{
            get{return consultaVeterinaria;}
            set{this.consultaVeterinaria = value;}
        }

        public void AgregarTratamiento(Veterinario veterinario){
            tratamientos.Add(veterinario);
        }


        public override void MostrarInformacionDocumento(){
            System.Console.WriteLine("Boleta Veterinaria:");
            System.Console.WriteLine($"Fecha: {base.FechaDocumento}\n"+
                    $"Clinica: {base.NombreClinica}\n"+
                    $"Direccion: {base.DireccionClinica}\n"+
                    $"Telefono: {base.TelefonoClinica}\n"+
                    $"Correo: {base.CorreoElectronicoClinica}\n"+
                    $"Consulta: {ConsultaVeterinaria}");
        }
    }
}
