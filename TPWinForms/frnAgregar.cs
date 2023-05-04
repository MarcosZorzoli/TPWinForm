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

namespace TPWinForms
{
    public partial class frnAgregar : Form 
    {
        private Articulo creado = new Articulo();
        
        private Form1 _form1;
        public frnAgregar(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void frnAgregar_Load(object sender, EventArgs e)
        {
            cbMarca.Items.Add("Samsung");
            cbMarca.Items.Add("Apple");
            cbMarca.Items.Add("Sony");
            cbMarca.Items.Add("Huawey");
            cbMarca.Items.Add("Motorola");

            this.tbNombre.Text = " ";

            this.numID.Value = 0;
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
            DialogResult dialogResult = MessageBox.Show("Seguro que quiere Agregar este Articulo?", "Confirmar", MessageBoxButtons.OKCancel);


                        if (dialogResult == DialogResult.OK)
                        {
                             creado.Id = (int)this.numID.Value;
                             creado.Codigo = this.tbCodigo.Text;
                             creado.Nombre = this.tbNombre.Text;
                             creado.Descripcion = this.tbDescripcion.Text;
                             creado.IdMarca = this.cbMarca.SelectedIndex;
                             creado.Precio = Convert.ToDecimal(this.tbPrecio.Text);

                            _form1.AddArticuloToGrid(creado);      
                            this.Close();
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
