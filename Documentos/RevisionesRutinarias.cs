using System;
using Documentos;
using Generadores;

namespace Documentos{
    class RevisionesRutinarias : Documento{
        private string tipoDeExamen;
        private string tiempoRutina;
        private string[] listaExamenesFisicos = {"Corazon", "Pulmones", "Orina", "Heces", "Sangre", "Piel", "Oido", "Ojo", "Endocrino"}; 
   // 9 tipo de examenes.     
        public RevisionesRutinarias(string nombreClinica, string direccionClinica, string telefonoClinica, string tipoDeExamen, string tiempoRutina) : base(nombreClinica, direccionClinica, telefonoClinica){
            this.tipoDeExamen = tipoDeExamen;
            this.tiempoRutina = tiempoRutina;
        }

        public string TipoDeExamen{
            get{return tipoDeExamen;}
            set{this.tipoDeExamen = value;}
        }

        public string TiempoRutina{
            get{return tiempoRutina;}
            set{this.tiempoRutina = value;}
        }

        public override void MostrarInformacionDocumento(){
            System.Console.WriteLine("Informacion de Revision Rutinaria");
            System.Console.WriteLine($"Clinica: {base.NombreClinica}\n"+
                    $"Direccion: {base.DireccionClinica}\n"+
                    $"Telefono: {base.TelefonoClinica}\n"+
                    $"Tipo de Examen: {TipoDeExamen}\n"+
                    $"Tiempo Rutina: {TiempoRutina}");
        }
    }
}
