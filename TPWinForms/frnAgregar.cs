using System;
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Articulo aux = new Articulo();
            aux.Id = (int)numID.Value;
            aux.Codigo = tbCodigo.Text;
            aux.Nombre = tbNombre.Text;
            aux.Descripcion = tbDescripcion.Text;
            aux.IdMarca = cbMarca.SelectedIndex;
            
        }
    }
}
