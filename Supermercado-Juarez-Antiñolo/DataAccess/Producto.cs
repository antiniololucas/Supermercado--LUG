using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    
    public class Producto
    {
        DBConnection conect = new DBConnection();

        public bool Create(Entity.Producto producto)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("In_nombre", producto.Nombre);
            parameters[1] = new SqlParameter("In_descripcion", producto.Descripcion);
            parameters[2] = new SqlParameter("In_id_categoria", producto.Id_Categoria);
            parameters[3] = new SqlParameter("In_precio", producto.Precio);
            parameters[4] = new SqlParameter("In_stock", producto.Stock);
            return conect.Write("insert_producto" , parameters);
        }

        public bool delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("In_id", id);
            return conect.Write("delete_Producto", parameters);
        }

        public List<Entity.Producto> listar()
        {
            List<Entity.Producto> list = new List<Entity.Producto>();
            DataTable table = new DataTable();
            table = conect.Read("select_Productos", null);
            foreach(DataRow registro in table.Rows)
            {
                Entity.Producto prod = new Entity.Producto();
                prod.Id =int.Parse(registro["id"].ToString());
                prod.Nombre = registro["nombre"].ToString();
                prod.Descripcion = registro["descripcion"].ToString();
                prod.Id_Categoria = int.Parse(registro["id_categoria"].ToString());
                prod.Precio = double.Parse(registro["precio"].ToString());
                prod.Stock = int.Parse(registro["stock"].ToString() );
                list.Add( prod );
            }
            return list;
        }
            
        public List<string> LoadCategorias()
        {
            List<string> list = new List<string>();
            DataTable table = new DataTable();
            table = conect.Read("select_categoria", null);
            foreach (DataRow registro in table.Rows)
            {
                string nombre = registro["nombre"].ToString();
                list.Add(nombre);
            }
            return list;
        }

        public int obtenerIdCat(string nombre)
        {
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            int resultado = 0;
            parameters[0] = new SqlParameter("In_nombre" , nombre);
            table = conect.Read("select_id_categoria" , parameters);
            foreach (DataRow registro in table.Rows)
            {
                resultado = int.Parse(registro["id"].ToString());
            }
            return resultado;
        }

        public bool Update(Entity.Producto producto)
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("In_id", producto.Id);
            parameters[1] = new SqlParameter("In_nombre", producto.Nombre);
            parameters[2] = new SqlParameter("In_descripcion", producto.Descripcion);
            parameters[3] = new SqlParameter("In_id_categoria", producto.Id_Categoria);
            parameters[4] = new SqlParameter("In_precio", producto.Precio);
            parameters[5] = new SqlParameter("In_stock", producto.Stock);
            return conect.Write("update_producto", parameters);
        }
    }
}
