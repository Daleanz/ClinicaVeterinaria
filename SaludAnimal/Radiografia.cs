using System;

namespace SaludAnimal{
    class Radiografia{
        private string tipoRadiografia;
        private double costoRadiografia;
        private int cantidadRadiografia;

        public Radiografia(string tipoRadiografia, double costoRadiografia, int cantidadRadiografia){
            this.tipoRadiografia = tipoRadiografia;
            this.costoRadiografia = costoRadiografia;
            this.cantidadRadiografia = cantidadRadiografia;
        }

        public int CantidadRadiografia{
            get{return cantidadRadiografia;}
            set{this.cantidadRadiografia = value;}
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
                    $"Costo: {CostoRadiografia}\n"+
                    $"Cantidad: {CantidadRadiografia}\n"+
                    $"Total: {CantidadRadiografia * CostoRadiografia}");
        }
    }
}
