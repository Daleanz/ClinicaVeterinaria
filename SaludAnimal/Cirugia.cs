using System;

namespace SaludAnimal{
    class Cirugia{
        private string tipoCirugia;
        private double costoCirugia;
        private int cantidadCirugia;

        public Cirugia(string tipoCirugia, double costoCirugia, int cantidadCirugia){
            this.tipoCirugia = tipoCirugia;
            this.costoCirugia = costoCirugia;
            this.cantidadCirugia = cantidadCirugia;
        }

        public int CantidadCirugia{
            get{return cantidadCirugia;}
            set{this.cantidadCirugia = value;}
        }
        public string TipoCirugia{
            get{return tipoCirugia;}
            set{this.tipoCirugia = value;}
        }

        public double CostoCirugia{
            get{return costoCirugia;}
            set{this.costoCirugia = value;}
        }

        public void MostrarInformacionCirugia(){
            System.Console.WriteLine("Informacion Cirugia");
            System.Console.WriteLine($"Tipo: {TipoCirugia}\n"+
                    $"Costo: {CostoCirugia}\n"+
                    $"Cantidad: {CantidadCirugia}\n"+
                    $"Total: {CostoCirugia * CantidadCirugia}");
        }
    }
}
