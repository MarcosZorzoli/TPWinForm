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
            cbMarcaAlterar.Items.Add("Samsung");
            cbMarcaAlterar.Items.Add("Apple");
            cbMarcaAlterar.Items.Add("Sony");
            cbMarcaAlterar.Items.Add("Huawey");
            cbMarcaAlterar.Items.Add("Motorola");

            this.tbNombre.Text = obj.Nombre;

            
            this.tbCodigo.Text = obj.Codigo;
            this.tbDescripcion.Text = obj.Descripcion;
            try
            {
                this.cbMarcaAlterar.Text = cbMarcaAlterar.Items[obj.IdMarca].ToString();
            }
            catch (Exception)
            {
                this.cbMarcaAlterar.Text = cbMarcaAlterar.Items[1].ToString();
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
            if (dialogResult == DialogResult.OK)
            {
                
                obj.Codigo = this.tbCodigo.Text;
                obj.Descripcion = this.tbDescripcion.Text;
                obj.Nombre = this.tbNombre.Text;
                obj.Precio = Convert.ToDecimal(this.tbPrecio.Text);
                obj.IdMarca = this.cbMarcaAlterar.SelectedIndex;
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
