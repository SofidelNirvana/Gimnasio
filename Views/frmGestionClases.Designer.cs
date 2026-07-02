namespace Gimnasio.Views
{
    partial class frmGestionClases
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
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnNuevo = new Button();
            lblNombre = new Label();
            txtNombreClase = new TextBox();
            lblHorario = new Label();
            this.lblInstructor = new Label();
            this.txtInstructor = new TextBox();
            lblCupo = new Label();
            lblEstado = new Label();
            dgvClases = new DataGridView();
            txtHorario = new TextBox();
            numCupo = new NumericUpDown();
            cmbEstado = new ComboBox();
            IdClase = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Instructor = new DataGridViewTextBoxColumn();
            CupoMaximo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            grpDatos = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvClases).BeginInit();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCupo).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(100, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(181, 349);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Editar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(19, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(100, 378);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(181, 378);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(19, 349);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
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
            // txtNombreClase
            // 
            txtNombreClase.Location = new Point(556, 35);
            txtNombreClase.Name = "txtNombreClase";
            txtNombreClase.Size = new Size(232, 23);
            txtNombreClase.TabIndex = 1;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(556, 61);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(47, 15);
            lblHorario.TabIndex = 2;
            lblHorario.Text = "Horario";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new Point(556, 105);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new Size(58, 15);
            this.lblInstructor.TabIndex = 4;
            this.lblInstructor.Text = "Instructor";
            // 
            // txtInstructor
            // 
            this.txtInstructor.Location = new Point(556, 123);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new Size(232, 23);
            this.txtInstructor.TabIndex = 5;
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(556, 149);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(83, 15);
            lblCupo.TabIndex = 6;
            lblCupo.Text = "Cupo Maximo";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(556, 193);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado";
            // 
            // dgvClases
            // 
            dgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClases.Columns.AddRange(new DataGridViewColumn[] { IdClase, Nombre, Horario, Instructor, CupoMaximo, Estado });
            dgvClases.Location = new Point(6, 17);
            dgvClases.Name = "dgvClases";
            dgvClases.Size = new Size(544, 240);
            dgvClases.TabIndex = 10;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cmbEstado);
            grpDatos.Controls.Add(numCupo);
            grpDatos.Controls.Add(txtHorario);
            grpDatos.Controls.Add(dgvClases);
            grpDatos.Controls.Add(lblEstado);
            grpDatos.Controls.Add(lblCupo);
            grpDatos.Controls.Add(this.txtInstructor);
            grpDatos.Controls.Add(this.lblInstructor);
            grpDatos.Controls.Add(lblHorario);
            grpDatos.Controls.Add(txtNombreClase);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Dock = DockStyle.Top;
            grpDatos.Location = new Point(0, 0);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(800, 263);
            grpDatos.TabIndex = 13;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos ";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(556, 79);
            txtHorario.Name = "txtHorario";
            txtHorario.PlaceholderText = "Ej: Lunes-Miércoles-Viernes 8:00-9:00";
            txtHorario.Size = new Size(232, 23);
            txtHorario.TabIndex = 11;
            // 
            // numCupo
            // 
            numCupo.Location = new Point(556, 167);
            numCupo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCupo.Name = "numCupo";
            numCupo.Size = new Size(232, 23);
            numCupo.TabIndex = 12;
            numCupo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(556, 211);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(232, 23);
            cmbEstado.TabIndex = 13;
            // 
            // IdClase
            // 
            IdClase.HeaderText = "IdClase";
            IdClase.Name = "IdClase";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Horario
            // 
            Horario.HeaderText = "Horario";
            Horario.Name = "Horario";
            // 
            // Instructor
            // 
            Instructor.HeaderText = "Instructor";
            Instructor.Name = "Instructor";
            // 
            // CupoMaximo
            // 
            CupoMaximo.HeaderText = "CupoMaximo";
            CupoMaximo.Name = "CupoMaximo";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // frmGestionClases
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
            Name = "frmGestionClases";
            Text = "frmGestionClases";
            ((System.ComponentModel.ISupportInitialize)dgvClases).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCupo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnNuevo;
        private Label lblNombre;
        private TextBox txtNombreClase;
        private Label lblHorario;
        private Label lblInstructor;
        private TextBox txtInstructor;
        private TextBox txtApellidos;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblCupo;
        private Label lblEstado;
        private TextBox txtEmail;
        private DataGridView dgvClases;
        private TextBox txtHorario;
        private NumericUpDown numCupo;
        private ComboBox cmbEstado;
        private DataGridViewTextBoxColumn IdClase;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn CupoMaximo;
        private DataGridViewTextBoxColumn Estado;
    }
}