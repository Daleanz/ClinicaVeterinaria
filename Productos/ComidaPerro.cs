using System;
using Generadores;

namespace Productos{
    class ComidaPerro : Producto{
        private string tipoComida;

        public ComidaPerro(string nombreProducto, double precioProducto, string tipoComida) : base(nombreProducto, precioProducto){
            this.tipoComida = tipoComida;
        }

        public string TipoComida{
            get{return tipoComida;}
            set{this.tipoComida = value;}
        }

        public override void MostrarInformacionProducto(){
            System.Console.WriteLine($"Informacion del Producto: {base.NombreProducto}");
            System.Console.WriteLine($"Tipo: {TipoComida}\n"+
                    $"Precio: ${base.PrecioProducto}");
        }
    }
}
