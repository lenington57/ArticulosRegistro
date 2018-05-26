using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArticulosRegistro.BLL;
using ArticulosRegistro.Entidades;

namespace ArticulosRegistro.UI.Registros
{
    public partial class ArticuloForm : Form
    {
        public ArticuloForm()
        {
            InitializeComponent();
        }

        private void ArticuloForm_Load(object sender, EventArgs e)
        {

        }

        private Articulo LlenaClase()
        {
            Articulo articulo = new Articulo();

            articulo.ArticuloId = Convert.ToInt32(ArticuloIdNumericUpDown.Value);
            articulo.FechaVencimiento = FechaVenciDateTimePicker.Value;
            articulo.Descripcion = DescripcionTextBox.Text;
            articulo.Precio = Convert.ToSingle(PrecioTextBox.Text);
            articulo.Existencia = Convert.ToSingle(ExistenciaTextBox.Text);
            articulo.CantCotizada = Convert.ToSingle(CantCotizTextBox.Text);

            return articulo;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Error(2))//Indicando que llene cada campo que esté vacío.
            {
                MessageBox.Show("Llenar Campo");
                return;
            }
            Articulo articulo = LlenaClase();
            bool Paso = false;

            //Determinar si es Guardar o Modificar
            if (ArticuloIdNumericUpDown.Value == 0)
                Paso = BLL.ArticuloBLL.Guardar(articulo);
            else
                Paso = BLL.ArticuloBLL.Modificar(LlenaClase());

            //Informar el resutado
            if (Paso)
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar","Falló",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ArticuloIdNumericUpDown.Value = 0;
            FechaVenciDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();
            CantCotizTextBox.Clear();            
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticuloIdNumericUpDown.Value);
            Articulo articulo = BLL.ArticuloBLL.Buscar(id);

            if (articulo != null)
            {
                FechaVenciDateTimePicker.Value = articulo.FechaVencimiento;
                DescripcionTextBox.Text = articulo.Descripcion;
                PrecioTextBox.Text = articulo.Precio.ToString();
                ExistenciaTextBox.Text = articulo.Existencia.ToString();
                CantCotizTextBox.Text = articulo.CantCotizada.ToString();
            }
        }

        private bool Error(int error)
        {
            bool paso = false;
            //Tiramos un error para cada campo que no este lleno
            if (error == 1 && ArticuloIdNumericUpDown.Value == 0)
            {
                ArticuloIdErrorProvider.SetError(ArticuloIdNumericUpDown, "Ingrese un ID");//Tiramos un error si ArticuloIdNumericUpDown que no está lleno.
                paso = true;
            }
            if (error == 2 && DescripcionTextBox.Text == string.Empty)
            {
                DescripcionErrorProvider.SetError(DescripcionTextBox, "Ingrese una Dirección");//Tiramos un error si DescripcionTextBox que no está lleno.
                paso = true;
            }
            if (error == 2 && PrecioTextBox.Text == string.Empty)
            {
                PrecioErrorProvider.SetError(PrecioTextBox, "Ingrese una Precio"); //Tiramos un error si PrecioTextBox que no está lleno.
                paso = true;
            }
            if (error == 2 && ExistenciaTextBox.Text == string.Empty)
            {
                ExistErrorProvider.SetError(ExistenciaTextBox, "Ingrese una Cuant@s hay en Existencia"); //Tiramos un error si ExistenciaTextBox que no está lleno.
                paso = true;
            }
            if (error == 2 && CantCotizTextBox.Text == string.Empty)
            {
                CantCotErrorProvider.SetError(CantCotizTextBox, "Ingrese una Cantidad que desea comprar");//Tiramos un error si CantCotizTextBox que no está lleno.
                paso = true;
            }

            return paso;
        }
    }
}
