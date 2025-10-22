using System;
using System.Windows.Forms;
using Dominio;

namespace BibliotecaApp.GUI
{
    public partial class FrmLibro : Form
    {
        public FrmLibro()
        {
            InitializeComponent();
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            lstLibros.Items.Clear(); // Limpia la lista visual

            foreach (var libro in Datos.Libros)
            {
                lstLibros.Items.Add(libro); // ✅ Correcto

                //lstLibros.Items.Add(libro.ToString()); // Muestra cada libro registrado
            }
        }


        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string editorial = txtEditorial.Text.Trim();
            string isbn = txtISBN.Text.Trim();
            string stockTexto = txtStock.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("⚠️ Título e ISBN son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(stockTexto, out int stock) || stock < 1)
            {
                MessageBox.Show("⚠️ El stock debe ser un número entero positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nuevoIdLibro = Datos.GenerarIdLibro();
            var libro = new Libro(nuevoIdLibro, titulo, autor, editorial, isbn, stock);
            Datos.Libros.Add(libro);

            // Generar ejemplares automáticamente
            for (int i = 0; i < stock; i++)
            {
                int nuevoIdEjemplar = Datos.GenerarIdEjemplar();
                var ejemplar = new Ejemplar(nuevoIdEjemplar, nuevoIdLibro, "Disponible");
                Datos.Ejemplares.Add(ejemplar);
            }
            lstLibros.Items.Add(libro);
            //lstLibros.Items.Add(libro.ToString());
            LimpiarCampos();
        }




        private void LimpiarCampos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtISBN.Text = "";
            txtStock.Text = "";

            //btnRegistrarLibro.Enabled = true;
            //btnModificarLibro.Enabled = false;
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            var libroSeleccionado = lstLibros.SelectedItem as Libro;
            if (libroSeleccionado == null)
            {
                MessageBox.Show("⚠️ Seleccione un libro para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoTitulo = txtTitulo.Text.Trim();
            string nuevoAutor = txtAutor.Text.Trim();
            string nuevaEditorial = txtEditorial.Text.Trim();
            string nuevoISBN = txtISBN.Text.Trim();
            string stockTexto = txtStock.Text.Trim();

            if (string.IsNullOrEmpty(nuevoTitulo) || string.IsNullOrEmpty(nuevoISBN))
            {
                MessageBox.Show("⚠️ Título e ISBN son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(stockTexto, out int nuevoStock) || nuevoStock < 1)
            {
                MessageBox.Show("⚠️ El stock debe ser un número entero positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar datos
            libroSeleccionado.Titulo = nuevoTitulo;
            libroSeleccionado.Autor = nuevoAutor;
            libroSeleccionado.Editorial = nuevaEditorial;
            libroSeleccionado.ISBN = nuevoISBN;
            libroSeleccionado.Stock = nuevoStock;

            // Refrescar lista
            int index = lstLibros.SelectedIndex;
            lstLibros.Items[index] = libroSeleccionado;

            LimpiarCampos();
        }


    }
}
