namespace Dominio
{
    public class LibroResumen
    {
        public Libro Libro { get; set; }
        public int CantidadDisponible { get; set; }

        public string Descripcion
        {
            get
            {
                return $"{Libro.Titulo} — {CantidadDisponible} disponibles";
            }
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
