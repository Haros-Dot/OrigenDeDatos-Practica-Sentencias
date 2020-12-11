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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebabd1DataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.pruebabd1DataSet.usuarios);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btninv_Click(object sender, EventArgs e)
        {
            FormInventario fi = new FormInventario();
            fi.Show();
            
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            FormProductos fp = new FormProductos();
            fp.Show();
        }
    }
}
