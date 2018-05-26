using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArticulosRegistro.Entidades;
using ArticulosRegistro.BLL;
using System.Linq.Expressions;

namespace ArticulosRegistro.UI.Consultas
{
    public partial class ConsultarForm : Form
    {
        public ConsultarForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en true
           Expression<Func<Articulo, bool>> filtro = a => true;

            int id;
            while(CriterioTextBox.Text != string.Empty)
            switch (FiltrarComboBox.SelectedIndex)
            {
                case 0://ArticuloId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = a => a.ArticuloId == id;
                    break;
                case 1://Descripcion
                    filtro = a => a.Descripcion.Contains(CriterioTextBox.Text);
                    break;
                case 2://Precio
                    filtro = a => a.Precio.Equals(CriterioTextBox.Text);
                    break;
                case 3://Existencia
                    filtro = a => a.Existencia.Equals(CriterioTextBox.Text);
                    break;
                case 4://CantCotizada
                    filtro = a => a.CantCotizada.Equals(CriterioTextBox.Text);
                    break;
            }
            ConsultaDataGridView.DataSource = BLL.ArticuloBLL.GetList(filtro);
        }

        private void ConsultarForm_Load(object sender, EventArgs e)
        {

        }

        private void ConsultaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
