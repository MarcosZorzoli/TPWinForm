using System;
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

    public partial class Alterar : Form
    {
        private Articulo obj;
        private int ubicacion;
        private bool cambios = false;


        public Alterar()
        {
            InitializeComponent();
        }
        public Alterar(Articulo obj)
        {
            InitializeComponent();
            this.obj = obj;

        }

        public void Cargar()
        {


            NegocioCategoria categorias = new NegocioCategoria();
            cboCategorias.DataSource = categorias.Listar();
            cboCategorias.ValueMember = "Id";
            cboCategorias.DisplayMember = "Descripcion";
            NegocioMarca marcas = new NegocioMarca();

            cboMarcas.DataSource = marcas.Listar();
            cboMarcas.ValueMember = "Id";
            cboMarcas.DisplayMember = "Descripcion";
            ubicacion = 0;
            try
            {
                pbxImagen.Load(obj.Imagenes[0].Url);
            }

            catch
            {

                pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");
                //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 
            }
            this.tbNombre.Text = obj.Nombre;


            this.tbCodigo.Text = obj.Codigo;
            this.tbDescripcion.Text = obj.Descripcion;
            try
            {
                cboCategorias.SelectedValue = obj.Categoria.Id;
                cboMarcas.SelectedValue = obj.Categoria.Id;
            }
            catch (Exception)
            {

                throw;
            }
            lblImagen.Text = (ubicacion + 1).ToString();
            lblCantidad.Text = (obj.Imagenes.Count).ToString();

            this.tbPrecio.Text = obj.Precio.ToString();
        }

        private void Alterar_Load(object sender, EventArgs e)
        {


            Cargar();

        }

        private void Alterar_Activated(object sender, EventArgs e)
        {
            this.lblNombre.Focus();

        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que quiere Modificar este Articulo?", "Confirmar", MessageBoxButtons.OKCancel);
            NegocioArticulo negocio = new NegocioArticulo();
            NegocioMarca negocioMarca = new NegocioMarca();
            if (dialogResult == DialogResult.OK)
            {

                obj.Codigo = this.tbCodigo.Text;
                obj.Descripcion = this.tbDescripcion.Text;
                obj.Nombre = this.tbNombre.Text;
                obj.Precio = Convert.ToDecimal(this.tbPrecio.Text);
                obj.Marca = (Marca)cboMarcas.SelectedItem;
                obj.Categoria = (Categoria)cboCategorias.SelectedItem;
                negocio.ModificarArticulo(obj);


                Close();


            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Cuidadito();


        }
        public void Cuidadito()
        {
            if (cambios)
            {
                DialogResult dialogResult = MessageBox.Show("Tiene cambios sin Guardar, desea irse de todas maneras?", "Datos Modificados", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {

                    this.Close();
                }

            }
            else
            {
                this.Close();
            }

        }

        

        private void flechitaIzq_Click(object sender, EventArgs e)
        {


            if (ubicacion <= 0)
            {
                ubicacion = obj.Imagenes.Count - 1;
            }
            else
            {
                ubicacion--;
            }

            try
            {
                pbxImagen.Load(obj.Imagenes[ubicacion].Url);

            }

            catch
            {

                pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");

                //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 
            }


            int current = ubicacion + 1;
            lblImagen.Text = current.ToString();
        }

      

        private void btnAlter_Click(object sender, EventArgs e)
        {
            frmAgregarImagen ventana = new frmAgregarImagen(obj);
            ventana.ShowDialog();


        }

        private void Alterar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambios)
            {
                if (MessageBox.Show("Tiene cambios sin Guardar, desea irse de todas maneras?", "Datos Modificados", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void flechitaD_Click_1(object sender, EventArgs e)
        {
            if (ubicacion >= obj.Imagenes.Count - 1)
            {
                ubicacion = 0;
            }
            else
            {
                ubicacion++;
            }
            try
            {
                pbxImagen.Load(obj.Imagenes[ubicacion].Url);

            }

            catch
            {

                pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");
                //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 

            }



            int current = ubicacion + 1;
            lblImagen.Text = current.ToString();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
