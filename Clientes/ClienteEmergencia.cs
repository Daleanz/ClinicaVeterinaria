using System;
using Generadores;
using SaludAnimal;
using Interfaces;
using Productos;

namespace Clientes{
    class ClienteEmergencia : Persona, ICompraCliente, ICliente{
        private string categoriaCE;
        private string direccionCE;
        private string correoElectronicoCE;
        private List<Tratamiento> tratamientos;
        private List<Cirugia> cirugias;
        private List<Radiografia> radiografias;
        private List<Producto> compras;

        public ClienteEmergencia(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string categoriaCE, string direccionCE, string correoElectronicoCE) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.categoriaCE = categoriaCE;
            this.direccionCE = direccionCE;
            this.correoElectronicoCE = correoElectronicoCE;
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
