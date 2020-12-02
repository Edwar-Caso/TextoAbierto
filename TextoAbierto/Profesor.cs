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

        private void cREARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextoAbiertoCrear frm = new TextoAbiertoCrear();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
