using System;
using Generadores;
using Inventario;
using Clinica;

namespace Interfaces{
    interface ICajero{
        void VenderProducto(Bodega bodega, Producto producto, int cantidad);
        void GenerarBoleta(ICliente cliente, ClinicaVET clinica);
    }
}
