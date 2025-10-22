using System;
using System.Windows.Forms;

namespace BibliotecaApp.GUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Inicialización opcional
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FrmLibro frm = new FrmLibro();
            frm.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamo frm= new FrmPrestamo();
            frm.ShowDialog();
        }
    }
}
