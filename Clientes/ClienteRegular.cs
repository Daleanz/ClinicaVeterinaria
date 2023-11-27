using System;
using Generadores;
using SaludAnimal;
using Interfaces;
using Productos; 

namespace Clientes{
    class ClienteRegular : Persona, ICompraCliente, ICliente{
        private string tiempoCliente;
        private string citasPromedioCliente;
        private string correoElectronicoCliente;
        private string direccionCliente;
        private List<Tratamiento> tratamientos;
        private List<Cirugia> cirugias;
        private List<Radiografia> radiografias;
        private List<Producto> compras;

        public ClienteRegular(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tiempoCliente, string citasPromedioCliente, string correoElectronicoCliente, string direccionCliente) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tiempoCliente = tiempoCliente;
            this.citasPromedioCliente = citasPromedioCliente;
            this.correoElectronicoCliente = correoElectronicoCliente;
            this.direccionCliente = direccionCliente;
            this.tratamientos = new List<Tratamiento>();
            this.cirugias = new List<Cirugia>();
            this.radiografias = new List<Radiografia>();
            this.compras = new List<Producto>();
        }

        public void ComprarProducto(Producto producto, int cantidad){
            compras.Add(producto);
        }

        public void DevolverProducto(Producto producto, int cantidad){
            if(compras.Count == 0){
                System.Console.WriteLine("No puede devolver nada, porque no tiene ningun producto.");
            } 
            if(compras.Count != 0){
                int tipoComidaPerro = ContarTipoProducto<ComidaPerro>(compras);
                int tipoComidaGato = ContarTipoProducto<ComidaGato>(compras);
                int tipoJuguete = ContarTipoProducto<Juguete>(compras);

                foreach(var pro in compras){
                    if(producto == pro){
                        for(int i = 0; i < cantidad; i ++){
                            compras.Remove(pro);
                        }
                    } 
                }
                System.Console.WriteLine("Se han devuelto correctamente los productos.");
            }
        }

        public int ContarTipoProducto<T>(List<Producto> lista){
            return lista.Count(item => item is T);
        }

        public List<Producto> ObtenerCompras{
            get{return compras;}
        }

        public List<Tratamiento> ObtenerTratamientos{
            get{return tratamientos;}
        }

        public List<Radiografia> ObtenerRadiografias{
            get{return radiografias;}
        }

        public List<Cirugia> ObtenerCirugias{
            get{return cirugias;}
        }


        public void AgregarTratamiento(Tratamiento tratamiento){
            tratamientos.Add(tratamiento);
        }

        public int CantidadItem{
            get{return tratamientos.Count + radiografias.Count + cirugias.Count + compras.Count;}
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

            if(tratamientos.Count != 0){
                System.Console.WriteLine("Tratamiento");
                foreach(Tratamiento tratamiento in tratamientos){
                    tratamiento.MostrarInformacionTratamiento();
                }

            }

            if(cirugias.Count != 0){
                System.Console.WriteLine("Cirugias");
                foreach(Cirugia cirugia in cirugias){
                    cirugia.MostrarInformacionCirugia();
                }
            }
            
            if(radiografias.Count != 0){
                System.Console.WriteLine("Radiografias");
                foreach(Radiografia radiografia in radiografias){
                    radiografia.MostrarInformacionRadiografia();
                }
            }
        }
    }
}
