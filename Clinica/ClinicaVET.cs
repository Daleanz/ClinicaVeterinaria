using System;
using Clientes;
using Generadores;
using Interfaces;
using Productos;
using SaludAnimal;
using Trabajadores;

namespace Clinica{
    class ClinicaVET{
        private string nombreClinica;
        private string correoClinica;
        private string telefonoClinica;
        private string rutClinica;
        private string direccionClinica;
        private List<Veterinario> veterinarios;
        private List<Guardia> guardias;
        private List<Cajero> cajeros;
        private List<ClienteRegular> clientesR;
        private List<ClienteNormal> clientesN;
        private List<ClienteAEC> clientesAEC;
        private List<ClienteEmergencia> clientesE;

        public ClinicaVET(string nombreClinica, string rutClinica, string correoClinica, string direccionClinica, string telefonoClinica){
            this.nombreClinica = nombreClinica;
            this.rutClinica = rutClinica;
            this.correoClinica = correoClinica;
            this.direccionClinica = direccionClinica;
            this.telefonoClinica = telefonoClinica;
            this.clientesR = new List<ClienteRegular>();
            this.clientesN = new List<ClienteNormal>();
            this.clientesAEC = new List<ClienteAEC>();
            this.clientesE = new List<ClienteEmergencia>();
            this.veterinarios = new List<Veterinario>();
            this.guardias = new List<Guardia>();
            this.cajeros = new List<Cajero>();
        }

        public void AgregarClienteRegular(ClienteRegular cliente){
            if(clientesR.Count == 0){
                clientesR.Add(cliente);
            }
            if(clientesR.Contains(cliente)){
                System.Console.WriteLine($"Ya existe en el sistema: {cliente.NombrePersona}");
            }
        }

        public void EliminarClienteRegular(ClienteRegular cliente){
            if(clientesR.Contains(cliente)){
                clientesR.Remove(cliente);
                System.Console.WriteLine($"Se ha eliminado correctamente el cliente regular: {cliente.NombrePersona}");
            }
        }
        public void AgregarClienteAEC(ClienteAEC cliente){
            if(clientesAEC.Count == 0){
                clientesAEC.Add(cliente);
            }
            if(clientesAEC.Contains(cliente)){
                System.Console.WriteLine($"Ya existe en el sistema: {cliente.NombrePersona}");
            }
        }

        public void EliminarClienteAEC(ClienteAEC cliente){
            if(clientesAEC.Contains(cliente)){
                clientesAEC.Remove(cliente);
                System.Console.WriteLine($"Se ha eliminado correctamente el cliente regular: {cliente.NombrePersona}");
            }
        }
        public void AgregarClienteNormal(ClienteNormal cliente){
            if(clientesN.Count == 0){
                clientesN.Add(cliente);
            }
            if(clientesN.Contains(cliente)){
                System.Console.WriteLine($"Ya existe en el sistema: {cliente.NombrePersona}");
            }
        }

        public void EliminarClienteNormal(ClienteNormal cliente){
            if(clientesN.Contains(cliente)){
                clientesN.Remove(cliente);
                System.Console.WriteLine($"Se ha eliminado correctamente el cliente regular: {cliente.NombrePersona}");
            }
        }

        public void AgregarClienteEmergencia(ClienteEmergencia cliente){
            if(clientesE.Count == 0){
                clientesE.Add(cliente);
            }
            if(clientesE.Contains(cliente)){
                System.Console.WriteLine($"Ya existe en el sistema: {cliente.NombrePersona}");
            }
        }

        public void EliminarClienteEmegerncia(ClienteEmergencia cliente){
            if(clientesE.Contains(cliente)){
                clientesE.Remove(cliente);
                System.Console.WriteLine($"Se ha eliminado correctamente el cliente regular: {cliente.NombrePersona}");
            }
        }

        public void AgregarVeterinario(Veterinario veterinario){
            if(veterinarios.Count == 0){
                veterinarios.Add(veterinario);
            }
            if(veterinarios.Contains(veterinario)){
                System.Console.WriteLine($"Ya existe en el sistema: {veterinario.NombrePersona}");
            }
        }

        public void EliminarVeterinario(Veterinario veterinario){
            if(veterinarios.Contains(veterinario)){
                veterinarios.Remove(veterinario);
                System.Console.WriteLine($"Se ha eliminado correctamente el cliente regular: {veterinario.NombrePersona}");
            }
        }

        public void AgregarGuardia(Guardia guardia){
            if(guardias.Count == 0){
                guardias.Add(guardia);
            }
            if(guardias.Contains(guardia)){
                System.Console.WriteLine($"Ya existe en el sistema: {guardia.NombrePersona}");
            }
        }

        public void EliminarGuardia(Guardia guardia){
            if(guardias.Contains(guardia)){
                guardias.Remove(guardia);
                System.Console.WriteLine($"Se ha eliminado correctamente el cliente regular: {guardia.NombrePersona}");
            }
        }

        public void AgregarCajero(Cajero cajero){
            if(cajeros.Count == 0){
                cajeros.Add(cajero);
            }
            if(cajeros.Contains(cajero)){
                System.Console.WriteLine($"Ya existe en el sistema: {cajero.NombrePersona}");
            }
        }

        public void EliminarCajero(Cajero cajero){
            if(cajeros.Contains(cajero)){
                cajeros.Remove(cajero);
                System.Console.WriteLine($"Se ha eliminado correctamente el cliente regular: {cajero.NombrePersona}");
            }
        }

        public string NombreClinica{
            get{return nombreClinica;}
            set{this.nombreClinica = value;}
        }
        
        public string RutClinica{
            get{return rutClinica;}
            set{this.rutClinica = value;}
        }

        public string DireccionClinica{
            get{return direccionClinica;}
            set{this.direccionClinica = value;}
        }

        public string TelefonoClinica{
            get{return telefonoClinica;}
            set{this.telefonoClinica = value;}
        }

        public string CorreoClinica{
            get{return correoClinica;}
            set{this.correoClinica = value;}
        }

        public void MostrarInformacionClinica(){

        }
    }
}
