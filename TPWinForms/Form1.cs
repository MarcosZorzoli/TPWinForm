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
using negocio;
using dominio;
using System.Diagnostics.Eventing.Reader;

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
        public int ubicacion = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Número");
            cbxCampo.Items.Add("Descripción");
            NegocioArticulo servicio = new NegocioArticulo();
            myList = servicio.Listar();
           


            grillaArticulos.DataSource = myList;
            gbxDetalles.Visible = false;
            
        }

        private void grillaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            gbxDetalles.Visible = true;
            Articulo item = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;
            lblImagen.Text = (ubicacion+1).ToString();
            lblCantidad.Text = (item.Imagenes.Count).ToString();
            lblNombre.Text = item.Nombre;
            lblDescripcion.Text = item.Descripcion;
            ubicacion = 0;
            try
            {
                pbxImagen.Load(item.Imagenes[0].Url);
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

        private void btnAlter_Click(object sender, EventArgs e)
        {
            Articulo item = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;
            Alterar ventanaAlter = new Alterar(item);
            ventanaAlter.ShowDialog();
            Cargar();

        }

        private void grillaArticulos_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].Id == 0)
                {
                    Articulo aux = myList[i];

                    NegocioArticulo servicio = new NegocioArticulo();
                
                }
            }
          
            gbxDetalles.Visible = false;
            grillaArticulos.DataSource = myList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Articulo item = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;

            DialogResult dialogResult = MessageBox.Show("Seguro que quiere Elminar este Articulo?", "Confirmar", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
               
               
                NegocioArticulo servicio = new NegocioArticulo();
           
                servicio.Eliminar(item.Id);
                Cargar();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {

            Cargar();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            NegocioArticulo servicio = new NegocioArticulo();
            myList = servicio.Listar();

            grillaArticulos.DataSource = myList;
            gbxDetalles.Visible = false;
        }
        private void Cargar()
        {
            NegocioArticulo servicio = new NegocioArticulo();
            myList = servicio.Listar();

            grillaArticulos.DataSource = myList;
            gbxDetalles.Visible = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltro;
            string filtro = txtFiltro.Text;
            if(filtro!=""&&filtro.Length>=2)
            {
                listaFiltro=myList.FindAll(x=>x.Nombre.ToUpper().Contains(filtro.ToUpper())||x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltro = myList;
            }
                grillaArticulos.DataSource = null;
                grillaArticulos.DataSource = listaFiltro;

        }

        private void flechitaD_Click(object sender, EventArgs e)
        {
            Articulo item = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;

            if(ubicacion>=item.Imagenes.Count-1)
            {
                ubicacion = 0;
            }
            else
            {
                ubicacion++;
            }
                try
                {
                    pbxImagen.Load(item.Imagenes[ubicacion].Url);
               
            }

                catch
                {

                    pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");
                //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 
                
            }



            lblImagen.Text = (ubicacion + 1).ToString();
        }

        private void flechitaIzq_Click(object sender, EventArgs e)
        {
            Articulo item = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;
          
            if (ubicacion <= 0)
            {
                ubicacion = item.Imagenes.Count-1;
            }else
            {
                ubicacion--;
            }
            
                try
                {
                    pbxImagen.Load(item.Imagenes[ubicacion].Url);
                
            }

                catch
                {

                    pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");
               
                //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 
            }
           
            
            lblImagen.Text = (ubicacion+1).ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frnAgregar ventanaAgregar = new frnAgregar();
            ventanaAgregar.ShowDialog();
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();

            try
            {
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltrarA.Text;
                grillaArticulos.DataSource = negocio.Filtrar(campo, criterio, filtro);  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if(opcion=="Número")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Igual a");
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Contiene");
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
            }

        }
    }
}
