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

            cboMarcas.DataSource=marcas.Listar();
            cboMarcas.ValueMember = "Id";
            cboMarcas.DisplayMember = "Descripcion";

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
            this.Close();

        }


    }
}
