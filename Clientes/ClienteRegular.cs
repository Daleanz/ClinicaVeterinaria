using System;
using Generadores;
using SaludAnimal;

namespace Clientes{
    class ClienteRegular : Persona{
        private string tiempoCliente;
        private string citasPromedioCliente;
        private string correoElectronicoCliente;
        private string direccionCliente;
        private List<Tratamiento> tratamientos;
        private List<Cirugia> cirugias;
        private List<Radiografia> radiografias;

        public ClienteRegular(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tiempoCliente, string citasPromedioCliente, string correoElectronicoCliente, string direccionCliente) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tiempoCliente = tiempoCliente;
            this.citasPromedioCliente = citasPromedioCliente;
            this.correoElectronicoCliente = correoElectronicoCliente;
            this.direccionCliente = direccionCliente;
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

        public string TiempoCliente{
            get{return tiempoCliente;}
            set{this.tiempoCliente = value;}
        }

        public string CitasPromedioCliente{
            get{return citasPromedioCliente;}
            set{this.citasPromedioCliente = value;}
        }

        public string CorreoElectronicoCliente{
            get{return correoElectronicoCliente;}
            set{this.correoElectronicoCliente = value;}
        }

        public string DireccionCliente{
            get{return direccionCliente;}
            set{this.direccionCliente = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Cliente Regular:");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo: {CorreoElectronicoCliente}\n"+
                    $"Direccion: {DireccionCliente}\n"+
                    $"Tiempo siendo cliente: {TiempoCliente}\n"+
                    $"Citas Promedio: {CitasPromedioCliente}\n");

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
