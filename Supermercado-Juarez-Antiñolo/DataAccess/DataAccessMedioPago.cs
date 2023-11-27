using Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessMedioPago
    {

        private readonly DBConnection conn;

        public DataAccessMedioPago()
        {
            conn = DBConnection.GetInstance;
        }

        public bool delete(EntityMedioPago medioPago)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("In_nro_tarjeta" , medioPago.NroTarjeta),
            };
            return conn.Write("delete_medio_pago", parameters);
        }

        public bool insert(EntityMedioPago medioPago)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_id_cliente" , medioPago.Id_cliente),
                new SqlParameter("In_tipo_tarjeta" , medioPago.Id_Tipo_Tarjeta),
                new SqlParameter("In_nro_tarjeta" , medioPago.NroTarjeta),
                new SqlParameter("In_fecha_caducidad", medioPago.FechaCaducidad),
                new SqlParameter("In_cvv" , medioPago.Cvv)
            };
            return conn.Write("insert_medio_pago", parameters);
        }

        public List<EntityMedioPago> selectAll()
        {
            List<EntityMedioPago> list = new List<EntityMedioPago>();
            DataTable table = new DataTable();
            table = conn.Read("select_medio_pago", null);
            foreach (DataRow registro in table.Rows)
            {
                EntityMedioPago medio = SqlMapper.MapMedioPago(registro);
                list.Add(medio);
            }
            return list;
        }

        public List<EntityTipoTarjeta> selectTipoTarjeta()
        {
            List<EntityTipoTarjeta> list = new List<EntityTipoTarjeta>();

            DataTable table = new DataTable();
            table = conn.Read("select_tipo_tarjeta", null);
            foreach (DataRow registro in table.Rows)
            {
                EntityTipoTarjeta tipo = SqlMapper.MapTipoTarjeta(registro);
                list.Add(tipo);
            }
            return list;
        }

        public bool Update(EntityMedioPago medioPago)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("In_id_cliente", medioPago.Id_cliente),
                new SqlParameter("In_tipo_tarjeta" , medioPago.Id_Tipo_Tarjeta),
                new SqlParameter("In_nro_tarjeta", medioPago.NroTarjeta),
                new SqlParameter("In_fecha_caducidad" , medioPago.FechaCaducidad),
                new SqlParameter("In_cvv", medioPago.Cvv)
            };
            return conn.Write("update_medio_pago", parameters);
        }
    }
}
