using System;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Aplicacion;

namespace BibliotecaApp.GUI
{
    public partial class FrmPrestamo : Form
    {
        private IGestorPrestamos gestor = new GestorPrestamos();

        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            // Cargar clientes
            cmbClientes.DataSource = Datos.Clientes;
            cmbClientes.DisplayMember = "Nombre";

            // Cargar ejemplares disponibles
            ActualizarEjemplares();

            // Fechas por defecto
            dtpPrestamo.Value = DateTime.Today;
            dtpDevolucion.Value = DateTime.Today.AddDays(7);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var cliente = cmbClientes.SelectedItem as Cliente;
            var resumenSeleccionado = cmbEjemplares.SelectedItem as LibroResumen; 
            var fechaPrestamo = dtpPrestamo.Value;
            var fechaDevolucion = dtpDevolucion.Value;

            // Validaciones
            if (cliente == null || resumenSeleccionado == null)
            {
                MessageBox.Show("⚠️ Seleccione cliente y ejemplar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ejemplar = Datos.Ejemplares
                .FirstOrDefault(e => e.IdLibro == resumenSeleccionado.Libro.IdLibro && e.EstaDisponible());

            if (ejemplar == null)
            {
                MessageBox.Show("❌ No hay ejemplares disponibles para este libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear y registrar préstamo
            var prestamo = new Prestamo(fechaPrestamo, fechaDevolucion, ejemplar, cliente);
            gestor.RegistrarPrestamo(prestamo);
            Datos.Prestamos.Add(prestamo);

            // Mostrar en lista
            lstPrestamos.Items.Add(prestamo);
            ActualizarEjemplares();
        }


        private void btnDevolver_Click(object sender, EventArgs e)
        {
            var prestamoSeleccionado = lstPrestamos.SelectedItem as Prestamo;
            if (prestamoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un préstamo para devolver.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gestor.RegistrarDevolucion(prestamoSeleccionado);
            lstPrestamos.Items.Remove(prestamoSeleccionado);
            ActualizarEjemplares();
        }

        private void ActualizarEjemplares()
        {
            var librosConDisponibles = Datos.Libros
    .Where(libro => Datos.Ejemplares.Any(e => e.IdLibro == libro.IdLibro && e.EstaDisponible()))
    .Select(libro => new LibroResumen
    {
        Libro = libro,
        CantidadDisponible = Datos.Ejemplares.Count(e => e.IdLibro == libro.IdLibro && e.EstaDisponible())
    })
    .ToList();

            cmbEjemplares.DataSource = null;
            cmbEjemplares.DataSource = librosConDisponibles;
            cmbEjemplares.DisplayMember = "Descripcion";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
