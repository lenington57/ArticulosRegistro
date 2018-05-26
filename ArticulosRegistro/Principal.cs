using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArticulosRegistro
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void registroDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticulosRegistro.UI.Registros.ArticuloForm articuloForm = new UI.Registros.ArticuloForm();
            articuloForm.Visible = true;
        }

        private void consultarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticulosRegistro.UI.Consultas.ConsultarForm consultarForm = new UI.Consultas.ConsultarForm();
            consultarForm.Visible = true;
        }
    }
}
