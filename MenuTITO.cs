using System;
using Clientes;
using Generadores;
using Interfaces;
using Inventario;
using Productos;
using SaludAnimal;
using Trabajadores;


namespace Main{
    public class Sistema{
            public static void MenuPrincipal(){
                //bool flag = true;

                int op = 0;

                Console.Write($"Menú Principal \n"+
                    $"1) Salud Animal\n"+
                    $"2) Comprar\n"+
                    $"3) Crear Trabajador\n"+
                    $"4) salir\n"+
                    $"opción: ");
                try {
                    op = Convert.ToInt32(Console.ReadLine());
                }
                catch(System.FormatException){
                    //flag=true;
                    Console.WriteLine("\nse acaba de ingresar una letra, intente de nuevo.\n");
                }

                switch(op){
                    case 1:
                        MenuSaludAnimal();
                        break;
                    case 2:
                        MenuCompra();
                        break;
                    case 3:
                        MenuCrearTrabajador();
                        break;
                    case 4: 
                        //TERMINAR EL PROGRAMA
                    default:
                        Console.WriteLine("No se Ingreso ninguna opción");
                        break;
                }
            }
            
            public static void MenuCompra(){
                //bool flag = true;

                int op = 0;

                Console.Write($"Ingrese lo que desea comprar: \n"+
                    $"1) Comida de Gato\n"+
                    $"2) Comida de Perro\n"+
                    $"3) Juguetes\n"+
                    $"4) Volver\n"+
                    $"opción: ");
                try {
                    op = Convert.ToInt32(Console.ReadLine());
                }
                catch(System.FormatException){
                    //flag=true;
                    Console.WriteLine("\nse acaba de ingresar una letra, intente de nuevo.\n");
                }
                

                string producto = " ", tipoComida = " ";
                double precio, cantidad;

                switch(op){
                    case 1:
                        Console.WriteLine("Comida para Gato");
                        Console.Write("Nombre del Producto: "); producto = Console.ReadLine();
                        Console.Write("Precio: ");              precio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tipo de Comida: ");      tipoComida = Console.ReadLine();
                        Console.Write("Cantidad: ");            cantidad = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();
                        
                        ComidaGato comidaGato = new ComidaGato(producto,precio,tipoComida,cantidad);
                        comidaGato.MostrarInformacionProducto();
                        break;
                    case 2:
                        Console.WriteLine("Comida para Perro");
                        Console.Write("Nombre del Producto: "); producto = Console.ReadLine();
                        Console.Write("Precio: ");              precio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tipo de Comida: ");      tipoComida = Console.ReadLine();
                        Console.Write("Cantidad: ");            cantidad = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine();

                        ComidaPerro comidaPerro = new ComidaPerro(producto,precio,tipoComida,cantidad);
                        comidaPerro.MostrarInformacionProducto();
                        break;
                    case 3:
                        Console.WriteLine("Juguete");
                        Console.Write("Nombre del Producto: "); producto = Console.ReadLine();
                        Console.Write("Precio: ");              precio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tipo de Juguete: ");     string tipoJuguete = Console.ReadLine();
                        Console.Write("Cantidad: ");            cantidad = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();

                        Juguete juguete = new Juguete(producto,precio,tipoJuguete,cantidad);
                        juguete.MostrarInformacionProducto();
                        
                        break;
                    case 4:
                        MenuPrincipal();
                        Console.WriteLine("------Volvio al Menú principal------");
                        //ir a la funcion de menú principal
                        break;
                    default:
                        Console.WriteLine("No se Ingreso ninguna opción");
                        break;
                }
            }

            public static void MenuSaludAnimal(){
                //bool flag = true;

                int op = 0;

                Console.Write($"Salud Animal \n"+
                    $"1) Cirugia\n"+
                    $"2) Radiografía\n"+
                    $"3) Tratamiento\n"+
                    $"4) Volver\n"+
                    $"opción: ");
                try {
                    op = Convert.ToInt32(Console.ReadLine());
                }
                catch(System.FormatException){
                    //flag=true;
                    Console.WriteLine("\nse acaba de ingresar una letra, intente de nuevo.\n");
                }

                switch(op){
                    case 1:
                        string tipoCirugia = "";
                        Console.WriteLine("----Cirugia----");
                        Console.Write("Tipo de Cirugia: ");            tipoCirugia = Console.ReadLine();
                        Console.Write("Costo de la Cirugia: ");        double costoCirugia = Convert.ToDouble(Console.ReadLine());
                        
                        Cirugia cirugia = new Cirugia(tipoCirugia,costoCirugia);
                        cirugia.MostrarInformacionCirugia();
                        break;
                    case 2:
                        string tipoRadiografia = "";
                        Console.WriteLine("----Radiografía----");
                        Console.Write("Tipo de Radiografía: ");        tipoRadiografia = Console.ReadLine();
                        Console.Write("Costo de la Radiografía: ");    double costoRadiografia = Convert.ToDouble(Console.ReadLine());
                        
                        Radiografia radiografia = new Radiografia(tipoRadiografia,costoRadiografia);
                        radiografia.MostrarInformacionRadiografia();
                        
                        break;
                    case 3:
                        string tipoTratamiento = " ";
                        string duracionTratamiento = " ";

                        Console.WriteLine("----Tratamiento----");
                        Console.Write("Tipo de Tratamiento: ");          tipoTratamiento = Console.ReadLine();
                        Console.Write("Duración del Tratamiento: ");     duracionTratamiento = Console.ReadLine();
                        Console.Write("Costo del Tratamiento: ");        double costoTratamiento = Convert.ToDouble(Console.ReadLine());
                        
                        Tratamiento tratamiento = new Tratamiento(tipoTratamiento,duracionTratamiento,costoTratamiento);
                        tratamiento.MostrarInformacionTratamiento();
                        
                        break;
                    case 4:
                        MenuPrincipal();
                        Console.WriteLine("------Volvio al Menú principal------");
                        break;
                    default:
                        Console.WriteLine("No se Ingreso ninguna opción");
                        break;
                }
            }
            //crear un switch donde las opciones sean : Cliente Normal, Cliente Regular, Cliente AEC, Cliente De Emergencia
            
            public static void MenuCrearTrabajador(){
                //bool flag = true;

                int op = 0;

                Console.Write($"Menú Principal \n"+
                    $"1) Cajero\n"+
                    $"2) Guardia\n"+
                    $"3) Veterinario\n"+
                    $"4) Volver\n"+
                    $"opción: ");
                try {
                    op = Convert.ToInt32(Console.ReadLine());
                }
                catch(System.FormatException){
                    //flag=true;
                    Console.WriteLine("\nse acaba de ingresar una letra, intente de nuevo.\n");
                }
                
                string nombrePersona = " ";
                string apellidoPersona = " ";
                string runPersona = " ";
                string telefonoPersona = " ";
                string tiempoServicioPersona = " ";
                string correoElectronicoPersona = " ";
                string direccionPersona = " ";

                switch(op){
                    case 1:
                        Console.WriteLine("Datos Cajero");
                        Console.Write("Nombre: ");              nombrePersona = Console.ReadLine();
                        Console.Write("Apellido: ");            apellidoPersona = Console.ReadLine();
                        Console.Write("Run: ");                 runPersona = Console.ReadLine();
                        Console.Write("Teléfono: ");            telefonoPersona = Console.ReadLine();
                        Console.Write("Tiempo de Servicio: ");  tiempoServicioPersona = Console.ReadLine();
                        Console.Write("Correo Electrónico: ");  correoElectronicoPersona = Console.ReadLine();
                        Console.Write("Dirección: ");           direccionPersona = Console.ReadLine();

                        Console.WriteLine();

                        Cajero caja = new Cajero(nombrePersona,apellidoPersona,runPersona,telefonoPersona,tiempoServicioPersona,correoElectronicoPersona,direccionPersona);
                        caja.MostrarInformacion();
                        break;
                    case 2:
                        Console.WriteLine("Datos Guardia");
                        Console.Write("Nombre: ");              nombrePersona = Console.ReadLine();
                        Console.Write("Apellido: ");            apellidoPersona = Console.ReadLine();
                        Console.Write("Run: ");                 runPersona = Console.ReadLine();
                        Console.Write("Teléfono: ");            telefonoPersona = Console.ReadLine();
                        Console.Write("Tiempo de Servicio: ");  tiempoServicioPersona = Console.ReadLine();
                        Console.Write("Correo Electrónico: ");  correoElectronicoPersona = Console.ReadLine();
                        Console.Write("Dirección: ");           direccionPersona = Console.ReadLine();

                        Console.WriteLine();

                        Guardia guardia = new Guardia(nombrePersona,apellidoPersona,runPersona,telefonoPersona,tiempoServicioPersona,correoElectronicoPersona,direccionPersona);
                        guardia.MostrarInformacion();
                        break;
                    case 3:
                        MenuCrearTrabajador();

                        string tipoVeterinario = " ";

                        Console.WriteLine("Datos Veterinario");
                        Console.Write("Nombre: ");              nombrePersona = Console.ReadLine();
                        Console.Write("Apellido: ");            apellidoPersona = Console.ReadLine();
                        Console.Write("Run: ");                 runPersona = Console.ReadLine();
                        Console.Write("Teléfono: ");            telefonoPersona = Console.ReadLine();
                        Console.Write("Tipo de Veterinario: "); tipoVeterinario = Console.ReadLine();
                        Console.Write("Tiempo de Servicio: ");  tiempoServicioPersona = Console.ReadLine();
                        Console.Write("Correo Electrónico: ");  correoElectronicoPersona = Console.ReadLine();
                        Console.Write("Dirección: ");           direccionPersona = Console.ReadLine();

                        Console.WriteLine();

                        Veterinario veterinario = new Veterinario(nombrePersona,apellidoPersona,runPersona,telefonoPersona,tipoVeterinario,correoElectronicoPersona,direccionPersona,tiempoServicioPersona);
                        veterinario.MostrarInformacion();
                        break;
                    case 4:
                        MenuPrincipal();
                        Console.WriteLine("------Volvio al Menú principal------");
                        break;
                    default:
                        Console.WriteLine("No se Ingreso ninguna opción");
                        break;
                }    
            }
            static void Main(string[] args){
                MenuPrincipal();
            }
    }
}
