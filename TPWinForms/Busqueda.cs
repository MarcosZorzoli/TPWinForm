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
    public partial class Busqueda : Form
    {
        public string palabra { set; get; }
        public int ID { set; get; }

        public Busqueda(int op)
        {
            InitializeComponent();
            if (op == 1) 
            {
                labelBusqueda1.Visible = true;
            }
            else if (op == 2)
            {
                labelBusqueda2.Visible = true;
            }
            else if (op == 3) 
            { 
                labelBusqueda3.Visible = true;
            }
            else 
            {
                labelBusqueda4.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                         if (string.IsNullOrEmpty(textBox1.Text))
                         {
                             MessageBox.Show("Primero ingrese información");
                         }
                         else
                         {
                             palabra = textBox1.Text;
                             this.DialogResult = DialogResult.OK;
                             this.Close();
                         }

             

        }

    }
}
