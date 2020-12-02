using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextoAbierto
{
    public partial class TextoAbiertoPresentación : Form
    {
        public TextoAbiertoPresentación()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Presentacion frm = new Presentacion();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Editar fmr = new Editar();
            fmr.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            TextoAbiertoCrear frm = new TextoAbiertoCrear();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Profesor frm = new Profesor();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            TextoAbiertoPresentación frm = new TextoAbiertoPresentación();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
