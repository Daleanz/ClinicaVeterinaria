using System;
using Generadores;
using Clientes;
using SaludAnimal;

namespace Main{
    public class Sistema{
        public static void Main(string[] args){
            ClienteRegular CR = new ClienteRegular("Jeison", "Salas", "15.306.099-1", "978296832", "3 anios", "3 veces al mes", "jeisondiansalascolomas@gmail.com", "San Javier, Don Jorge 790");
            Tratamiento T1 = new Tratamiento("Programa de Reduccion de Peso", "3 meses", 340000);
            CR.AgregarTratamiento(T1);

            ClienteEmergencia CE = new ClienteEmergencia("Joaquin", "Soto", "19.239.394-2", "976728998", "urgente", "Talca, San Miguel", "joaquin123@gmail.com");
            Cirugia C1 = new Cirugia("Cirugia Cardiaca", 1200000);
            CE.AgregarCirugia(C1);

           
            CR.MostrarInformacion();
            System.Console.WriteLine(" ");

            CE.MostrarInformacion(); }
    }
}
