using System;
using Generadores;
using SaludAnimal;

namespace Clientes{
    class ClienteAEC : Persona{
        private string tipoEnfermedadCronica;
        private int tiempoCronico;
        private string direccionCAEC;
        private string correoElectronicoCAEC;
        private List<Tratamiento> tratamientos;
        private List<Cirugia> cirugias;
        private List<Radiografia> radiografias;

        public ClienteAEC(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tipoEnfermedadCronica, int tiempoCronico, string direccionCAEC, string correoElectronicoCAEC) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
           this.tipoEnfermedadCronica = tipoEnfermedadCronica;
           this.tiempoCronico = tiempoCronico;
           this.direccionCAEC = direccionCAEC;
           this.correoElectronicoCAEC = correoElectronicoCAEC;
           this.tratamientos = new List<Tratamiento>();
           this.cirugias = new List<Cirugia>();
           this.radiografias = new List<Radiografia>();
        }

        public void AgregarTratamiento(Tratamiento tratamiento){
            tratamientos.Add(tratamiento);
        }

        public void AgregarCirugia(Cirugia cirugia){
            cirugias.Add(cirugia);
        }

        public void AgregarRadiografia(Radiografia radiografia){
            radiografias.Add(radiografia);
        }

        public void EliminarTratamiento(Tratamiento tratamiento){
            int contador = 0;

            if(tratamientos.Contains(tratamiento)){
                contador = contador + 1;
            }

            if(contador > 1){
                tratamientos.Remove(tratamiento);
            }
        }

        public void EliminarCirugia(Cirugia cirugia){
            int contador = 0;

            if(cirugias.Contains(cirugia)){
                contador = contador + 1;
            }

            if(contador > 1){
                cirugias.Remove(cirugia);
            }
        }

        public void EliminarRadiografia(Radiografia radiografia){
            int contador = 0;

            if(radiografias.Contains(radiografia)){
                contador = contador + 1;
            }

            if(contador > 1){
                radiografias.Remove(radiografia);
            }
        }
        
        public string TipoEnfermedadCronica{
            get{return tipoEnfermedadCronica;}
            set{this.tipoEnfermedadCronica = value;}
        }

        public int TiempoCronico{
            get{return tiempoCronico;}
            set{this.tiempoCronico = value;}
        }

        public string DireccionCAEC{
            get{return direccionCAEC;}
            set{this.direccionCAEC = value;}
        }

        public string CorreoElectronicoCAEC{
            get{return correoElectronicoCAEC;}
            set{this.correoElectronicoCAEC = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Cliente AEC:");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo: {CorreoElectronicoCAEC}\n"+
                    $"Direccion: {DireccionCAEC}\n"+
                    $"Tipo Enfermedad Animal: {TipoEnfermedadCronica}\n"+
                    $"Tiempo Cronico: {TiempoCronico}");
            
            System.Console.WriteLine("Tratamientos");
            foreach(Tratamiento tratamiento in tratamientos){
                tratamiento.MostrarInformacionTratamiento();
            }

            System.Console.WriteLine("Cirugias");
            foreach(Cirugia cirugia in cirugias){
                cirugia.MostrarInformacionCirugia();
            }

            System.Console.WriteLine("Radiografias");
            foreach(Radiografia radiografia in radiografias){
                radiografia.MostrarInformacionRadiografia();
            }
        }
    }
}
