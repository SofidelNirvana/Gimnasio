using Gimnasio.Data;
using Gimnasio.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class frmGestionSocios : Form
    {
        private GimnasioContext _context;
        private Socio _socioActual;

        public frmGestionSocios()
        {
            InitializeComponent();
            _context = new GimnasioContext();
            CargarSocios();
        }

        private void CargarSocios()
        {
            try
            {
                var socios = _context.Socios.ToList();
                dgvSocios.DataSource = socios.Select(s => new
                {
                    s.IdSocio,
                    s.Nombres,
                    s.Apellidos,
                    s.DNI,
                    s.Telefono,
                    s.Email,
                    FechaRegistro = s.FechaRegistro.ToShortDateString(),
                    Estado = s.Estado ? "Activo" : "Inactivo"
                }).ToList();

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar socios: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvSocios.Columns["IdSocio"].HeaderText = "ID";
            dgvSocios.Columns["Nombres"].HeaderText = "Nombres";
            dgvSocios.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvSocios.Columns["DNI"].HeaderText = "DNI";
            dgvSocios.Columns["Telefono"].HeaderText = "Teléfono";
            dgvSocios.Columns["Email"].HeaderText = "Email";
            dgvSocios.Columns["FechaRegistro"].HeaderText = "Fecha Registro";
            dgvSocios.Columns["Estado"].HeaderText = "Estado";

            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSocios.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                if (_socioActual == null)
                    _socioActual = new Socio();

                _socioActual.Nombres = txtNombres.Text.Trim().ToUpper();
                _socioActual.Apellidos = txtApellidos.Text.Trim().ToUpper();
                _socioActual.DNI = txtDNI.Text.Trim();
                _socioActual.Telefono = txtTelefono.Text.Trim();
                _socioActual.Email = txtEmail.Text.Trim();
                _socioActual.Estado = true;

                if (_socioActual.IdSocio == 0)
                {
                    _socioActual.FechaRegistro = DateTime.Now;
                    _context.Socios.Add(_socioActual);
                    MessageBox.Show("Socio registrado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _context.Entry(_socioActual).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    MessageBox.Show("Socio actualizado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _context.SaveChanges();
                LimpiarFormulario();
                CargarSocios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MessageBox.Show("Ingrese los nombres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Ingrese los apellidos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Ingrese el DNI", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            // ✅ Extraer el valor a variable local
            int idSocioActual = _socioActual != null ? _socioActual.IdSocio : 0;

            // ✅ Usar la variable local en la consulta
            var socioExistente = _context.Socios.FirstOrDefault(s =>
                s.DNI == txtDNI.Text.Trim() && s.IdSocio != idSocioActual);

            if (socioExistente != null)
            {
                MessageBox.Show("El DNI ya está registrado", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombres.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_socioActual == null || _socioActual.IdSocio == 0)
            {
                MessageBox.Show("Seleccione un socio de la lista para modificar",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnGuardar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_socioActual == null || _socioActual.IdSocio == 0)
                {
                    MessageBox.Show("Seleccione un socio para eliminar",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(
                    $"¿Está seguro de eliminar al socio {_socioActual.Nombres} {_socioActual.Apellidos}?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _context.Socios.Remove(_socioActual);
                    _context.SaveChanges();
                    MessageBox.Show("Socio eliminado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarSocios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string dniBuscar = txtBuscarDNI.Text.Trim();

                if (string.IsNullOrEmpty(dniBuscar))
                {
                    CargarSocios();
                    return;
                }

                var socios = _context.Socios
                    .Where(s => s.DNI.Contains(dniBuscar))
                    .ToList();

                dgvSocios.DataSource = socios.Select(s => new
                {
                    s.IdSocio,
                    s.Nombres,
                    s.Apellidos,
                    s.DNI,
                    s.Telefono,
                    s.Email,
                    FechaRegistro = s.FechaRegistro.ToShortDateString(),
                    Estado = s.Estado ? "Activo" : "Inactivo"
                }).ToList();

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtBuscarDNI.Clear();
            CargarSocios();
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvSocios.Rows[e.RowIndex];
                    int idSocio = Convert.ToInt32(row.Cells["IdSocio"].Value);

                    _socioActual = _context.Socios.Find(idSocio);

                    if (_socioActual != null)
                    {
                        txtNombres.Text = _socioActual.Nombres;
                        txtApellidos.Text = _socioActual.Apellidos;
                        txtDNI.Text = _socioActual.DNI;
                        txtTelefono.Text = _socioActual.Telefono;
                        txtEmail.Text = _socioActual.Email;
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
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            _socioActual = null;
            txtNombres.Focus();
        }

        private void frmGestionSocios_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

    }
}