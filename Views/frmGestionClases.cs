using Gimnasio.Data;
using Gimnasio.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class frmGestionClases : Form
    {
        private GimnasioContext _context;
        private Clase _claseActual;

        public frmGestionClases()
        {
            InitializeComponent();
            _context = new GimnasioContext();
            CargarClases();
            CargarComboEstado();
        }

        private void CargarClases()
        {
            try
            {
                var clases = _context.Clases.ToList();
                dgvClases.DataSource = clases.Select(c => new
                {
                    c.IdClase,
                    c.Nombre,
                    c.Horario,
                    c.Instructor,
                    c.CupoMaximo,
                    Estado = c.Estado ? "Activo" : "Inactivo"
                }).ToList();

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clases: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvClases.Columns["IdClase"].HeaderText = "ID";
            dgvClases.Columns["Nombre"].HeaderText = "Nombre";
            dgvClases.Columns["Horario"].HeaderText = "Horario";
            dgvClases.Columns["Instructor"].HeaderText = "Instructor";
            dgvClases.Columns["CupoMaximo"].HeaderText = "Cupo Máximo";
            dgvClases.Columns["Estado"].HeaderText = "Estado";
            dgvClases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                if (_claseActual == null)
                    _claseActual = new Clase();

                _claseActual.Nombre = txtNombreClase.Text.Trim().ToUpper();
                _claseActual.Horario = txtHorario.Text.Trim();
                _claseActual.Instructor = txtInstructor.Text.Trim().ToUpper();
                _claseActual.CupoMaximo = (int)numCupo.Value;
                _claseActual.Estado = cmbEstado.SelectedItem.ToString() == "Activo";

                if (_claseActual.IdClase == 0)
                {
                    _context.Clases.Add(_claseActual);
                    MessageBox.Show("Clase registrada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _context.Entry(_claseActual).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    MessageBox.Show("Clase actualizada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _context.SaveChanges();
                LimpiarFormulario();
                CargarClases();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreClase.Text))
            {
                MessageBox.Show("Ingrese el nombre de la clase", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreClase.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHorario.Text))
            {
                MessageBox.Show("Ingrese el horario", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHorario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtInstructor.Text))
            {
                MessageBox.Show("Ingrese el nombre del instructor", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInstructor.Focus();
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombreClase.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_claseActual == null || _claseActual.IdClase == 0)
            {
                MessageBox.Show("Seleccione una clase de la lista", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnGuardar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_claseActual == null || _claseActual.IdClase == 0)
                {
                    MessageBox.Show("Seleccione una clase para eliminar", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(
                    $"¿Está seguro de eliminar la clase '{_claseActual.Nombre}'?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _context.Clases.Remove(_claseActual);
                    _context.SaveChanges();
                    MessageBox.Show("Clase eliminada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarClases();
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

        private void dgvClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvClases.Rows[e.RowIndex];
                    int idClase = Convert.ToInt32(row.Cells["IdClase"].Value);

                    _claseActual = _context.Clases.Find(idClase);

                    if (_claseActual != null)
                    {
                        txtNombreClase.Text = _claseActual.Nombre;
                        txtHorario.Text = _claseActual.Horario;
                        txtInstructor.Text = _claseActual.Instructor;
                        numCupo.Value = _claseActual.CupoMaximo;
                        cmbEstado.SelectedItem = _claseActual.Estado ? "Activo" : "Inactivo";
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
            txtNombreClase.Clear();
            txtHorario.Clear();
            txtInstructor.Clear();
            numCupo.Value = 20;
            cmbEstado.SelectedItem = "Activo";
            _claseActual = null;
            txtNombreClase.Focus();
        }

        private void frmGestionClases_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}