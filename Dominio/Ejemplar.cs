using System;

namespace Dominio
{
    public class Ejemplar
    {
        public int IdEjemplar { get; set; }
        public int IdLibro { get; set; }
        public string Estado { get; set; } // Ej: "Disponible", "Prestado", "Dañado"

        // Referencia al objeto Libro (opcional, pero útil para visualización)
        public Libro Libro { get; set; }

        public Ejemplar(int idEjemplar, int idLibro, string estado)
        {
            IdEjemplar = idEjemplar;
            IdLibro = idLibro;
            Estado = estado;
        }

        public bool EstaDisponible()
        {
            return Estado == "Disponible";
        }

        // Propiedad para mostrar en ComboBox
        public string DescripcionCompleta
        {
            get
            {
                string titulo = Libro != null ? Libro.Titulo : $"ID {IdLibro}";
                return $"{titulo} — Ejemplar #{IdEjemplar} ({Estado})";
            }
        }

        public override string ToString()
        {
            return DescripcionCompleta;
        }
    }
}

