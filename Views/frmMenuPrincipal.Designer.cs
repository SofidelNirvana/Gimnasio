namespace Gimnasio.Views
{
    partial class frmMenuPrincipal
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
            menuPrincipal = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            gestionarSociosToolStripMenuItem = new ToolStripMenuItem();
            gestionarMembresíasToolStripMenuItem = new ToolStripMenuItem();
            gestionarClasesToolStripMenuItem = new ToolStripMenuItem();
            registrarPagoToolStripMenuItem = new ToolStripMenuItem();
            membresíasActivasToolStripMenuItem = new ToolStripMenuItem();
            btnSocios = new Button();
            btnMembresias = new Button();
            btnClases = new Button();
            btnPagos = new Button();
            btnReportes = new Button();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5 });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(800, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            menuPrincipal.ItemClicked += menuPrincipal_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { gestionarSociosToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(53, 20);
            toolStripMenuItem1.Text = "Socios";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { gestionarMembresíasToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(83, 20);
            toolStripMenuItem2.Text = "Membresías";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { gestionarClasesToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(52, 20);
            toolStripMenuItem3.Text = "Clases";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { registrarPagoToolStripMenuItem });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(51, 20);
            toolStripMenuItem4.Text = "Pagos";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[] { membresíasActivasToolStripMenuItem });
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(65, 20);
            toolStripMenuItem5.Text = "Reportes";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // gestionarSociosToolStripMenuItem
            // 
            gestionarSociosToolStripMenuItem.Name = "gestionarSociosToolStripMenuItem";
            gestionarSociosToolStripMenuItem.Size = new Size(180, 22);
            gestionarSociosToolStripMenuItem.Text = "Gestionar Socios";
            // 
            // gestionarMembresíasToolStripMenuItem
            // 
            gestionarMembresíasToolStripMenuItem.Name = "gestionarMembresíasToolStripMenuItem";
            gestionarMembresíasToolStripMenuItem.Size = new Size(191, 22);
            gestionarMembresíasToolStripMenuItem.Text = "Gestionar Membresías";
            // 
            // gestionarClasesToolStripMenuItem
            // 
            gestionarClasesToolStripMenuItem.Name = "gestionarClasesToolStripMenuItem";
            gestionarClasesToolStripMenuItem.Size = new Size(180, 22);
            gestionarClasesToolStripMenuItem.Text = "Gestionar Clases";
            // 
            // registrarPagoToolStripMenuItem
            // 
            registrarPagoToolStripMenuItem.Name = "registrarPagoToolStripMenuItem";
            registrarPagoToolStripMenuItem.Size = new Size(180, 22);
            registrarPagoToolStripMenuItem.Text = "Registrar Pago";
            // 
            // membresíasActivasToolStripMenuItem
            // 
            membresíasActivasToolStripMenuItem.Name = "membresíasActivasToolStripMenuItem";
            membresíasActivasToolStripMenuItem.Size = new Size(180, 22);
            membresíasActivasToolStripMenuItem.Text = "Membresías Activas";
            // 
            // btnSocios
            // 
            btnSocios.Location = new Point(21, 284);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(75, 23);
            btnSocios.TabIndex = 1;
            btnSocios.Text = "Socios";
            btnSocios.UseVisualStyleBackColor = true;
            btnSocios.Click += btnSocios_Click;
            // 
            // btnMembresias
            // 
            btnMembresias.Location = new Point(102, 284);
            btnMembresias.Name = "btnMembresias";
            btnMembresias.Size = new Size(75, 23);
            btnMembresias.TabIndex = 2;
            btnMembresias.Text = "Membresias";
            btnMembresias.UseVisualStyleBackColor = true;
            btnMembresias.Click += btnMembresias_Click;
            // 
            // btnClases
            // 
            btnClases.Location = new Point(183, 284);
            btnClases.Name = "btnClases";
            btnClases.Size = new Size(75, 23);
            btnClases.TabIndex = 3;
            btnClases.Text = "Clases";
            btnClases.UseVisualStyleBackColor = true;
            btnClases.Click += btnClases_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(264, 284);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(75, 23);
            btnPagos.TabIndex = 4;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(345, 284);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(75, 23);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportes);
            Controls.Add(btnPagos);
            Controls.Add(btnClases);
            Controls.Add(btnMembresias);
            Controls.Add(btnSocios);
            Controls.Add(menuPrincipal);
            MainMenuStrip = menuPrincipal;
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem gestionarSociosToolStripMenuItem;
        private ToolStripMenuItem gestionarMembresíasToolStripMenuItem;
        private ToolStripMenuItem gestionarClasesToolStripMenuItem;
        private ToolStripMenuItem registrarPagoToolStripMenuItem;
        private ToolStripMenuItem membresíasActivasToolStripMenuItem;
        private Button btnSocios;
        private Button btnMembresias;
        private Button btnClases;
        private Button btnPagos;
        private Button btnReportes;
    }
}