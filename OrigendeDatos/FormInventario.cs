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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form1 FL = new Form1();
            FL.Show();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebabd1DataSet1.inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.pruebabd1DataSet1.inventario);
            // TODO: esta línea de código carga datos en la tabla 'pruebabd1DataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.pruebabd1DataSet.usuarios);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            FormProductos fp = new FormProductos();
            fp.Show();
        }
    }
}
