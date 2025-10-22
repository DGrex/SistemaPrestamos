using System;
using System.Windows.Forms;
using Dominio;

namespace BibliotecaApp.GUI
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("⚠️ Nombre y cédula son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cliente = new Cliente(nombre, cedula, telefono);
            Datos.Clientes.Add(cliente);

            //  lstClientes.Items.Add($"{cliente.Nombre} - {cliente.Cedula}-{cliente.Telefono}");
            lstClientes.Items.Add(cliente);

            LimpiarCampos();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clienteSeleccionado = lstClientes.SelectedItem as Cliente;
            if (clienteSeleccionado != null)
            {
                txtNombre.Text = clienteSeleccionado.Nombre;
                txtCedula.Text = clienteSeleccionado.Cedula;
                txtTelefono.Text = clienteSeleccionado.Telefono;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var clienteSeleccionado = lstClientes.SelectedItem as Cliente;
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("⚠️ Seleccione un cliente para modificar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoNombre = txtNombre.Text.Trim();
            string nuevaCedula = txtCedula.Text.Trim();
            string nuevoTelefono = txtTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nuevoNombre) || string.IsNullOrEmpty(nuevaCedula))
            {
                MessageBox.Show("⚠️ Nombre y cédula son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar datos
            clienteSeleccionado.Nombre = nuevoNombre;
            clienteSeleccionado.Cedula = nuevaCedula;
            clienteSeleccionado.Telefono = nuevoTelefono;

            // Refrescar lista
            int index = lstClientes.SelectedIndex;
            lstClientes.Items[index] = clienteSeleccionado;

            LimpiarCampos();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            lstClientes.Items.Clear(); // Limpia la lista visual
            foreach (var cliente in Datos.Clientes)
            {
                lstClientes.Items.Add(cliente); // Agrega cada cliente registrado
            }

            btnModificar.Enabled = true; 
        }



        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtTelefono.Text = "";
        }
    }
}
