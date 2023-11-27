using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessCiente
    {

        private readonly DBConnection conn;

        public DataAccessCiente()
        {
            conn = DBConnection.GetInstance;
        }

        public bool delete(EntityCliente cliente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_dni" , cliente.Dni)
            };
            return conn.Write("delete_cliente", parameters);
        }

        public bool Insert(EntityCliente cliente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_dni" , cliente.Dni),
                new SqlParameter("In_nombre" , cliente.Nombre),
                new SqlParameter("In_apellido" , cliente.Apellido),
                new SqlParameter("In_telefono" , cliente.Telefono),
            };
            return conn.Write("insert_cliente", parameters);
        }

        public List<EntityCliente> SelectAll()
        {
            DataTable table = conn.Read("select_cliente", null);
            List<EntityCliente> list = new List<EntityCliente>();
            foreach (DataRow registro in table.Rows)
            {
                EntityCliente cliente = SqlMapper.MapCliente(registro);
                list.Add(cliente);
            }
            return list;
        }

        public bool Update(EntityCliente cliente)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_dni" , cliente.Dni),
                new SqlParameter("In_nombre" , cliente.Nombre),
                new SqlParameter("In_apellido" , cliente.Apellido),
                new SqlParameter("In_telefono" , cliente.Telefono)
            };
            return conn.Write("update_cliente", parameters);
        }

        public bool xml()
        {
            return conn.WriteXml("select_cliente", "Clientes.xml");
        }
    }
}
