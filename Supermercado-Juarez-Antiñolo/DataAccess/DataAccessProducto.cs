using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{

    public class DataAccessProducto
    {

        private readonly DBConnection conect;

        public DataAccessProducto()
        {
            conect = DBConnection.GetInstance;
        }

        public bool Insert(Entity.EntityProducto producto)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_nombre", producto.Nombre),
                new SqlParameter("In_descripcion", producto.Descripcion),
                new SqlParameter("In_id_categoria", producto.Id_Categoria),
                new SqlParameter("In_precio", producto.Precio),
                new SqlParameter("In_stock", producto.Stock)
            };
            return conect.Write("insert_producto", parameters);
        }

        public bool Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("In_id", id);
            return conect.Write("delete_producto", parameters);
        }

        public List<EntityProducto> SelectAll()
        {
            List<EntityProducto> list = new List<EntityProducto>();
            DataTable table = new DataTable();
            table = conect.Read("select_Productos", null);
            foreach (DataRow registro in table.Rows)
            {
                EntityProducto prod = SqlMapper.MapProducto(registro);
                list.Add(prod);
            }
            return list;
        }

        public List<EntityCategoria> LoadCategorias()
        {
            List<EntityCategoria> list = new List<EntityCategoria>();
            DataTable table = new DataTable();
            table = conect.Read("select_categoria", null);
            foreach (DataRow registro in table.Rows)
            {
                EntityCategoria cat = SqlMapper.MapCategoria(registro);
                list.Add(cat);
            }
            return list;
        }


        public bool Update(EntityProducto producto)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("In_id", producto.Id),
            new SqlParameter("In_nombre", producto.Nombre),
            new SqlParameter("In_descripcion", producto.Descripcion),
            new SqlParameter("In_id_categoria", producto.Id_Categoria),
            new SqlParameter("In_precio", producto.Precio),
            new SqlParameter("In_stock", producto.Stock) };

            return conect.Write("update_producto", parameters);
        }

        public bool xml()
        {
            return conect.WriteXml("select_Productos", "Productos.xml");
        }
    }
}
