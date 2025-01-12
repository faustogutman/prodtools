using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdTools
{
    public partial class likeexceltable : Form
    {
        Conexion c = new Conexion();
        public likeexceltable()
        {
            InitializeComponent();
            Conexion c = new Conexion();
            c.cargarEspecialidades(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.cargarEspecialidades(dataGridView1);
        }
    }
}
