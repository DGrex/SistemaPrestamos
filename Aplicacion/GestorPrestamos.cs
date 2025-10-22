using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacion
{
    public class GestorPrestamos : IGestorPrestamos
    {
        private static List<Prestamo> prestamos = new List<Prestamo>();

        public void RegistrarPrestamo(Prestamo prestamo)
        {
            if (prestamo != null && prestamo.Ejemplar.EstaDisponible())
            {
                prestamo.Ejemplar.Estado = "Prestado";
                prestamos.Add(prestamo);
            }
        }

        public void RegistrarDevolucion(Prestamo prestamo)
        {
            if (prestamo != null)
            {
                prestamo.Ejemplar.Estado = "Disponible";
            }
        }

        public List<Prestamo> ConsultarPrestamosPorCliente(string cedula)
        {
            return prestamos
                .Where(p => p.Cliente != null && p.Cliente.Cedula == cedula)
                .ToList();
        }
    }
}
