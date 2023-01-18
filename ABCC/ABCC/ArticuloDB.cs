using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace ABCC
{
    public class ArticuloDB
    {
        private string connerctionString
            = "Data Source=localhost;initial Catalog=ABCC;" +
            "User=sa;Password=123";


        public List<Articulo> Get()
        {
            List<Articulo> articulos = new List<Articulo>();
            string query = "select * from Articulos";
            using (SqlConnection connection = new SqlConnection(connerctionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Articulo art = new Articulo();
                        art.sku = reader.GetInt32(0);
                        art.articulo = reader.GetString(1);
                        art.marca = reader.GetString(2);
                        art.modelo = reader.GetString(3);
                        art.departamento = reader.GetInt32(4);
                        art.clase = reader.GetInt32(5);
                        art.familia = reader.GetInt32(6);
                        art.fecha_alta = reader.GetDateTime(7);
                        art.stock = reader.GetDouble(8);
                        art.cantidad = reader.GetDouble(9);
                        art.descontinuado = reader.GetBoolean(10);
                        //art.fecha_baja = reader.GetDateTime(11);


                        articulos.Add(art);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en query " + ex.Message);
                }
            }

            return articulos;
        }

        public void Add(int sku, string articulo, string marca, string modelo,
                        int departamento, int clase, int familia, DateTime fecha_alta,
                        double stock, double cantidad, bool descontinuado, DateTime fecha_baja)
        {
            string query = "insert into articulos (sku,articulo,marca,modelo,idDepartamento,idClase,idFamilia,fecha_alta,stock,cantidad,descontinuado,fecha_baja) values " +
            "( @sku,@articulo,@marca,@modelo,@idDepartamento,@idClase,@idFamilia,@fecha_alta,@stock,@cantidad,@descontinuado,@fecha_baja )";
            using (SqlConnection connection = new SqlConnection(connerctionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sku", sku);
                command.Parameters.AddWithValue("@articulo", articulo);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@modelo", modelo);
                command.Parameters.AddWithValue("@idDepartamento", departamento);
                command.Parameters.AddWithValue("@idClase", clase);
                command.Parameters.AddWithValue("@idFamilia", familia);
                command.Parameters.AddWithValue("@fecha_alta", fecha_alta);
                command.Parameters.AddWithValue("@stock", stock);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@descontinuado", descontinuado);
                command.Parameters.AddWithValue("@fecha_baja", fecha_baja);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en query " + ex.Message);
                }
            }
        }

        public void Update(int sku, string articulo, string marca, string modelo,
                       int departamento, int clase, int familia, DateTime fecha_alta,
                       double stock, double cantidad, bool descontinuado, DateTime fecha_baja)
        {
            string query = "update articulos set " +
                "articulo= @articulo," +
                "marca=@marca," +
                "modelo=@modelo," +
                "idDepartamento=@idDepartamento," +
                "idClase=@idClase," +
                "idFamilia=@idFamilia," +
                "fecha_alta=@fecha_alta," +
                "stock=@stock," +
                "cantidad=@cantidad," +
                "descontinuado=@descontinuado," +
                "fecha_baja=@fecha_baja" +
                " where sku=@sku";

            using (SqlConnection connection = new SqlConnection(connerctionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sku", sku);
                command.Parameters.AddWithValue("@articulo", articulo);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@modelo", modelo);
                command.Parameters.AddWithValue("@idDepartamento", departamento);
                command.Parameters.AddWithValue("@idClase", clase);
                command.Parameters.AddWithValue("@idFamilia", familia);
                command.Parameters.AddWithValue("@fecha_alta", fecha_alta);
                command.Parameters.AddWithValue("@stock", stock);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@descontinuado", descontinuado);
                command.Parameters.AddWithValue("@fecha_baja", fecha_baja);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en query " + ex.Message);
                }
            }
        }

        public void Delete(int sku, string articulo, string marca, string modelo,
                      int departamento, int clase, int familia, DateTime fecha_alta,
                      double stock, double cantidad, bool descontinuado, DateTime fecha_baja)
        {
            string query = "Delete from articulos" +
                " where sku=@sku";

            using (SqlConnection connection = new SqlConnection(connerctionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sku", sku);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en query " + ex.Message);
                }
            }
        }


        public Articulo GetArticulo(int sku)
        {
            string query = "select * from Articulos" +
                " where sku=@sku";
            using (SqlConnection connection = new SqlConnection(connerctionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sku", sku);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    Articulo art = new Articulo();
                    art.sku = reader.GetInt32(0);
                    art.articulo = reader.GetString(1);
                    art.marca = reader.GetString(2);
                    art.modelo = reader.GetString(3);
                    art.departamento = reader.GetInt32(4);
                    art.clase = reader.GetInt32(5);
                    art.familia = reader.GetInt32(6);
                    art.fecha_alta = reader.GetDateTime(7);
                    art.stock = reader.GetDouble(8);
                    art.cantidad = reader.GetDouble(9);
                    art.descontinuado = reader.GetBoolean(10);
                    //art.fecha_baja = reader.GetDateTime(11);
                    reader.Close();
                    connection.Close();
                    return art;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en query " + ex.Message);
                }
            }
        }


        public bool Exists(int sku)
        {
            string query = "IF EXISTS (SELECT * FROM Articulos WHERE sku = " + sku +") BEGIN " +
                " SELECT 1 " +
                " END" +
                " ELSE BEGIN SELECT 0 END";
            int res=0;
            using (SqlConnection connection = new SqlConnection(connerctionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sku", sku);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                   Articulo art = new Articulo();
                   res = reader.GetInt32(0);

                    if (res == 0)
                    {
                        reader.Close();
                        connection.Close();
                        return false;
                    }
                    reader.Close();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en query " + ex.Message);
                }
            }

        }

    }
    public class Articulo
    {
        public int sku { get; set; }
        public string articulo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int departamento { get; set; }
        public int clase { get; set; }
        public int familia { get; set; }
        public DateTime fecha_alta { get; set; }
        public double stock { get; set; }
        public double cantidad { get; set; }
        public bool descontinuado { get; set; }
        public DateTime fecha_baja { get; set; }

        
    }
}
 
