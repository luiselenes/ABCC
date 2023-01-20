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
        private void btneditar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;


            opcion = MessageBox.Show("¿Seguro que desea actualiazar?", "Actualizar Articulo", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                int? sku = Getsku();
                if (sku != null)
                {
                    Editar frmedit = new Editar(sku);
                    frmedit.ShowDialog();
                    Refresh();
                }
            }
        }
        private void Refresh()
        {
            ArticuloDB articuloDB= new ArticuloDB();
            dataGridView2.DataSource = articuloDB.Get();
        }

   

        private void consulta_Load_1(object sender, EventArgs e)
        {
            Refresh();

        }
        private int? Getsku() {
            try
            {
                return int.Parse(
                    dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch { return null; }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            
            
            opcion =  MessageBox.Show("¿Seguro que desea eliminar?", "Eliminar Articulo", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                int? sku = Getsku();
                try
                {
                    if (sku != null)
                    {
                        ArticuloDB articuloDB = new ArticuloDB();
                        articuloDB.Delete((int)sku);
                        Refresh();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("ocurrio un error al tratar de eliminar: " + ex.Message);
                }
            }
        }
    }
}

