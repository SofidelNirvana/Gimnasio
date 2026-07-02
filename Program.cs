using System;
using System.Windows.Forms;
using Gimnasio.Views; // ← Agrega este using si no está

namespace Gimnasio
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ CAMBIA Form1 POR frmMenuPrincipal
            Application.Run(new frmMenuPrincipal());
        }
    }
}