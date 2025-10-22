namespace Dominio
{
    // Clase que representa un resumen de disponibilidad de un libro en el sistema.
    // Se utiliza para mostrar información simplificada sobre la cantidad de ejemplares disponibles.
    public class LibroResumen
    {
        // Propiedad que referencia al objeto Libro asociado.
        public Libro Libro { get; set; }

        // Propiedad que indica la cantidad de ejemplares disponibles del libro.
        public int CantidadDisponible { get; set; }

        // Propiedad que genera una descripción textual del libro y su disponibilidad.
        // Ejemplo: "Cien años de soledad — 3 disponibles".
        public string Descripcion
        {
            get
            {
                return $"{Libro.Titulo} — {CantidadDisponible} disponibles";
            }
        }

        // Método sobrescrito que retorna la descripción generada.
        // Se utiliza para representar el objeto como texto en controles visuales.
        public override string ToString()
        {
            return Descripcion;
        }
    }
}

