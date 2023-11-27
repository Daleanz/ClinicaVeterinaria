using System;
using SaludAnimal;
using Productos;
using Generadores;

namespace Interfaces{
    interface ICliente{
        List<Producto> ObtenerCompras{get;}
        List<Tratamiento> ObtenerTratamientos{get;}
        List<Radiografia> ObtenerRadiografias{get;}
        List<Cirugia> ObtenerCirugias{get;}

        string NombrePersona{get; set;}
        string ApellidoPersona{get; set;}
        string RutPersona{get; set;}
        string TelefonoPersona{get; set;}

        void MostrarInformacion();
    }
}
