namespace BibliotecaApp.GUI
{
    partial class FrmPrestamo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCliente = new Label();
            cmbClientes = new ComboBox();
            lblEjemplar = new Label();
            cmbEjemplares = new ComboBox();
            lblFechaPrestamo = new Label();
            dtpPrestamo = new DateTimePicker();
            lblFechaDevolucion = new Label();
            dtpDevolucion = new DateTimePicker();
            btnRegistrar = new Button();
            btnDevolver = new Button();
            lstPrestamos = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 74);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // cmbClientes
            // 
            cmbClientes.Location = new Point(173, 66);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(200, 28);
            cmbClientes.TabIndex = 1;
            // 
            // lblEjemplar
            // 
            lblEjemplar.AutoSize = true;
            lblEjemplar.Location = new Point(12, 114);
            lblEjemplar.Name = "lblEjemplar";
            lblEjemplar.Size = new Size(142, 20);
            lblEjemplar.TabIndex = 2;
            lblEjemplar.Text = "Ejemplar disponible";
            // 
            // cmbEjemplares
            // 
            cmbEjemplares.Location = new Point(173, 114);
            cmbEjemplares.Name = "cmbEjemplares";
            cmbEjemplares.Size = new Size(396, 28);
            cmbEjemplares.TabIndex = 3;
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Location = new Point(12, 169);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(135, 20);
            lblFechaPrestamo.TabIndex = 4;
            lblFechaPrestamo.Text = "Fecha de préstamo";
            // 
            // dtpPrestamo
            // 
            dtpPrestamo.Location = new Point(173, 169);
            dtpPrestamo.Name = "dtpPrestamo";
            dtpPrestamo.Size = new Size(200, 27);
            dtpPrestamo.TabIndex = 5;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Location = new Point(12, 222);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(145, 20);
            lblFechaDevolucion.TabIndex = 6;
            lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.Location = new Point(173, 217);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(200, 27);
            dtpDevolucion.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(599, 104);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(174, 30);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar préstamo";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(599, 159);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(174, 30);
            btnDevolver.TabIndex = 9;
            btnDevolver.Text = "Registrar devolución";
            btnDevolver.Click += btnDevolver_Click;
            // 
            // lstPrestamos
            // 
            lstPrestamos.Location = new Point(73, 267);
            lstPrestamos.Name = "lstPrestamos";
            lstPrestamos.Size = new Size(470, 144);
            lstPrestamos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(223, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 46);
            label1.TabIndex = 11;
            label1.Text = "Prestamos";
            label1.Click += label1_Click;
            // 
            // FrmPrestamo
            // 
            ClientSize = new Size(825, 442);
            Controls.Add(label1);
            Controls.Add(lblCliente);
            Controls.Add(cmbClientes);
            Controls.Add(lblEjemplar);
            Controls.Add(cmbEjemplares);
            Controls.Add(lblFechaPrestamo);
            Controls.Add(dtpPrestamo);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(dtpDevolucion);
            Controls.Add(btnRegistrar);
            Controls.Add(btnDevolver);
            Controls.Add(lstPrestamos);
            Name = "FrmPrestamo";
            Text = "Gestión de Préstamos";
            Load += FrmPrestamo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private ComboBox cmbClientes;
        private Label lblEjemplar;
        private ComboBox cmbEjemplares;
        private Label lblFechaPrestamo;
        private DateTimePicker dtpPrestamo;
        private Label lblFechaDevolucion;
        private DateTimePicker dtpDevolucion;
        private Button btnRegistrar;
        private Button btnDevolver;
        private ListBox lstPrestamos;
        private Label label1;
    }
}
