namespace Dominio
{
    // Clase que representa un libro dentro del sistema de préstamos.
    // Contiene información bibliográfica y de inventario asociada al libro.
    public class Libro
    {
        // Identificador único del libro en el sistema.
        public int IdLibro { get; set; }

        // Título del libro.
        public string Titulo { get; set; }

        // Nombre del autor del libro.
        public string Autor { get; set; }

        // Nombre de la editorial que publicó el libro.
        public string Editorial { get; set; }

        // Código ISBN del libro, utilizado para identificación internacional.
        public string ISBN { get; set; }

        // Cantidad total de ejemplares disponibles en inventario.
        public int Stock { get; set; }

        // Constructor que inicializa todas las propiedades del libro.
        public Libro(int idLibro, string titulo, string autor, string editorial, string isbn, int stock)
        {
            IdLibro = idLibro;
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            ISBN = isbn;
            Stock = stock;
        }

        // Método sobrescrito que retorna una representación textual del libro.
        // Incluye ID, título, autor, editorial, ISBN y cantidad en stock.
        public override string ToString()
        {
            return $"{IdLibro}: {Titulo} - {Autor} ({Editorial}) | ISBN: {ISBN} | Stock: {Stock}";
        }
    }
}
