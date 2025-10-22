using Dominio;
using Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Crear catálogo de libros
        var libros = new List<Libro>
        {
            new Libro(1, "Cien años de soledad", "Gabriel García Márquez", "Sudamericana", "978-0307474728", 5),
        };

        // Crear ejemplares vinculados al libro con estado "Disponible"
        var ejemplares = new List<Ejemplar>();
        for (int i = 0; i < libros[0].Stock; i++)
        {
            ejemplares.Add(new Ejemplar(i + 1, libros[0].IdLibro, "Disponible"));
        }

        // Mostrar catálogo de ejemplares disponibles
        Console.WriteLine(" Catálogo de ejemplares disponibles:");
        foreach (var ej in ejemplares.Where(e => e.EstaDisponible()))
        {
            var libro = libros.FirstOrDefault(l => l.IdLibro == ej.IdLibro);
            if (libro != null)
            {
                Console.WriteLine($"ID: {ej.IdEjemplar} | Título: {libro.Titulo} | Autor: {libro.Autor}");
            }
        }

        // Selección de ejemplar
        Console.Write("\nIngrese el ID del ejemplar que desea prestar: ");
        string idSeleccionadoTexto = Console.ReadLine();

        if (!int.TryParse(idSeleccionadoTexto, out int idSeleccionado))
        {
            Console.WriteLine("❌ ID inválido.");
            return;
        }

        var ejemplarSeleccionado = ejemplares.FirstOrDefault(e => e.IdEjemplar == idSeleccionado && e.EstaDisponible());

        if (ejemplarSeleccionado != null)
        {
            var libro = libros.FirstOrDefault(l => l.IdLibro == ejemplarSeleccionado.IdLibro);
            var cliente = new Cliente("Denis Reyes", "1234567890", "0999999999");
            var prestamo = new Prestamo(DateTime.Today, DateTime.Today.AddDays(7), ejemplarSeleccionado, cliente);

            IGestorPrestamos gestor = new GestorPrestamos();
            gestor.RegistrarPrestamo(prestamo);

            // Cambiar estado del ejemplar
            ejemplarSeleccionado.Estado = "Prestado";

            Console.WriteLine($"\n✅ Préstamo registrado:");
            Console.WriteLine($"Ejemplar: {ejemplarSeleccionado.IdEjemplar}");
            Console.WriteLine($"Título: {libro?.Titulo}");
            Console.WriteLine($"Cliente: {cliente.Nombre}");
            Console.WriteLine($"Estado: {ejemplarSeleccionado.Estado}");

            // Registrar devolución
            gestor.RegistrarDevolucion(prestamo);
            ejemplarSeleccionado.Estado = "Disponible";

            Console.WriteLine($"\n🔄 Devolución registrada:");
            Console.WriteLine($"Ejemplar: {ejemplarSeleccionado.IdEjemplar}");
            Console.WriteLine($"Estado: {ejemplarSeleccionado.Estado}");
        }
        else
        {
            Console.WriteLine("❌ Ejemplar no disponible o no encontrado.");
        }
    }
}

