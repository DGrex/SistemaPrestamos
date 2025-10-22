using System;

namespace Dominio
{
    // Clase que representa un ejemplar físico de un libro dentro del sistema de préstamos.
    public class Ejemplar
    {
        // Identificador único del ejemplar.
        public int IdEjemplar { get; set; }

        // Identificador del libro al que pertenece el ejemplar.
        public int IdLibro { get; set; }

        // Estado actual del ejemplar. Ejemplos: "Disponible", "Prestado", "Dañado".
        public string Estado { get; set; }

        // Referencia al objeto Libro asociado. Es opcional, pero útil para mostrar información contextual.
        public Libro Libro { get; set; }

        // Constructor que inicializa un ejemplar con su identificador, el ID del libro y su estado.
        public Ejemplar(int idEjemplar, int idLibro, string estado)
        {
            IdEjemplar = idEjemplar;
            IdLibro = idLibro;
            Estado = estado;
        }

        // Método que indica si el ejemplar está disponible para préstamo.
        public bool EstaDisponible()
        {
            return Estado == "Disponible";
        }

        // Propiedad que genera una descripción completa del ejemplar.
        // Se utiliza comúnmente para mostrar en controles visuales como ComboBox.
        public string DescripcionCompleta
        {
            get
            {
                // Si el objeto Libro está disponible, se muestra su título.
                // En caso contrario, se muestra el ID del libro.
                string titulo = Libro != null ? Libro.Titulo : $"ID {IdLibro}";
                return $"{titulo} — Ejemplar #{IdEjemplar} ({Estado})";
            }
        }

        // Método sobrescrito que retorna la descripción completa del ejemplar.
        public override string ToString()
        {
            return DescripcionCompleta;
        }
    }
}

