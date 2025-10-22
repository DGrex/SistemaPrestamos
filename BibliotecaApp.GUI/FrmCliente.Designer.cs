namespace BibliotecaApp.GUI
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.Load += new EventHandler(FrmCliente_Load);


            lblNombre = new Label();
            lblCedula = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtTelefono = new TextBox();
            btnRegistrar = new Button();
            lstClientes = new ListBox();
            label1 = new Label();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AccessibleName = "lblNombre";
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            lblCedula.AccessibleName = "lblCedula";
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(32, 121);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(55, 20);
            lblCedula.TabIndex = 1;
            lblCedula.Text = "Cedula";
            // 
            // lblTelefono
            // 
            lblTelefono.AccessibleName = "lblTelefono";
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(32, 157);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.AccessibleName = "txtNombre";
            txtNombre.Location = new Point(137, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtCedula
            // 
            txtCedula.AccessibleName = "txtCedula";
            txtCedula.Location = new Point(137, 118);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(125, 27);
            txtCedula.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.AccessibleName = "txtTelefono";
            txtTelefono.Location = new Point(137, 157);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AccessibleName = "btnRegistrar";
            btnRegistrar.Location = new Point(302, 121);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lstClientes
            // 
            lstClientes.AccessibleName = "lstClientes";
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(39, 216);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(584, 104);
            lstClientes.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 46);
            label1.TabIndex = 8;
            label1.Text = "Registrar Cliente";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(420, 123);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 450);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Controls.Add(lstClientes);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblCedula);
            Controls.Add(lblNombre);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblCedula;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtTelefono;
        private Button btnRegistrar;
        private ListBox lstClientes;
        private Label label1;
        private Button btnModificar;
    }
}