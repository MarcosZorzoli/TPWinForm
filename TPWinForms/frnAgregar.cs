using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForms
{
    public partial class frnAgregar : Form 
    {
        private Articulo creado = new Articulo();
        private Form1 form = new Form1();
        public frnAgregar()
        {
            InitializeComponent();
        }

        private void frnAgregar_Load(object sender, EventArgs e)
        {

            cbMarca.Items.Add("Samsung");
            cbMarca.Items.Add("Apple");
            cbMarca.Items.Add("Sony");
            cbMarca.Items.Add("Huawey");
            cbMarca.Items.Add("Motorola");

            cbCategoria.Items.Add("Celulares");
            cbCategoria.Items.Add("Televisores");
            cbCategoria.Items.Add("Media");
            cbCategoria.Items.Add("Audio");

            this.tbNombre.Text = " ";

            this.tbCodigo.Text = " ";
            this.tbDescripcion.Text = " ";
           
            this.cbMarca.Text = cbMarca.Items[1].ToString();
            
            this.tbPrecio.Text = "0";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();

            try
            {
                creado.Codigo = this.tbCodigo.Text;
                creado.Nombre = this.tbNombre.Text;
                creado.Descripcion = this.tbDescripcion.Text;
                creado.IdMarca = this.cbMarca.SelectedIndex;
                creado.Precio = Convert.ToDecimal(this.tbPrecio.Text);
                creado.IdCategoria = this.cbCategoria.SelectedIndex;

                negocio.AgregarArticulo(creado);
                MessageBox.Show("Agregado exitosamente");

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
                            
             
                        
        }




        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {           
                e.Handled = true;        
        }

       
    }
}
