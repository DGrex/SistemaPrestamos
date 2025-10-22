using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace BibliotecaApp.GUI
{
    public static class Datos
    {
        // Listas principales
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<Libro> Libros = new List<Libro>();
        public static List<Ejemplar> Ejemplares = new List<Ejemplar>();
        public static List<Prestamo> Prestamos = new List<Prestamo>();

        // Contadores de ID
        private static int contadorIdCliente = 1;
        private static int contadorIdLibro = 1;
        private static int contadorIdEjemplar = 1;

        // Generadores de ID únicos
        public static int GenerarIdCliente() => contadorIdCliente++;
        public static int GenerarIdLibro() => contadorIdLibro++;
        public static int GenerarIdEjemplar() => contadorIdEjemplar++;
    }
}
