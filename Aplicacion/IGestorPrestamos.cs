using Dominio;
using System.Collections.Generic;

namespace Aplicacion
{
    public interface IGestorPrestamos
    {
        void RegistrarPrestamo(Prestamo prestamo);
        void RegistrarDevolucion(Prestamo prestamo);
        List<Prestamo> ConsultarPrestamosPorCliente(string cedula);
    }
}


