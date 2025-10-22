namespace Dominio
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string ISBN { get; set; }
        public int Stock { get; set; }

        public Libro(int idLibro, string titulo, string autor, string editorial, string isbn, int stock)
        {
            IdLibro = idLibro;
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            ISBN = isbn;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{IdLibro}: {Titulo} - {Autor} ({Editorial}) | ISBN: {ISBN} | Stock: {Stock}";
        }
    }
}


