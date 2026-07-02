namespace Gimnasio.Views
{
    partial class frmGestionSocios
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
            GroupBox grpDatos;
            dgvSocios = new DataGridView();
            IdSocio = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtApellidos = new TextBox();
            lblApellidos = new Label();
            txtNombres = new TextBox();
            lblNombres = new Label();
            btnNuevo = new Button();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            lblBuscar = new Label();
            txtBuscarDNI = new TextBox();
            grpDatos = new GroupBox();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(dgvSocios);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(lblEmail);
            grpDatos.Controls.Add(txtTelefono);
            grpDatos.Controls.Add(lblTelefono);
            grpDatos.Controls.Add(txtDNI);
            grpDatos.Controls.Add(lblDNI);
            grpDatos.Controls.Add(txtApellidos);
            grpDatos.Controls.Add(lblApellidos);
            grpDatos.Controls.Add(txtNombres);
            grpDatos.Controls.Add(lblNombres);
            grpDatos.Dock = DockStyle.Top;
            grpDatos.Location = new Point(0, 0);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(800, 263);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos ";
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { IdSocio, Nombres, Apellidos, DNI, Telefono, Email, FechaRegistro, Estado });
            dgvSocios.Location = new Point(6, 17);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.Size = new Size(544, 240);
            dgvSocios.TabIndex = 10;
            dgvSocios.CellContentClick += dgvSocios_CellContentClick;
            // 
            // IdSocio
            // 
            IdSocio.HeaderText = "IdSocio";
            IdSocio.Name = "IdSocio";
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            // 
            // DNI
            // 
            DNI.HeaderText = "Cedula";
            DNI.Name = "DNI";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(556, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(556, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(556, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(232, 23);
            txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(556, 149);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefonos";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(556, 123);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(232, 23);
            txtDNI.TabIndex = 5;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(556, 105);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(44, 15);
            lblDNI.TabIndex = 4;
            lblDNI.Text = "Cedula";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(556, 79);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(232, 23);
            txtApellidos.TabIndex = 3;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(556, 61);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(556, 35);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(232, 23);
            txtNombres.TabIndex = 1;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(556, 17);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(56, 15);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(19, 300);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(181, 329);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(100, 329);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(19, 329);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(181, 300);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Editar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(100, 300);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(370, 300);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(106, 15);
            lblBuscar.TabIndex = 11;
            lblBuscar.Text = "Buscar por Cedula:";
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Location = new Point(370, 329);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(180, 23);
            txtBuscarDNI.TabIndex = 12;
            // 
            // frmGestionSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscarDNI);
            Controls.Add(lblBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnNuevo);
            Controls.Add(grpDatos);
            Name = "frmGestionSocios";
            Text = "frmGestionSocios";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtApellidos;
        private Label lblApellidos;
        private TextBox txtNombres;
        private Label lblNombres;
        private DataGridView dgvSocios;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDNI;
        private Label lblDNI;
        private DataGridViewTextBoxColumn IdSocio;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estado;
        private Button btnNuevo;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Label lblBuscar;
        private TextBox txtBuscarDNI;
    }
}