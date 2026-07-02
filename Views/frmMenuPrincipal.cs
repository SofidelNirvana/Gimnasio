using System;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

            // ✅ Esta línea es OBLIGATORIA para MDI
            this.IsMdiContainer = true;

            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGestionSocios());
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGestionMembresias());
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGestionClases());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistroPagos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReporteMembresiasActivas());
        }

        private void gestionarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGestionSocios());
        }

        private void gestionarMembresíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGestionMembresias());
        }

        private void gestionarClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGestionClases());
        }

        private void registrarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistroPagos());
        }

        private void membresíasActivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReporteMembresiasActivas());
        }

        private void AbrirFormulario(Form form)
        {
            form.MdiParent = this;  // ← Aquí usa "this" que ahora SÍ es contenedor MDI
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}