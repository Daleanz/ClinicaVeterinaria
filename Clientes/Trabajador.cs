using System;
using Generadores;

namespace Clientes{
    class Trabajador{ //puede ser un Cajero o Vendedor.
        //Atributos
        private string nombre;
        private int Identificación;
        private string cargo;

        //Constructor
        public Trabajador(string nombre,int id,string cargo){
            this.nombre = nombre;
            this.Identificación = id;
            this.cargo = cargo;
        }

        //Metodos get
        public string Nombre{
            get { return this.nombre; }
        }
        public int Identificacion{
            get { return this.Identificación; }
        }
        public string Cargo{
            get { return this.cargo; }
        }

        //Método set
        public void MostrarInformacion(){
            Console.WriteLine("Información del Trabajador");
            Console.WriteLine($"Trabajador: {this.nombre}\n"+
            $"Número de Identificación: {this.Identificación}\n"+
            $"Cargo: {this.cargo}\n");
        }
    }
}
