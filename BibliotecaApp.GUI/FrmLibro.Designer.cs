namespace BibliotecaApp.GUI
{
    partial class FrmLibro
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
            lblAutor = new Label();
            lblEditorial = new Label();
            lblISBN = new Label();
            lblStock = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            txtISBN = new TextBox();
            txtStock = new TextBox();
            btnRegistrarLibro = new Button();
            lstLibros = new ListBox();
            label1 = new Label();
            btnModificarLibro = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(30, 69);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(30, 104);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(46, 20);
            lblAutor.TabIndex = 10;
            lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(30, 139);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(65, 20);
            lblEditorial.TabIndex = 9;
            lblEditorial.Text = "Editorial";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(30, 174);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 8;
            lblISBN.Text = "ISBN";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(26, 213);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(120, 66);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(200, 27);
            txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(120, 101);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(200, 27);
            txtAutor.TabIndex = 5;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(120, 136);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(200, 27);
            txtEditorial.TabIndex = 4;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(120, 171);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(200, 27);
            txtISBN.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(120, 206);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(200, 27);
            txtStock.TabIndex = 2;
            // 
            // btnRegistrarLibro
            // 
            btnRegistrarLibro.Location = new Point(411, 94);
            btnRegistrarLibro.Name = "btnRegistrarLibro";
            btnRegistrarLibro.Size = new Size(180, 30);
            btnRegistrarLibro.TabIndex = 1;
            btnRegistrarLibro.Text = "Registrar";
            btnRegistrarLibro.UseVisualStyleBackColor = true;
            btnRegistrarLibro.Click += btnRegistrarLibro_Click;
            // 
            // lstLibros
            // 
            lstLibros.FormattingEnabled = true;
            lstLibros.Location = new Point(30, 284);
            lstLibros.Name = "lstLibros";
            lstLibros.Size = new Size(840, 104);
            lstLibros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(219, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 46);
            label1.TabIndex = 12;
            label1.Text = "Registrar Libro";
            // 
            // btnModificarLibro
            // 
            btnModificarLibro.Location = new Point(411, 157);
            btnModificarLibro.Name = "btnModificarLibro";
            btnModificarLibro.Size = new Size(180, 29);
            btnModificarLibro.TabIndex = 13;
            btnModificarLibro.Text = "Modificar";
            btnModificarLibro.UseVisualStyleBackColor = true;
            btnModificarLibro.Click += btnModificarLibro_Click;
            // 
            // FrmLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 400);
            Controls.Add(btnModificarLibro);
            Controls.Add(label1);
            Controls.Add(lstLibros);
            Controls.Add(btnRegistrarLibro);
            Controls.Add(txtStock);
            Controls.Add(txtISBN);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblStock);
            Controls.Add(lblISBN);
            Controls.Add(lblEditorial);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Name = "FrmLibro";
            Text = "Gestión de Libros";
            Load += FrmLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAutor;
        private Label lblEditorial;
        private Label lblISBN;
        private Label lblStock;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private TextBox txtISBN;
        private TextBox txtStock;
        private Button btnRegistrarLibro;
        private ListBox lstLibros;
        private Label label1;
        private Button btnModificarLibro;
    }
}
