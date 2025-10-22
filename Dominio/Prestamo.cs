using System;

namespace Dominio
{
    public class Prestamo : IEquatable<Prestamo>
    {
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Ejemplar Ejemplar { get; set; }
        public Cliente Cliente { get; set; }

        public Prestamo(DateTime fechaPrestamo, DateTime fechaDevolucion, Ejemplar ejemplar, Cliente cliente)
        {
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Ejemplar = ejemplar;
            Cliente = cliente;
        }

        public override string ToString()
        {
            return $"📖 Ejemplar {Ejemplar.IdEjemplar} | Cliente: {Cliente.Nombre} | {FechaPrestamo:dd/MM/yyyy} → {FechaDevolucion:dd/MM/yyyy}";
        }

        public bool Equals(Prestamo other)
        {
            if (other == null) return false;
            return Ejemplar.IdEjemplar == other.Ejemplar.IdEjemplar &&
                   Cliente.Cedula == other.Cliente.Cedula &&
                   FechaPrestamo == other.FechaPrestamo &&
                   FechaDevolucion == other.FechaDevolucion;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Prestamo);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Ejemplar.IdEjemplar, Cliente.Cedula, FechaPrestamo, FechaDevolucion);
        }
    }
}
