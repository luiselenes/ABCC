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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
       
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
                ArticuloDB artdb= new ArticuloDB();
            try
            {
                artdb.Add(int.Parse(txtsku.Text), txtarticulo.Text, txtmarca.Text, 
                            txtmodelo.Text, int.Parse(cbdepartamento.Text), 
                            int.Parse(cbclase.Text), int.Parse(cbfamilia.Text),
                            DateTime.Parse(dtpalta.Text), double.Parse(txtstock.Text),
                            double.Parse(txtcantidad.Text),checkdescontinuado.Checked,DateTime.Parse(dtpbaja.Text)
                            );
                MessageBox.Show("Guardado con exito");
                Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("ocurrio un error al guardar: "+ex.Message);
            }


        }

        private void cbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
