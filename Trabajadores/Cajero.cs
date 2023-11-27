using System;
using Generadores;
using Interfaces;
using Inventario;
using Clinica;
using SaludAnimal;
using System.Globalization;

namespace Trabajadores{
    class Cajero : Persona, ICajero{
        private string tiempoDeServicio;
        private string correoElectronicoCajero;
        private string direccionCajero;

        public Cajero(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tiempoDeServicio, string correoElectronicoCajero, string direccionCajero) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tiempoDeServicio = tiempoDeServicio;
            this.correoElectronicoCajero = correoElectronicoCajero;
            this.direccionCajero = direccionCajero;
        }

        public Cajero(string nombrePersona, string apellidoPersona, string rutPersona, string telefonoPersona, string tiempoDeServicio) : base(nombrePersona, apellidoPersona, rutPersona, telefonoPersona){
            this.tiempoDeServicio = tiempoDeServicio;
            this.correoElectronicoCajero = " ";
            this.direccionCajero = " ";
        }

        public void VenderProducto(Bodega bodega, Producto producto, int cantidad){
            if(bodega.ObtenerCapacidadRestante() < cantidad){
                System.Console.WriteLine($"No existen suficientes productos de: {producto.NombreProducto}");
            }else{
                for(int i = 0; i < cantidad; i ++){
                    bodega.EliminarProductoInventario(producto);
                }
            }
            // Falta generar la boleta.
            System.Console.WriteLine($"Si se puede vender {cantidad} unidades de {producto.NombreProducto}");
        }

        public void GenerarBoleta(ICliente cliente, ClinicaVET Clinica){
            DateTime fechaHora = DateTime.Now;
            List<Tratamiento> listaTratamientos = cliente.ObtenerTratamientos;
            List<Cirugia> listaCirugias = cliente.ObtenerCirugias;
            List<Radiografia> listaRadiografias = cliente.ObtenerRadiografias;
            List<Producto> listaCompras = cliente.ObtenerCompras;
            double TotalItem = 0;

            int maxLength = 0;
            foreach(Tratamiento tra in  listaTratamientos){
                if(tra.TipoTratamiento.Length > maxLength){
                    maxLength = tra.TipoTratamiento.Length;
                }
            }
            string rutaBoletaElectronica = "BoletaElectronica.txt";
            using(StreamWriter guardar = new StreamWriter(rutaBoletaElectronica)){
                guardar.WriteLine($"                                     {Clinica.RutClinica}                                ");
                guardar.WriteLine("                                  BOLETA ELECTRONICA                                 ");
                guardar.WriteLine($"\n                         Procesamiento y Transmisión de datos                        ");
                guardar.WriteLine($"                         General del canto {Clinica.DireccionClinica}                    ");
                guardar.WriteLine($"\n");
                guardar.WriteLine($"                              Emisión: {fechaHora}                               ");
                guardar.WriteLine($"\n");


                guardar.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                guardar.WriteLine("{0, -" + (maxLength + 2) + "} {1,-15}   {2, -15} {3, -15}", "           ITEM", "PRECIO UNITARIO", "CANTIDAD", "TOTAL ITEM");
                guardar.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                foreach(Tratamiento tra in listaTratamientos){
                    guardar.WriteLine("{0, -" + (maxLength + 2) + "}      {1,-15} {2, -15}{3, -15}", tra.TipoTratamiento,$"${Precio(tra.CostoTratamiento)}", tra.CantidadTratamiento,$"${Precio(tra.CostoTratamiento, tra.CantidadTratamiento)}");
                    TotalItem = TotalItem + tra.CostoTratamiento * tra.CantidadTratamiento;
                }

                foreach(Radiografia rad in listaRadiografias){
                    guardar.WriteLine("{0, -" + (maxLength + 2) + "}      {1,-15} {2, -15}{3, -15}", rad.TipoRadiografia, $"${Precio(rad.CostoRadiografia)}", rad.CantidadRadiografia, $"${Precio(rad.CostoRadiografia, rad.CantidadRadiografia)}");
                    TotalItem = TotalItem + rad.CostoRadiografia * rad.CantidadRadiografia;
                }

                foreach(Cirugia cir in listaCirugias){
                    guardar.WriteLine("{0, -" + (maxLength + 2) + "}      {1,-15} {2, -15}{3, -15}", cir.TipoCirugia, $"${Precio(cir.CostoCirugia)}", cir.CantidadCirugia, $"${Precio(cir.CostoCirugia, cir.CantidadCirugia)}");
                    TotalItem = TotalItem + cir.CostoCirugia + cir.CantidadCirugia;
                }

                foreach(var producto in listaCompras){
                    guardar.WriteLine("{0, -" + (maxLength + 2) + "}      {1,-15} {2, -15}{3, -15}", producto.NombreProducto, $"${Precio(producto.PrecioProducto)}", producto.CantidadProducto,$"${Precio(producto.PrecioProducto + producto.CantidadProducto)}");
                    TotalItem = TotalItem + producto.PrecioProducto + producto.CantidadProducto;
                }

                string TotalFinal = Precio(TotalItem);
    
                guardar.WriteLine(" ");
                guardar.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                guardar.WriteLine($"                                       TOTAL: ${TotalFinal}");
                guardar.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                
            }
        }

        private string Precio(double precio){
            string precioFormato = precio.ToString("N", CultureInfo.GetCultureInfo("es-Es"));
            return precioFormato;
        }

        private string Precio(double precio, int cantidad){
            string precioFormato = (precio * cantidad).ToString("N", CultureInfo.GetCultureInfo("es-Es"));
            return precioFormato;
        }

        public string CorreoElectronicoCajero{
            get{return correoElectronicoCajero;} 
            set{this.correoElectronicoCajero = value;}
        }

        public string DireccionCajero{
            get{return direccionCajero;}
            set{this.direccionCajero = value;}
        }

        public string TiempoDeServicio{
            get{return tiempoDeServicio;}
            set{this.tiempoDeServicio = value;}
        }

        public override void MostrarInformacion(){
            System.Console.WriteLine("Informacion Cajero");
            System.Console.WriteLine($"Nombre: {base.NombrePersona}\n"+
                    $"Apellido: {base.ApellidoPersona}\n"+
                    $"Rut: {base.RutPersona}\n"+
                    $"Telefono: {base.TelefonoPersona}\n"+
                    $"Correo: {CorreoElectronicoCajero}\n"+
                    $"Direccion: {DireccionCajero}\n"+
                    $"Tiempo de Servicio: {TiempoDeServicio}");
        }
    }
}
