using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace coneccion_SQL_v
{
    public class Conexionsql
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexionsql()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=bondAPPetite;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");

            }
            catch(Exception ex) 
            {
            MessageBox.Show("No se conectó con la base de datos: " + ex.ToString());
            }
        }


        
        public int roll_id = 1;
        public DateTime fechaDeRegistro = DateTime.Now;
        public Byte Activo = 1;

        public string Insertar(string nombre, string email, string password, int rol_id, DateTime fechaDeRegistro, Byte Activo,  string telefono, string dni)
        {
            
            string salida = "Usuario creado correctamente";
            try
            {
                cmd = new SqlCommand("Insert into Usuario(nombre,email,password,rol_id,fechaDeRegistro,Activo,telefono,dni) values('" + nombre + "','" + email + "','" + password + "', "+rol_id+",'" + fechaDeRegistro + "',"+Activo+",'" + telefono + "','" + dni + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se creó el usuario: " + ex.ToString();
            }
            return salida;
           
        }

        public int UsuarioRegistrado(int dni)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Usuario where dni='" + dni + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: " + ex.ToString());
            }

            return contador;
        }
    }
}
