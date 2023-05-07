using dominio;
using negocio;
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
    public partial class frnAddMarca : Form
    {
        Marca cat = new Marca();
        public frnAddMarca()
        {
            InitializeComponent();
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            NegocioMarca negocio = new NegocioMarca();
            Categoria aux = new Categoria();

            try
            {
                cat.Descripcion = tbNuevaMarca.Text;

                negocio.AgregarMarca(cat);
                MessageBox.Show("Agregado exitosamente");

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
