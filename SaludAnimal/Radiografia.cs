using System;

namespace SaludAnimal{
    class Radiografia{
        private string tipoRadiografia;
        private double costoRadiografia;

        public Radiografia(string tipoRadiografia, double costoRadiografia){
            this.tipoRadiografia = tipoRadiografia;
            this.costoRadiografia = costoRadiografia;
        }

        public string TipoRadiografia{
            get{return tipoRadiografia;}
            set{this.tipoRadiografia = value;}
        }

        public double CostoRadiografia{
            get{return costoRadiografia;}
            set{this.costoRadiografia = value;}
        }

        public void MostrarInformacionRadiografia(){
            System.Console.WriteLine("Informacion Radiografia");
            System.Console.WriteLine($"Tipo: {TipoRadiografia}\n"+
                    $"Costo: {CostoRadiografia}");
        }
    }
}
