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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Articulo> myList = new List<Articulo>();

        private void Form1_Load(object sender, EventArgs e)
        {
            NegocioArticulo servicio = new NegocioArticulo();
            myList = servicio.Listar();
            grillaArticulos.DataSource = myList;
            gbxDetalles.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grillaArticulos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                gbxDetalles.Visible = true;
                Articulo item = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;

                lblNombre.Text = item.Nombre;
                lblDescripcion.Text = item.Descripcion;
                try
                {
                    pbxImagen.Load(item.UrlImagen);
                }

                catch
                {

                    pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");
                    //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 
                }

            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            gbxDetalles.Visible = false;
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
           
                MessageBox.Show("SOY LA VENTANA PARA EDITAR ARTICULOS");
            
        }
    }
}
