using System;

namespace SaludAnimal{
    class Tratamiento{
        private string tipoTratamiento;
        private string duracionTratamiento;
        private double costoTratamiento;
        private int cantidadTratamiento;

        public Tratamiento(string tipoTratamiento, string duracionTratamiento, double costoTratamiento, int cantidadTratamiento){
            this.tipoTratamiento = tipoTratamiento;
            this.duracionTratamiento = duracionTratamiento;
            this.costoTratamiento = costoTratamiento;
            this.cantidadTratamiento = cantidadTratamiento;
        }

        public int CantidadTratamiento{
            get{return cantidadTratamiento;}
            set{this.cantidadTratamiento = value;}
        }

        public string TipoTratamiento{
            get{return tipoTratamiento;}
            set{this.tipoTratamiento = value;}
        }

        public string DuracionTratamiento{
            get{return duracionTratamiento;}
            set{this.duracionTratamiento = value;}
        }

        public double CostoTratamiento{
            get{return costoTratamiento;}
            set{this.costoTratamiento = value;}
        }

        public void MostrarInformacionTratamiento(){
            System.Console.WriteLine("Informacion Tratamiento");
            System.Console.WriteLine($"Tipo: {TipoTratamiento}\n"+
                    $"Duracion: {DuracionTratamiento}\n"+
                    $"Costo: ${CostoTratamiento}\n"+
                    $"Cantidad: {CantidadTratamiento}\n"+
                    $"Total: {CantidadTratamiento * CostoTratamiento}");
        }
    }
}
