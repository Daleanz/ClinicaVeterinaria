using System;
using Generadores;
using Clientes;
using SaludAnimal;
using Trabajadores;
using Clinica;
using Productos;

namespace Main{
    using Clinica;
    public class Sistema{
        public static void Main(string[] args){
            ClienteRegular CR = new ClienteRegular("Jeison", "Salas", "15.306.099-1", "978296832", "3 anios", "3 veces al mes", "jeisondiansalascolomas@gmail.com", "San Javier, Don Jorge 790");
            Tratamiento T1 = new Tratamiento("Programa de Reduccion de Peso", "3 meses", 340000, 2);
            Tratamiento T2 = new Tratamiento("Dermatologia", "2 meses", 125000, 3);
            CR.AgregarTratamiento(T1);
            CR.AgregarTratamiento(T2);

            ComidaGato CG = new ComidaGato("Merkat", 12000, 2, "Cachorro");
            CR.ComprarProducto(CG, CG.CantidadProducto);

            ComidaPerro CP = new ComidaPerro("Master DOG", 25000, 2, "Adulto");
            CR.ComprarProducto(CP, CP.CantidadProducto);
            

            ClienteEmergencia CE = new ClienteEmergencia("Joaquin", "Soto", "19.239.394-2", "976728998", "urgente", "Talca, San Miguel", "joaquin123@gmail.com");
            Cirugia C1 = new Cirugia("Cirugia Cardiaca", 1200000, 3);
            CE.AgregarCirugia(C1);

           
            CR.MostrarInformacion();
            System.Console.WriteLine(" ");

            CE.MostrarInformacion(); 

            ClinicaVET Clinica1 = new ClinicaVET("Cuidamos Tu Animal", "76.896.992-7", "clinicatuanimal@gmail.cl", "Talca, Las Rastras 256", "776554676");

            Cajero Cajero1 = new Cajero("Alberto", "Huayaba", "17.309.266-5", "966543321", "8 meses", "alberto223@gmail.com", "Talca, San Miguel 278");
            Cajero1.GenerarBoleta(CR, Clinica1);
        }
    }
}
