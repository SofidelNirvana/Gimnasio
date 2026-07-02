namespace Gimnasio.Views
{
    partial class frmReporteMembresiasActivas
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
            GroupBox grpFiltros;
            btnFiltrar = new Button();
            dtpFiltroFin = new DateTimePicker();
            dtpFiltroInicio = new DateTimePicker();
            dgvReporte = new DataGridView();
            IdPago = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Membresia = new DataGridViewTextBoxColumn();
            FechaPago = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            btnCerrar = new Button();
            grpFiltros = new GroupBox();
            grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(btnFiltrar);
            grpFiltros.Controls.Add(dtpFiltroFin);
            grpFiltros.Controls.Add(dtpFiltroInicio);
            grpFiltros.Controls.Add(dgvReporte);
            grpFiltros.Controls.Add(lblFechaFin);
            grpFiltros.Controls.Add(lblFechaInicio);
            grpFiltros.Dock = DockStyle.Top;
            grpFiltros.Location = new Point(0, 0);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(800, 263);
            grpFiltros.TabIndex = 13;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(633, 157);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpFiltroFin
            // 
            dtpFiltroFin.Format = DateTimePickerFormat.Short;
            dtpFiltroFin.Location = new Point(556, 79);
            dtpFiltroFin.Name = "dtpFiltroFin";
            dtpFiltroFin.Size = new Size(232, 23);
            dtpFiltroFin.TabIndex = 12;
            // 
            // dtpFiltroInicio
            // 
            dtpFiltroInicio.Format = DateTimePickerFormat.Short;
            dtpFiltroInicio.Location = new Point(556, 35);
            dtpFiltroInicio.Name = "dtpFiltroInicio";
            dtpFiltroInicio.Size = new Size(232, 23);
            dtpFiltroInicio.TabIndex = 11;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Columns.AddRange(new DataGridViewColumn[] { IdPago, Socio, DNI, Membresia, FechaPago, FechaInicio, FechaFin, Monto, Estado });
            dgvReporte.Location = new Point(6, 17);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.Size = new Size(544, 240);
            dgvReporte.TabIndex = 10;
            dgvReporte.CellContentClick += dgvReporte_CellContentClick;
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
            // DNI
            // 
            DNI.HeaderText = "Cedula";
            DNI.Name = "DNI";
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
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(556, 61);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(57, 15);
            lblFechaFin.TabIndex = 2;
            lblFechaFin.Text = "Fecha Fin";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(556, 17);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(70, 15);
            lblFechaInicio.TabIndex = 0;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(19, 349);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmReporteMembresiasActivas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(grpFiltros);
            Name = "frmReporteMembresiasActivas";
            Text = "frmReporteMembresiasActivas";
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private DataGridView dgvReporte;
        private Label lblFechaFin;
        private Label lblFechaInicio;
        private DateTimePicker dtpFiltroInicio;
        private Button btnFiltrar;
        private DateTimePicker dtpFiltroFin;
        private DataGridViewTextBoxColumn IdPago;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Membresia;
        private DataGridViewTextBoxColumn FechaPago;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Estado;
    }
}