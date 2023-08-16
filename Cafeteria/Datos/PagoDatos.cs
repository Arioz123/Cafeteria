using Cafeteria.Models;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Cafeteria.Datos
{
    public class PagoDatos
    {
        public List<PagoModel> ListarPago()
        {
            var oLista = new List<PagoModel>();
            var al = new Conexion();
            using (var conexion = new SqlConnection(al.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_ListarPago", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new PagoModel()
                        {
                            id = Convert.ToInt32(dr["id"]),
                            id_Alumno = Convert.ToInt32(dr["Nombre"]),
                            Fecha = Convert.ToDateTime(dr["Apellido"]),
                            Monto = Convert.ToDecimal(dr["Monto"]),

                        }) ;
                    }
                }
            }
            return oLista;
        }
         public PagoModel BuscarPago(int id)
        {
            var oPago = new PagoModel();
            var al = new Conexion();
            using (var conexion = new SqlConnection(al.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_BuscarPago", conexion);
                cmd.Parameters.AddWithValue("id", id);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        
                        oPago.id = Convert.ToInt32(dr["id"]);
                        oPago.id_Alumno = Convert.ToInt32(dr["id_Alumno"]);
                        oPago.Fecha = Convert.ToDateTime(dr["Fecha"]);
                        oPago.Monto = Convert.ToDecimal(dr["Monto"]);
                        
                    }
                }
            }
            return oPago;
        }

        internal bool Registrarpago(PagoModel model)
        {
            throw new NotImplementedException();
        }

    }
}
