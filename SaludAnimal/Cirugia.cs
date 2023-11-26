using System;

namespace SaludAnimal{
    class Cirugia{
        private string tipoCirugia;
        private double costoCirugia;

        public Cirugia(string tipoCirugia, double costoCirugia){
            this.tipoCirugia = tipoCirugia;
            this.costoCirugia = costoCirugia;
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
                    $"Costo: {CostoCirugia}");
        }
    }
}
