namespace BibliotecaApp.GUI
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnClientes = new Button();
            btnLibros = new Button();
            btnPrestamos = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(100, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(293, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Biblioteca";
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(150, 100);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(200, 40);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Gestión de Clientes";
            btnClientes.Click += btnClientes_Click;
            // 
            // btnLibros
            // 
            btnLibros.Location = new Point(150, 160);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(200, 40);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Gestión de Libros";
            btnLibros.Click += btnLibros_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Location = new Point(150, 220);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(200, 40);
            btnPrestamos.TabIndex = 3;
            btnPrestamos.Text = "Gestión de Préstamos";
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(lblTitulo);
            Controls.Add(btnClientes);
            Controls.Add(btnLibros);
            Controls.Add(btnPrestamos);
            Name = "FrmPrincipal";
            Text = "Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnClientes;
        private Button btnLibros;
        private Button btnPrestamos;
    }
}
