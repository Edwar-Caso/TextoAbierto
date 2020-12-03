using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidadesTextoAbierto;
using CapaNegocioTextoAbierto;

namespace TextoAbierto
{
    public partial class TextoAbiertoCrear : Form
    {
        public TextoAbiertoCrear()
        {
            InitializeComponent();
        }
        private Cuestionario cuestionario;
        private readonly CuestionarioN cuestionarioN = new CuestionarioN();

        private void Guardar()
        {
            try
            {
                if (cuestionario == null) cuestionario = new Cuestionario();

                cuestionario.Id_Cuestionario = Convert.ToInt32(lblCodigo.Text);
                cuestionario.pregunta = txtPregunta.Text;
                cuestionario.descripcion = txtDescripcion.Text;
                cuestionario.imagen = Convert.ToByte(boxImagen.Image);

                cuestionarioN.Registrar(cuestionario);

                if (cuestionarioN.stringBuilder.Length != 0)
                {
                    MessageBox.Show(cuestionarioN.stringBuilder.ToString(), "Para continuar:");
                }
                else
                {
                    MessageBox.Show("Producto registrado/actualizado con éxito");

                    //TraerTodos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        /*
        private void TraerTodos()
        {
            List<Cuestionario> cuestionario = cuestionarioN.Todos();

            if (cuestionario.Count > 0)
            {
                
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.DataSource = cuestionario;
                dgvDatos.Columns["columnId"].DataPropertyName = "Id";
                dgvDatos.Columns["columnDescripcion"].DataPropertyName = "Pregunta";
      
                
            }
            else
                MessageBox.Show("No existen registros");
        }
        */

        private void Rellenar(int id_cuestionario)
        {
            try
            {
                cuestionario = cuestionarioN.TraerPorId(id_cuestionario);

                if (cuestionario != null)
                {
                    labelPre.Text = cuestionario.pregunta;
                    labelDes.Text = cuestionario.descripcion;
                    //pictureBoxIm.Image = Convert.ToByte(cuestionario.imagen);
                }
                else
                    MessageBox.Show("El registro solicitado no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor frm = new Profesor();
            frm.Show();
            Guardar();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Profesor frm = new Profesor();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            TextoAbiertoCrear frm = new TextoAbiertoCrear();
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
            TextoAbiertoReporte frm = new TextoAbiertoReporte();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    boxImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
