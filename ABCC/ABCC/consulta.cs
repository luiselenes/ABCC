using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCC
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void consulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void Refresh()
        {
            ArticuloDB articuloDB= new ArticuloDB();
            dataGridView2.DataSource = articuloDB.Get();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void consulta_Load_1(object sender, EventArgs e)
        {
            Refresh();

        }
    }
}
