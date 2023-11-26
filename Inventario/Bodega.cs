using System;
using Interfaces;
using Generadores;

namespace Inventario{
    class Bodega : IStock{
        private List<Producto> inventario;
        private int capacidadBodega;

        public Bodega(int capacidadBodega){
            this.capacidadBodega = capacidadBodega;
            this.inventario = new List<Producto>();
        }

        public int CapacidadBodega{
            get{return capacidadBodega;}
            set{this.capacidadBodega = value;}
        }

        public void AgregarProductoInventario(Producto producto){
            if(inventario.Count < capacidadBodega){
                inventario.Add(producto);
                capacidadBodega = capacidadBodega - 1;
                System.Console.WriteLine("Se agrego el siguiente producto a la bodega:");
                System.Console.WriteLine($"Nombre: {producto.NombreProducto}");
            }
            System.Console.WriteLine("El inventario esta lleno, no se pueden agregar mas productos.");

        }

        public void EliminarProductoInventario(Producto producto){
            if(inventario.Count != 0){
                if(inventario.Contains(producto)){
                    inventario.Remove(producto);
                    capacidadBodega = capacidadBodega + 1;
                }
                System.Console.WriteLine($"No se encontro el producto: {producto.NombreProducto}");
            }
            System.Console.WriteLine("La Bodega esta vacía.");
        }

        public int ObtenerCapacidadRestante(){
            return capacidadBodega;
        }
        public void MostrarInventario(){
            System.Console.WriteLine("Informacion de Inventario: ");
            foreach(Producto pro in inventario){
                System.Console.WriteLine($"{pro.NombreProducto}");
            }
        }
    }
}
