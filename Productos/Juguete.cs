using System;
using Generadores;

namespace Productos{
    class Juguete : Producto{
        private string tipoJuguete;

        public Juguete(string nombreProducto, double precioProducto, int cantidadProducto, string tipoJuguete) : base(nombreProducto, precioProducto, cantidadProducto){
            this.tipoJuguete = tipoJuguete;
        }

        public string TipoJuguete{
            get{return tipoJuguete;}
            set{this.tipoJuguete = value;}
        }

        public override void MostrarInformacionProducto(){
            System.Console.WriteLine($"Informacion del Producto: {base.NombreProducto}");
            System.Console.WriteLine($"Tipo: {TipoJuguete}\n"+
                    $"Precio: {base.PrecioProducto}\n"+
                    $"Cantidad: {base.CantidadProducto}");
        }
    }
}
