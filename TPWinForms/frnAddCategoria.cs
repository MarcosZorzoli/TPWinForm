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
    public partial class frnAddCategoria : Form
    {

        private Categoria cat;

        public frnAddCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NegocioCategoria negocio = new NegocioCategoria();  
            Categoria aux = new Categoria();
            aux.Descripcion = tbNuevaCategoria.Text;
            aux.Id = 0;

            try
            {
                cat = aux;

                negocio.AgregarCategoria(cat);
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
