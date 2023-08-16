using Cafeteria.Models;
using System.Data.SqlClient;
using System.Data;

namespace Cafeteria.Datos
{
    public class CarreraDatos
    {
        public List<CarreraModel> ListarCarrera()
        {
            var oLista = new List<CarreraModel>();
            var al = new Conexion();
            using (var conexion = new SqlConnection(al.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ListarCarra", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new CarreraModel()
                        {
                            Codigo= Convert.ToInt32(dr["Codigo"]),
                            Nombre = Convert.ToInt32(dr["Nombre"]),

                        });
                    }
                }
            }
            return oLista;
        }
        //###################################################################################
        public CarreraModel BuscarCarrera(int Codigo)
        {
            var oCarrera = new CarreraModel();
            var al = new Conexion();
            using (var conexion = new SqlConnection(al.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_BuscarCarrera", conexion);
                cmd.Parameters.AddWithValue("Codigo", Codigo);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        oCarrera.Codigo = Convert.ToInt32(dr["Codigo"]);
                        oCarrera.Nombre = Convert.ToInt32(dr["Codigo"]);

                    }
                }
            }
            return oCarrera;
        }
        //#############################################################################################
        public bool RegistrarCarrera(CarreraModel model)
        {   //creo una variable boolean
            bool respuesta;
            try
            {
                var al = new Conexion();
                //utilizar using para establecer la cadena de conexion
                using (var conexion = new SqlConnection(al.getCadenaSql()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCarrera", conexion);
                    //enviando un parametro al procedimiento almacenado
                    cmd.Parameters.AddWithValue("Codigo", model.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", model.Nombre);
                    //ejecutar el prrocedimiento almacenado
                    cmd.ExecuteNonQuery();

                    respuesta = true;
                }
            }
            catch (Exception e)
            {
                string error = e.Message;
                respuesta = false;
            }
            return respuesta;
        }
        //#########################################################################################
        public bool EditarCarrera(CarreraModel model)
        {   //creo una variable boolean
            bool respuesta;
            try
            {
                var al = new Conexion();
                //utilizar using para establecer la cadena de conexion
                using (var conexion = new SqlConnection(al.getCadenaSql()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_EditarCarrera", conexion);
                    //enviando un parametro al procedimiento almacenado
                    cmd.Parameters.AddWithValue("Codigo", model.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", model.Nombre);
                    //ejecutar el prrocedimiento almacenado
                    cmd.ExecuteNonQuery();

                    respuesta = true;
                }
            }
            catch (Exception e)
            {
                string error = e.Message;
                respuesta = false;
            }
            return respuesta;
        }
        ///#########################################################################################
        public bool EliminarCarrera(int Codigo)
        {   //creo una variable boolean
            bool respuesta;
            try
            {
                var al = new Conexion();
                //utilizar using para establecer la cadena de conexion
                using (var conexion = new SqlConnection(al.getCadenaSql()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_EliminarCarrera", conexion);
                    //enviando un parametro al procedimiento almacenado
                    cmd.Parameters.AddWithValue("Codigo", Codigo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //ejecutar el prrocedimiento almacenado
                    cmd.ExecuteNonQuery();

                    respuesta = true;
                }
            }
            catch (Exception e)
            {
                string error = e.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}
