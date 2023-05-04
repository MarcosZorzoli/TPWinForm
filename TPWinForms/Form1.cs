using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TPWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Articulo> myList = new List<Articulo>();
        public List<Articulo> ListaAnterior = new List<Articulo>();

        private void Form1_Load(object sender, EventArgs e)
        {
            NegocioArticulo servicio = new NegocioArticulo();
            myList = servicio.Listar();
           
            grillaArticulos.DataSource = myList;
            gbxDetalles.Visible = false;
            
        }

        public void AddArticuloToGrid(Articulo newData)
        {
            NegocioArticulo servicio = new NegocioArticulo();
            servicio.AgregarArticulo(ref newData, ref myList);
        }

        private void grillaArticulos_SelectionChanged(object sender, EventArgs e)
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

      

        private void agregarArticuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frnAgregar ventanaAgregar = new frnAgregar(this);         
            ventanaAgregar.ShowDialog();
        }

        private void porNombreToolStripMenuItem2A_Click(object sender, EventArgs e)
        {
            string palabra;
            Busqueda ventanaBusqueda = new Busqueda(1);
            if (ventanaBusqueda.ShowDialog() == DialogResult.OK)
            {
                palabra = ventanaBusqueda.palabra;
                NegocioArticulo servicio = new NegocioArticulo();
                ListaAnterior = myList;
                myList = servicio.ListarXNombre(palabra);
                grillaArticulos.DataSource = myList;
                gbxDetalles.Visible = false;
                cbFiltro.Visible = true;

            }

        }

        private void porMarcaToolStripMenuItem2B_Click(object sender, EventArgs e)
        {
            int ID;
            Busqueda ventanaBusqueda = new Busqueda(2);
            if (ventanaBusqueda.ShowDialog() == DialogResult.OK)
            {
                ID = ventanaBusqueda.ID;
                NegocioArticulo servicio = new NegocioArticulo();
                ListaAnterior = myList;
                myList = servicio.ListarXMarca(ID);
                grillaArticulos.DataSource = myList;
                gbxDetalles.Visible = false;
                cbFiltro.Visible = true;

            }
        }

        private void porCódigoToolStripMenuItem2C_Click(object sender, EventArgs e)
        {
            Busqueda ventanaBusqueda = new Busqueda(3);
            ventanaBusqueda.ShowDialog();
        }

        private void porCategoríaToolStripMenuItem2D_Click(object sender, EventArgs e)
        {
            Busqueda ventanaBusqueda = new Busqueda(4);
            ventanaBusqueda.ShowDialog();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            Alterar ventanaAlter = new Alterar();
            Articulo item = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;
            ventanaAlter.setArticulo(ref item,ref grillaArticulos);
            ventanaAlter.ShowDialog();
        }

        private void grillaArticulos_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].Id == 0)
                {
                    Articulo aux = myList[i];

                    NegocioArticulo servicio = new NegocioArticulo();
                    servicio.EiminarArticulo(ref aux, ref myList);
                }
            }
          
            gbxDetalles.Visible = false;
            grillaArticulos.DataSource = myList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           

            DialogResult dialogResult = MessageBox.Show("Seguro que quiere Elminar este Articulo?", "Confirmar", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                Articulo item = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;
               
                NegocioArticulo servicio = new NegocioArticulo();
                servicio.EiminarArticulo(ref item,ref myList);
                grillaArticulos.DataSource = myList;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            cbFiltro.Checked = true;
            cbFiltro.Visible = false;
            grillaArticulos.DataSource = ListaAnterior;
            gbxDetalles.Visible = false;
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].Id == 0)
                {
                    Articulo aux = myList[i];

                    NegocioArticulo servicio = new NegocioArticulo();
                    servicio.EiminarArticulo(ref aux, ref myList);
                }
            }
            grillaArticulos.DataSource = myList;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            grillaArticulos.DataSource = myList;
        }
    }
}
