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

            Console.Write($"///// Menú Principal \\\\\\\\\\"+"\n"+
                $"1) Salud Animal\n"+
                $"2) Comprar\n"+
                $"3) Crear Trabajador\n"+
                $"4) salir\n"+
                $"--- opción: ");
            try {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException){
                //flag=true;
                Console.WriteLine("\nSe acaba de ingresar una letra, intente de nuevo.\n");
                MenuPrincipal();
            }

            switch(op){
                case 1:
                    Console.WriteLine("**************************");
                    MenuSaludAnimal();
                    break;
                case 2:
                    Console.WriteLine("**************************");
                    MenuCompra();
                    break;
                case 3:
                    Console.WriteLine("**************************");
                    MenuCrearTrabajador();
                    break;
                case 4: 
                    Console.WriteLine("\n*****FINALIZANDO*****");
                    Environment.Exit(0);
                    //TERMINAR EL PROGRAMA
                    break;
                default:
                    Console.WriteLine("----Opción no valida----");
                    MenuPrincipal();
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
                $"5) Salir\n"+
                $"--- opción: ");
            try {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException){
                //flag=true;
                Console.WriteLine("\nse acaba de ingresar una letra, intente de nuevo.\n");
                MenuCompra();
            }
            

            string producto = " ", tipoComida = " ";
            double cantidad;
            int precio;

            switch(op){
                case 1:
                    Console.WriteLine("Comida para Gato");
                    Console.Write("Nombre del Producto: "); producto = Console.ReadLine();
                    Console.Write("Precio: ");              
                    try{
                        precio = Convert.ToInt32(Console.ReadLine());
                    }catch(System.OverflowException){
                        Console.WriteLine("\nEl Precio supero el monto máximo : 2.147.483.647\n"+
                        $"Vuelva a seleccionar 'Comida para Gato' pero esta vez el monto no debe superar al antes mencionado");
                        MenuCompra();
                        precio=0;
                    }catch(System.FormatException){
                        Console.WriteLine("\nHa ingresado un carácter\n"+
                        $"Vuelva a seleccionar 'Comida para Gato' pero esta vez el monto no debe superar al antes mencionado\n");
                        MenuCompra();
                        precio=0;
                    }
                    Console.Write("Tipo de Comida: ");      tipoComida = Console.ReadLine();
                    Console.Write("Cantidad: ");            cantidad = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                    
                    ComidaGato comidaGato = new ComidaGato(producto,precio,tipoComida,cantidad);
                    comidaGato.MostrarInformacionProducto();
                    break;
                case 2:
                    Console.WriteLine("Comida para Perro");
                    Console.Write("Nombre del Producto: "); producto = Console.ReadLine();
                    Console.Write("Precio: ");              
                    try{
                        precio = Convert.ToInt32(Console.ReadLine());
                    }catch(System.OverflowException){
                        Console.WriteLine("\nEl Precio supero el monto máximo : 2.147.483.647\n"+
                        $"Vuelva a seleccionar 'Comida para Perros' pero esta vez el monto no debe superar al antes mencionado\n");
                        MenuCompra();
                        precio=0;
                    }catch(System.FormatException){
                        Console.WriteLine("\nHa ingresado un carácter\n"+
                        $"Vuelva a seleccionar 'Comida para Perros' pero esta vez el monto no debe superar al antes mencionado\n");
                        MenuCompra();
                        precio=0;
                    }
                    Console.Write("Tipo de Comida: ");      tipoComida = Console.ReadLine();
                    Console.Write("Cantidad: ");            cantidad = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine();

                    ComidaPerro comidaPerro = new ComidaPerro(producto,precio,tipoComida,cantidad);
                    comidaPerro.MostrarInformacionProducto();
                    break;
                case 3:
                    Console.WriteLine("Juguete");
                    Console.Write("Nombre del Producto: "); producto = Console.ReadLine();
                    Console.Write("Precio: ");              
                    try{
                        precio = Convert.ToInt32(Console.ReadLine());
                    }catch(System.OverflowException){
                        Console.WriteLine("\nEl Precio supero el monto máximo : 2.147.483.647\n"+
                        $"Vuelva a seleccionar 'Juguetes' pero esta vez el monto no debe superar al antes mencionado\n");
                        MenuCompra();
                        precio=0;
                    }catch(System.FormatException){
                        Console.WriteLine("\nHa ingresado un carácter\n"+
                        $"Vuelva a seleccionar 'Juguetes' pero esta vez el monto no debe superar al antes mencionado\n");
                        MenuCompra();
                        precio=0;
                    }
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
                case 5: 
                    Console.WriteLine("\n*****FINALIZANDO*****");
                    Environment.Exit(0);
                    //TERMINAR EL PROGRAMA
                    break;
                default:
                    Console.WriteLine("----Opción no valida----");
                    MenuCompra();
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
                $"5) Salir\n"+
                $"--- opción: ");
            try {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException){
                //flag=true;
                Console.WriteLine("\nse acaba de ingresar una letra, intente de nuevo.\n");
                MenuSaludAnimal();
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
                case 5: 
                    Console.WriteLine("\n*****FINALIZANDO*****");
                    Environment.Exit(0);
                    //TERMINAR EL PROGRAMA
                    break;
                default:
                    Console.WriteLine("----Opción no valida----");
                    MenuSaludAnimal();
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
                $"5) Salir\n"+
                $"--- opción: ");
            try {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException){
                //flag=true;
                Console.WriteLine("\nse acaba de ingresar una letra, intente de nuevo.\n");
                MenuCrearTrabajador();
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
                case 5: 
                    Console.WriteLine("\n*****FINALIZANDO*****");
                    Environment.Exit(0);
                    //TERMINAR EL PROGRAMA
                    break;
                default:
                    Console.WriteLine("----Opción no valida----");
                    MenuCrearTrabajador();
                    break;
            }    
        }
        static void Main(string[] args){
            MenuPrincipal();
        }
    }
}
