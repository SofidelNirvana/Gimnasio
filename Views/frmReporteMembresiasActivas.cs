using Gimnasio.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class frmReporteMembresiasActivas : Form
    {
        private GimnasioContext _context;

        public frmReporteMembresiasActivas()
        {
            InitializeComponent();
            _context = new GimnasioContext();
            ConfigurarFechas();
            CargarReporte();
        }

        private void ConfigurarFechas()
        {
            dtpFiltroInicio.Value = DateTime.Now.AddDays(-30);
            dtpFiltroFin.Value = DateTime.Now;
        }

        private void CargarReporte()
        {
            try
            {
                DateTime fechaInicio = dtpFiltroInicio.Value.Date;
                DateTime fechaFin = dtpFiltroFin.Value.Date.AddDays(1);

                var reporte = _context.Pagos
                    .Where(p => p.FechaPago >= fechaInicio && p.FechaPago < fechaFin)
                    .Select(p => new
                    {
                        p.IdPago,
                        Socio = p.Socio.Nombres + " " + p.Socio.Apellidos,
                        p.Socio.DNI,
                        Membresia = p.Membresia.Nombre,
                        FechaPago = p.FechaPago.ToShortDateString(),
                        FechaInicio = p.FechaInicio.ToShortDateString(),
                        FechaFin = p.FechaFin.ToShortDateString(),
                        Monto = p.Monto,
                        p.Estado
                    })
                    .OrderByDescending(p => p.FechaPago)
                    .ToList();

                dgvReporte.DataSource = reporte;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvReporte.Columns["IdPago"].HeaderText = "ID";
            dgvReporte.Columns["Socio"].HeaderText = "Socio";
            dgvReporte.Columns["DNI"].HeaderText = "DNI";
            dgvReporte.Columns["Membresia"].HeaderText = "Membresía";
            dgvReporte.Columns["FechaPago"].HeaderText = "Fecha Pago";
            dgvReporte.Columns["FechaInicio"].HeaderText = "Fecha Inicio";
            dgvReporte.Columns["FechaFin"].HeaderText = "Fecha Fin";
            dgvReporte.Columns["Monto"].HeaderText = "Monto";
            dgvReporte.Columns["Estado"].HeaderText = "Estado";

            dgvReporte.Columns["Monto"].DefaultCellStyle.Format = "N2";
            dgvReporte.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteMembresiasActivas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}