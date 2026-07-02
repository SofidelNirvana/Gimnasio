using Gimnasio.Data;
using Gimnasio.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class frmGestionMembresias : Form
    {
        private GimnasioContext _context;
        private Membresia _membresiaActual;

        public frmGestionMembresias()
        {
            InitializeComponent();
            _context = new GimnasioContext();
            CargarMembresias();
            CargarComboEstado();
        }

        private void CargarMembresias()
        {
            try
            {
                var membresias = _context.Membresias.ToList();
                dgvMembresias.DataSource = membresias.Select(m => new
                {
                    m.IdMembresia,
                    m.Nombre,
                    m.DuracionDias,
                    Precio = "$" + m.Precio.ToString("N2"),
                    Estado = m.Estado ? "Activo" : "Inactivo"
                }).ToList();

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar membresías: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvMembresias.Columns["IdMembresia"].HeaderText = "ID";
            dgvMembresias.Columns["Nombre"].HeaderText = "Nombre";
            dgvMembresias.Columns["DuracionDias"].HeaderText = "Duración (Días)";
            dgvMembresias.Columns["Precio"].HeaderText = "Precio";
            dgvMembresias.Columns["Estado"].HeaderText = "Estado";
            dgvMembresias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarComboEstado()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                if (_membresiaActual == null)
                    _membresiaActual = new Membresia();

                _membresiaActual.Nombre = txtNombreMembresia.Text.Trim().ToUpper();
                _membresiaActual.DuracionDias = (int)numDuracion.Value;
                _membresiaActual.Precio = decimal.Parse(txtPrecio.Text);
                _membresiaActual.Estado = cmbEstado.SelectedItem.ToString() == "Activo";

                if (_membresiaActual.IdMembresia == 0)
                {
                    _context.Membresias.Add(_membresiaActual);
                    MessageBox.Show("Membresía registrada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _context.Entry(_membresiaActual).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    MessageBox.Show("Membresía actualizada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _context.SaveChanges();
                LimpiarFormulario();
                CargarMembresias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreMembresia.Text))
            {
                MessageBox.Show("Ingrese el nombre de la membresía", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreMembresia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese el precio", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombreMembresia.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_membresiaActual == null || _membresiaActual.IdMembresia == 0)
            {
                MessageBox.Show("Seleccione una membresía de la lista", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnGuardar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_membresiaActual == null || _membresiaActual.IdMembresia == 0)
                {
                    MessageBox.Show("Seleccione una membresía para eliminar", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(
                    $"¿Está seguro de eliminar la membresía '{_membresiaActual.Nombre}'?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _context.Membresias.Remove(_membresiaActual);
                    _context.SaveChanges();
                    MessageBox.Show("Membresía eliminada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarMembresias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvMembresias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvMembresias.Rows[e.RowIndex];
                    int idMembresia = Convert.ToInt32(row.Cells["IdMembresia"].Value);

                    _membresiaActual = _context.Membresias.Find(idMembresia);

                    if (_membresiaActual != null)
                    {
                        txtNombreMembresia.Text = _membresiaActual.Nombre;
                        numDuracion.Value = _membresiaActual.DuracionDias;
                        txtPrecio.Text = _membresiaActual.Precio.ToString("N2");
                        cmbEstado.SelectedItem = _membresiaActual.Estado ? "Activo" : "Inactivo";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar: " + ex.Message);
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreMembresia.Clear();
            numDuracion.Value = 30;
            txtPrecio.Clear();
            cmbEstado.SelectedItem = "Activo";
            _membresiaActual = null;
            txtNombreMembresia.Focus();
        }

        private void frmGestionMembresias_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}