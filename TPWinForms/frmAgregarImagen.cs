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
    public partial class frmAgregarImagen : Form
    {
        private Articulo obj;
        public frmAgregarImagen()
        {
            InitializeComponent();
        }
        public frmAgregarImagen(Articulo obj)
        {
            InitializeComponent();
            this.obj = obj;

        }

        private void frmAgregarImagen_Load(object sender, EventArgs e)
        {
            NegocioImagen lista = new NegocioImagen();
            gvImagenes.DataSource = lista.Listar(obj.Id);
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            try
            {
                pbxImagen.Load(tbUrl.Text);
            }

            catch
            {

                pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");
                //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 
            }
        }
        void Cargar()
        {
            try
            {

                pbxImagen.Load(tbUrl.Text);



            }

            catch
            {

                pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");
                //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            if (tbUrl.Text.Length == 0)
            {
                negocio.agregarImagenUrl(obj.Id, "https://www.tibs.org.tw/images/default.jpg");
            }
            else
            {
                negocio.agregarImagenUrl(obj.Id, tbUrl.Text);
            }


            //negocio.ModificarArticulo(obj);
            Close();

        }

        private void gvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            Imagen item = (Imagen)gvImagenes.CurrentRow.DataBoundItem;
            try
            {
                pbxImagen.Load(item.Url);
            }

            catch
            {

                pbxImagen.Load("https://www.tibs.org.tw/images/default.jpg");
                //pbxImagen.Load("https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450"); 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            Imagen item = (Imagen)gvImagenes.CurrentRow.DataBoundItem;
            negocio.EliminarImg(item.Id);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
