using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrigendeDatos
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebabd1DataSet1.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.pruebabd1DataSet1.productos);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form1 FL = new Form1();
            FL.Show();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            FormInventario fi = new FormInventario();
            fi.Show();
        }
    }
}
