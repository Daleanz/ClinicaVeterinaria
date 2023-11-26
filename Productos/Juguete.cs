using System;
using Generadores;

namespace Productos{
    class Juguete : Producto{
        private string tipoJuguete;

        public Juguete(string nombreProducto, double precioProducto, string tipoJuguete) : base(nombreProducto, precioProducto){
            this.tipoJuguete = tipoJuguete;
        }

        public string TipoJuguete{
            get{return tipoJuguete;}
            set{this.tipoJuguete = value;}
        }

        public override void MostrarInformacionProducto(){
            System.Console.WriteLine($"Informacion del Producto: {base.NombreProducto}");
            System.Console.WriteLine($"Tipo: {TipoJuguete}\n"+
                    $"Precio: {base.PrecioProducto}");
        }
    }
}
