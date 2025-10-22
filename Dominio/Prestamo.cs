using System;

namespace Dominio
{
    // Clase que representa un préstamo de un ejemplar a un cliente dentro del sistema.
    // Implementa la interfaz IEquatable<Prestamo> para permitir comparaciones entre préstamos.
    public class Prestamo : IEquatable<Prestamo>
    {
        // Fecha en la que se realiza el préstamo.
        public DateTime FechaPrestamo { get; set; }

        // Fecha prevista para la devolución del ejemplar.
        public DateTime FechaDevolucion { get; set; }

        // Referencia al ejemplar prestado.
        public Ejemplar Ejemplar { get; set; }

        // Referencia al cliente que realiza el préstamo.
        public Cliente Cliente { get; set; }

        // Constructor que inicializa todas las propiedades del préstamo.
        public Prestamo(DateTime fechaPrestamo, DateTime fechaDevolucion, Ejemplar ejemplar, Cliente cliente)
        {
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Ejemplar = ejemplar;
            Cliente = cliente;
        }

        // Método sobrescrito que retorna una representación textual del préstamo.
        // Incluye el ID del ejemplar, nombre del cliente y fechas de préstamo y devolución.
        public override string ToString()
        {
            return $"📖 Ejemplar {Ejemplar.IdEjemplar} | Cliente: {Cliente.Nombre} | {FechaPrestamo:dd/MM/yyyy} → {FechaDevolucion:dd/MM/yyyy}";
        }

        // Método que compara dos préstamos para determinar si son equivalentes.
        // La comparación se basa en el ejemplar, cliente y fechas involucradas.
        public bool Equals(Prestamo other)
        {
            if (other == null) return false;
            return Ejemplar.IdEjemplar == other.Ejemplar.IdEjemplar &&
                   Cliente.Cedula == other.Cliente.Cedula &&
                   FechaPrestamo == other.FechaPrestamo &&
                   FechaDevolucion == other.FechaDevolucion;
        }

        // Método sobrescrito que permite comparar el préstamo con otro objeto.
        // Internamente utiliza el método Equals específico de la clase.
        public override bool Equals(object obj)
        {
            return Equals(obj as Prestamo);
        }

        // Método sobrescrito que genera un código hash único para el préstamo.
        // Se utiliza en estructuras de datos que requieren comparación eficiente.
        public override int GetHashCode()
        {
            return HashCode.Combine(Ejemplar.IdEjemplar, Cliente.Cedula, FechaPrestamo, FechaDevolucion);
        }
    }
}

