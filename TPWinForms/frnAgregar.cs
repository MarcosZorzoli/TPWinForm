using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForms
{
    public partial class frnAgregar : Form 
    {
        private System.Windows.Forms.DataGridView dgvAgregar;
        private List<Articulo> articulos;
        public frnAgregar()
        {
            InitializeComponent();
        }
        public void setGrilla(ref System.Windows.Forms.DataGridView grid, ref List<Articulo> listaArticulo)
        {
            this.dgvAgregar = grid;
            this.articulos = listaArticulo;
        }
        private void frnAgregar_Load(object sender, EventArgs e)
        {
            cbMarca.Items.Add("Samsung");
            cbMarca.Items.Add("Apple");
            cbMarca.Items.Add("Sony");
            cbMarca.Items.Add("Huawey");
            cbMarca.Items.Add("Motorola");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Form1 formReceptor = new Form1();


            Articulo aux = new Articulo();
            aux.Id = (int)numID.Value;
            aux.Codigo = tbCodigo.Text;
            aux.Nombre = tbNombre.Text;
            aux.Descripcion = tbDescripcion.Text;
            aux.IdMarca = cbMarca.SelectedIndex;
            aux.Precio = Convert.ToDecimal(this.tbPrecio.Text);

            articulos.Add(aux);

            dgvAgregar.DataSource = aux;

            this.Close();

            dgvAgregar.Refresh();
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
