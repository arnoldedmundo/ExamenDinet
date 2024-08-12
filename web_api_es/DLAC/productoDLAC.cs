using Microsoft.Data.SqlClient;
using System.Data;
using web_api_es.Models;

namespace web_api_es.DLAC
{
    public class productoDLAC
    {
        public IEnumerable<Producto> listado()
        {
            List<Producto> seller = new List<Producto>();
            using (SqlConnection cn = new conexionDLAC().getcn)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("listar_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    seller.Add(new Producto()
                    {
                        
                        Id = dr.GetInt32(0),
                        Fecha_Creacion = dr.GetString(1),
                        Nombre = dr.GetString(2),
                        Precio = dr.GetString(3),
                    });
                }
            }
            return seller;
        }
        public string insertar(Producto reg)
        {
            string mensaje = "";
            using (SqlConnection cn = new conexionDLAC().getcn)
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("registrar_producto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", reg.Id));
                    cmd.Parameters.Add(new SqlParameter("@nombre", reg.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Precio", reg.Precio));
                    cmd.Parameters.Add(new SqlParameter("@echa_Creacion", reg.Fecha_Creacion));
                    cmd.ExecuteNonQuery();
                    mensaje = "Produicto Registrado";
                }
                catch (Exception ex) { mensaje = ex.Message; }
                finally { cn.Close(); }
            }
            return mensaje;
        }
        

    }
}
