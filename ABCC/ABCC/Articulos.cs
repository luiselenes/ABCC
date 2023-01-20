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
        private int? sku;
        public Articulos(int? sku=null)
        {
            InitializeComponent();
            this.sku = sku;
            if(this.sku != null)
                LoadData();
        }
        private void LoadData()
        {
            ArticuloDB articuloDB= new ArticuloDB();
            Articulo articulo = articuloDB.Get((int)sku);
            txtsku.Text = articulo.sku.ToString();
            txtarticulo.Text = articulo.articulo.ToString();
            txtmarca.Text= articulo.marca.ToString();
            txtmarca.Text = articulo.marca.ToString();
            txtmodelo.Text = articulo.modelo.ToString();
            cbdepartamento.Text=articulo.departamento.ToString();
            cbclase.Text= articulo.clase.ToString();
            cbfamilia.Text= articulo.familia.ToString();
            txtstock.Text= articulo.stock.ToString();
            txtcantidad.Text=articulo.cantidad.ToString();
            dtpalta.Text=articulo.fecha_alta.ToString();
            dtpbaja.Text=articulo.fecha_baja.ToString();
        }

        //private void Articulos_Load(object sender, EventArgs e)
        //{
        //    ArticuloDB artdb = new ArticuloDB();
        //    List<Articulo> artlit = artdb.Get();
            
        //    cbdepartamento
        //    artlit..departamento.ToString();
        //    cbclase.Text = artlit.clase.ToString();
        //    cbfamilia.Text = artlit.familia.ToString();
        //}

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
    }
}
