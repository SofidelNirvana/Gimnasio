namespace Gimnasio.Views
{
    partial class frmGestionMembresias
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
            cmbEstado = new ComboBox();
            numDuracion = new NumericUpDown();
            dgvMembresias = new DataGridView();
            IdMembresia = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            DuracionDias = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            lblEmail = new Label();
            lblEstado = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblDuracion = new Label();
            txtNombreMembresia = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnNuevo = new Button();
            grpDatos = new GroupBox();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembresias).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cmbEstado);
            grpDatos.Controls.Add(numDuracion);
            grpDatos.Controls.Add(dgvMembresias);
            grpDatos.Controls.Add(lblEmail);
            grpDatos.Controls.Add(lblEstado);
            grpDatos.Controls.Add(txtPrecio);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(lblDuracion);
            grpDatos.Controls.Add(txtNombreMembresia);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Dock = DockStyle.Top;
            grpDatos.Location = new Point(0, 0);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(800, 263);
            grpDatos.TabIndex = 13;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos ";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(556, 167);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(232, 23);
            cmbEstado.TabIndex = 12;
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(556, 79);
            numDuracion.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(232, 23);
            numDuracion.TabIndex = 11;
            numDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvMembresias
            // 
            dgvMembresias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresias.Columns.AddRange(new DataGridViewColumn[] { IdMembresia, Nombre, DuracionDias, Precio, Estado });
            dgvMembresias.Location = new Point(6, 17);
            dgvMembresias.Name = "dgvMembresias";
            dgvMembresias.Size = new Size(544, 240);
            dgvMembresias.TabIndex = 10;
            dgvMembresias.CellContentClick += dgvMembresias_CellContentClick;
            // 
            // IdMembresia
            // 
            IdMembresia.HeaderText = "IdMembresia";
            IdMembresia.Name = "IdMembresia";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // DuracionDias
            // 
            DuracionDias.HeaderText = "DuracionDias";
            DuracionDias.Name = "DuracionDias";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(556, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 15);
            lblEmail.TabIndex = 8;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(556, 149);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(556, 123);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(232, 23);
            txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(556, 105);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(556, 61);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(90, 15);
            lblDuracion.TabIndex = 2;
            lblDuracion.Text = "Duración (días):";
            // 
            // txtNombreMembresia
            // 
            txtNombreMembresia.Location = new Point(556, 35);
            txtNombreMembresia.Name = "txtNombreMembresia";
            txtNombreMembresia.Size = new Size(232, 23);
            txtNombreMembresia.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(556, 17);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(100, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(181, 349);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Editar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(19, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(100, 378);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(181, 378);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(19, 349);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmGestionMembresias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnNuevo);
            Controls.Add(grpDatos);
            Name = "frmGestionMembresias";
            Text = "frmGestionMembresias";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembresias).EndInit();
            ResumeLayout(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dgvMembresias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnNuevo;
        private Label lblNombre;
        private TextBox txtNombreMembresia;
        private Label lblDuracion;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblEstado;
        private Label lblEmail;
        private DataGridView dgvMembresias;
        private DataGridViewTextBoxColumn IdMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DuracionDias;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Estado;
        private NumericUpDown numDuracion;
        private ComboBox cmbEstado;
    }
}