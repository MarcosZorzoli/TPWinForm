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
namespace TPWinForms
{
  
public partial class Alterar : Form
    {
        private Articulo obj;
        private System.Windows.Forms.DataGridView grilla;
        public Alterar()
        {
            InitializeComponent();
        }
        public void setArticulo(ref Articulo obj, ref System.Windows.Forms.DataGridView g ) { 
            this.obj = obj;
            this.grilla = g;             
        }

        private void Alterar_Load(object sender, EventArgs e)
        {
            cbMarcaAlterar.Items.Add("Samsung");
            cbMarcaAlterar.Items.Add("Apple");
            cbMarcaAlterar.Items.Add("Sony");
            cbMarcaAlterar.Items.Add("Huawey");
            cbMarcaAlterar.Items.Add("Motorola");
          
            this.tbNombre.Text = obj.Nombre;
            
            this.numID.Value = obj.Id;
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

            if (dialogResult == DialogResult.OK)
            {
                obj.Nombre = this.tbNombre.Text;

                obj.Id = (int)this.numID.Value;


                obj.Codigo = this.tbCodigo.Text;


                obj.Descripcion = this.tbDescripcion.Text;


                obj.IdMarca = cbMarcaAlterar.SelectedIndex;

                obj.Precio = Convert.ToDecimal(this.tbPrecio.Text);
                grilla.Refresh();
                this.Close();
                

            }
          
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            grilla.Refresh();
        }

       
    }
}
