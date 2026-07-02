namespace Gimnasio.Views
{
    partial class frmRegistroPagos
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
            grpSocio = new GroupBox();
            txtDNISocio = new TextBox();
            lblDNI = new Label();
            cmbSocios = new ComboBox();
            lblSocio = new Label();
            grpMembresia = new GroupBox();
            lblDuracion = new Label();
            txtDuracionMembresia = new TextBox();
            txtPrecioMembresia = new TextBox();
            lblPrecio = new Label();
            cmbMembresias = new ComboBox();
            lblMembresia = new Label();
            grpPago = new GroupBox();
            txtMonto = new TextBox();
            lblMonto = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaPago = new DateTimePicker();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            lblFechaPago = new Label();
            dgvPagos = new DataGridView();
            IdPago = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            Membresia = new DataGridViewTextBoxColumn();
            FechaPago = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnReporte = new Button();
            grpSocio.SuspendLayout();
            grpMembresia.SuspendLayout();
            grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // grpSocio
            // 
            grpSocio.Controls.Add(txtDNISocio);
            grpSocio.Controls.Add(lblDNI);
            grpSocio.Controls.Add(cmbSocios);
            grpSocio.Controls.Add(lblSocio);
            grpSocio.Location = new Point(2, 1);
            grpSocio.Name = "grpSocio";
            grpSocio.Size = new Size(253, 201);
            grpSocio.TabIndex = 0;
            grpSocio.TabStop = false;
            grpSocio.Text = "Seleccion de Socio";
            // 
            // txtDNISocio
            // 
            txtDNISocio.Location = new Point(6, 81);
            txtDNISocio.Name = "txtDNISocio";
            txtDNISocio.ReadOnly = true;
            txtDNISocio.Size = new Size(211, 23);
            txtDNISocio.TabIndex = 3;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(6, 63);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(44, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "Cedula";
            // 
            // cmbSocios
            // 
            cmbSocios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSocios.FormattingEnabled = true;
            cmbSocios.Location = new Point(6, 37);
            cmbSocios.Name = "cmbSocios";
            cmbSocios.Size = new Size(211, 23);
            cmbSocios.TabIndex = 1;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(6, 19);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(36, 15);
            lblSocio.TabIndex = 0;
            lblSocio.Text = "Socio";
            // 
            // grpMembresia
            // 
            grpMembresia.Controls.Add(lblDuracion);
            grpMembresia.Controls.Add(txtDuracionMembresia);
            grpMembresia.Controls.Add(txtPrecioMembresia);
            grpMembresia.Controls.Add(lblPrecio);
            grpMembresia.Controls.Add(cmbMembresias);
            grpMembresia.Controls.Add(lblMembresia);
            grpMembresia.Location = new Point(261, 1);
            grpMembresia.Name = "grpMembresia";
            grpMembresia.Size = new Size(253, 201);
            grpMembresia.TabIndex = 4;
            grpMembresia.TabStop = false;
            grpMembresia.Text = "Selección de Membresía";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(6, 107);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(55, 15);
            lblDuracion.TabIndex = 5;
            lblDuracion.Text = "Duración";
            // 
            // txtDuracionMembresia
            // 
            txtDuracionMembresia.Location = new Point(6, 125);
            txtDuracionMembresia.Name = "txtDuracionMembresia";
            txtDuracionMembresia.ReadOnly = true;
            txtDuracionMembresia.Size = new Size(211, 23);
            txtDuracionMembresia.TabIndex = 4;
            txtDuracionMembresia.TextChanged += txtDuracionMembresia_TextChanged;
            // 
            // txtPrecioMembresia
            // 
            txtPrecioMembresia.Location = new Point(6, 81);
            txtPrecioMembresia.Name = "txtPrecioMembresia";
            txtPrecioMembresia.ReadOnly = true;
            txtPrecioMembresia.Size = new Size(211, 23);
            txtPrecioMembresia.TabIndex = 3;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(6, 63);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // cmbMembresias
            // 
            cmbMembresias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembresias.FormattingEnabled = true;
            cmbMembresias.Location = new Point(6, 37);
            cmbMembresias.Name = "cmbMembresias";
            cmbMembresias.Size = new Size(211, 23);
            cmbMembresias.TabIndex = 1;
            // 
            // lblMembresia
            // 
            lblMembresia.AutoSize = true;
            lblMembresia.Location = new Point(6, 19);
            lblMembresia.Name = "lblMembresia";
            lblMembresia.Size = new Size(66, 15);
            lblMembresia.TabIndex = 0;
            lblMembresia.Text = "Membresía";
            // 
            // grpPago
            // 
            grpPago.Controls.Add(txtMonto);
            grpPago.Controls.Add(lblMonto);
            grpPago.Controls.Add(dtpFechaFin);
            grpPago.Controls.Add(dtpFechaInicio);
            grpPago.Controls.Add(dtpFechaPago);
            grpPago.Controls.Add(lblFechaFin);
            grpPago.Controls.Add(lblFechaInicio);
            grpPago.Controls.Add(lblFechaPago);
            grpPago.Location = new Point(523, 1);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(265, 201);
            grpPago.TabIndex = 6;
            grpPago.TabStop = false;
            grpPago.Text = "Detalles del Pago";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(6, 169);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(200, 23);
            txtMonto.TabIndex = 10;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(6, 151);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 9;
            lblMonto.Text = "Monto";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(6, 125);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 23);
            dtpFechaFin.TabIndex = 8;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(6, 81);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 23);
            dtpFechaInicio.TabIndex = 7;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(6, 37);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(200, 23);
            dtpFechaPago.TabIndex = 6;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(6, 107);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(57, 15);
            lblFechaFin.TabIndex = 5;
            lblFechaFin.Text = "Fecha Fin";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(6, 63);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(70, 15);
            lblFechaInicio.TabIndex = 2;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(6, 19);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(84, 15);
            lblFechaPago.TabIndex = 0;
            lblFechaPago.Text = "Fecha de Pago";
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { IdPago, Socio, Membresia, FechaPago, Monto, FechaInicio, FechaFin, Estado });
            dgvPagos.Location = new Point(2, 208);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.Size = new Size(786, 150);
            dgvPagos.TabIndex = 7;
            dgvPagos.CellContentClick += dgvPagos_CellContentClick;
            // 
            // IdPago
            // 
            IdPago.HeaderText = "IdPago";
            IdPago.Name = "IdPago";
            // 
            // Socio
            // 
            Socio.HeaderText = "Socio";
            Socio.Name = "Socio";
            // 
            // Membresia
            // 
            Membresia.HeaderText = "Membresia";
            Membresia.Name = "Membresia";
            // 
            // FechaPago
            // 
            FechaPago.HeaderText = "FechaPago";
            FechaPago.Name = "FechaPago";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // FechaInicio
            // 
            FechaInicio.HeaderText = "FechaInicio";
            FechaInicio.Name = "FechaInicio";
            // 
            // FechaFin
            // 
            FechaFin.HeaderText = "FechaFin";
            FechaFin.Name = "FechaFin";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(8, 396);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 23);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar Pago";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(108, 396);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(189, 396);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(75, 23);
            btnReporte.TabIndex = 10;
            btnReporte.Text = "Ver Reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // frmRegistroPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReporte);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvPagos);
            Controls.Add(grpPago);
            Controls.Add(grpMembresia);
            Controls.Add(grpSocio);
            Name = "frmRegistroPagos";
            Text = "frmRegistroPagos";
            Load += frmRegistroPagos_Load;
            grpSocio.ResumeLayout(false);
            grpSocio.PerformLayout();
            grpMembresia.ResumeLayout(false);
            grpMembresia.PerformLayout();
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
        }

        private void frmRegistroPagos_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtDuracionMembresia_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox grpSocio;
        private TextBox txtDNISocio;
        private Label lblDNI;
        private ComboBox cmbSocios;
        private Label lblSocio;
        private GroupBox grpMembresia;
        private Label lblDuracion;
        private TextBox txtDuracionMembresia;
        private TextBox txtPrecioMembresia;
        private Label lblPrecio;
        private ComboBox cmbMembresias;
        private Label lblMembresia;
        private GroupBox grpPago;
        private TextBox txtMonto;
        private Label lblMonto;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaPago;
        private Label lblFechaFin;
        private Label lblFechaInicio;
        private Label lblFechaPago;
        private DataGridView dgvPagos;
        private DataGridViewTextBoxColumn IdPago;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn Membresia;
        private DataGridViewTextBoxColumn FechaPago;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Estado;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnReporte;
    }
}