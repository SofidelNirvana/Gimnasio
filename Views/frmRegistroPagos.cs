using Gimnasio.Data;
using Gimnasio.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class frmRegistroPagos : Form
    {
        private GimnasioContext _context;

        public frmRegistroPagos()
        {
            InitializeComponent();
            _context = new GimnasioContext();
            CargarCombos();
            CargarPagos();
            ConfigurarFechas();
        }

        private void CargarCombos()
        {
            try
            {
                // Cargar socios
                var socios = _context.Socios.Where(s => s.Estado).ToList();
                cmbSocios.DataSource = socios;
                cmbSocios.DisplayMember = "Nombres";
                cmbSocios.ValueMember = "IdSocio";
                cmbSocios.SelectedIndex = -1;

                // Cargar membresías
                var membresias = _context.Membresias.Where(m => m.Estado).ToList();
                cmbMembresias.DataSource = membresias;
                cmbMembresias.DisplayMember = "Nombre";
                cmbMembresias.ValueMember = "IdMembresia";
                cmbMembresias.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void ConfigurarFechas()
        {
            dtpFechaPago.Value = DateTime.Now;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddMonths(1);
        }

        private void CargarPagos()
        {
            try
            {
                var pagos = _context.Pagos
                    .Select(p => new
                    {
                        p.IdPago,
                        Socio = p.Socio.Nombres + " " + p.Socio.Apellidos,
                        p.Socio.DNI,
                        Membresia = p.Membresia.Nombre,
                        FechaPago = p.FechaPago.ToShortDateString(),
                        Monto = "$" + p.Monto.ToString("N2"),
                        FechaInicio = p.FechaInicio.ToShortDateString(),
                        FechaFin = p.FechaFin.ToShortDateString(),
                        p.Estado
                    })
                    .OrderByDescending(p => p.FechaPago)
                    .ToList();

                dgvPagos.DataSource = pagos;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvPagos.Columns["IdPago"].HeaderText = "ID";
            dgvPagos.Columns["Socio"].HeaderText = "Socio";
            dgvPagos.Columns["DNI"].HeaderText = "DNI";
            dgvPagos.Columns["Membresia"].HeaderText = "Membresía";
            dgvPagos.Columns["FechaPago"].HeaderText = "Fecha Pago";
            dgvPagos.Columns["Monto"].HeaderText = "Monto";
            dgvPagos.Columns["FechaInicio"].HeaderText = "Fecha Inicio";
            dgvPagos.Columns["FechaFin"].HeaderText = "Fecha Fin";
            dgvPagos.Columns["Estado"].HeaderText = "Estado";
            dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSocios.SelectedValue != null)
            {
                int idSocio = Convert.ToInt32(cmbSocios.SelectedValue);
                var socio = _context.Socios.Find(idSocio);
                if (socio != null)
                    txtDNISocio.Text = socio.DNI;
            }
        }

        private void cmbMembresias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMembresias.SelectedValue != null)
            {
                int idMembresia = Convert.ToInt32(cmbMembresias.SelectedValue);
                var membresia = _context.Membresias.Find(idMembresia);
                if (membresia != null)
                {
                    txtPrecioMembresia.Text = "$" + membresia.Precio.ToString("N2");
                    txtDuracionMembresia.Text = membresia.DuracionDias + " días";
                    txtMonto.Text = membresia.Precio.ToString("N2");

                    // Calcular fecha fin automáticamente
                    dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(membresia.DuracionDias);
                }
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            // Recalcular fecha fin si hay membresía seleccionada
            if (cmbMembresias.SelectedValue != null)
            {
                int idMembresia = Convert.ToInt32(cmbMembresias.SelectedValue);
                var membresia = _context.Membresias.Find(idMembresia);
                if (membresia != null)
                {
                    dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(membresia.DuracionDias);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                var pago = new Pago
                {
                    IdSocio = Convert.ToInt32(cmbSocios.SelectedValue),
                    IdMembresia = Convert.ToInt32(cmbMembresias.SelectedValue),
                    FechaPago = dtpFechaPago.Value,
                    Monto = decimal.Parse(txtMonto.Text),
                    FechaInicio = dtpFechaInicio.Value,
                    FechaFin = dtpFechaFin.Value,
                    Estado = "Activo"
                };

                _context.Pagos.Add(pago);
                _context.SaveChanges();

                MessageBox.Show("Pago registrado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pago: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (cmbSocios.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un socio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSocios.Focus();
                return false;
            }

            if (cmbMembresias.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una membresía", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMembresias.Focus();
                return false;
            }

            if (dtpFechaFin.Value <= dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha fin debe ser mayor a la fecha inicio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteMembresiasActivas reporte = new frmReporteMembresiasActivas();
            reporte.Show();
        }

        private void LimpiarFormulario()
        {
            cmbSocios.SelectedIndex = -1;
            cmbMembresias.SelectedIndex = -1;
            txtDNISocio.Clear();
            txtPrecioMembresia.Clear();
            txtDuracionMembresia.Clear();
            txtMonto.Clear();
            ConfigurarFechas();
            cmbSocios.Focus();
        }

        private void frmRegistroPagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}