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

        NegocioCategoria nCat = new NegocioCategoria();
        NegocioMarca cMa = new NegocioMarca();

            try
            {
                cbMarca.DataSource = cMa.Listar();
                cbCategoria.DataSource = nCat.Listar();
            }
            catch (Exception)
            {

                throw;
            }



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
                creado.Marca = (Marca)cbMarca.SelectedItem;
                creado.Precio = Convert.ToDecimal(this.tbPrecio.Text);
                creado.Categoria = (Categoria)cbCategoria.SelectedItem;

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

        private void cargarImagen(string img)
        {
            try
            {
                pbxAddImagen.Load(img);
            }
            catch (Exception ex)
            {
                pbxAddImagen.Load("https://www.tibs.org.tw/images/default.jpg");
            }
        }


        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg| *.jpg";
            archivo.ShowDialog();
            if(archivo.ShowDialog() == DialogResult.OK) 
            {
                tbAddImage.Text = archivo.FileName;
               
            }
        }

        private void tbAddImage_Leave(object sender, EventArgs e)
        {
           cargarImagen(tbAddImage.Text);
        }
    }
}
