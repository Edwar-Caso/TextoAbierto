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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void Profesor_Load(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            TextoAbiertoCrear frm = new TextoAbiertoCrear();
            frm.Show();
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            TextoAbiertoPresentación frm = new TextoAbiertoPresentación();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            menuprincipal frm = new menuprincipal();
            frm.Show();
        }
    }
}
