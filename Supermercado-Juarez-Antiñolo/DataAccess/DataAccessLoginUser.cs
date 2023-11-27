using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccessLoginUser
    {

        private readonly DBConnection conect;

        public DataAccessLoginUser()
        {
            conect = DBConnection.GetInstance;
        }

        public EntityLoginUser Login(string pass, int dni)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@In_id_cliente", SqlDbType.Int){ Value = dni },
                new SqlParameter("@In_password", SqlDbType.NVarChar){ Value = pass }
            };

            DataTable data = conect.Read("sp_login", parameters);

            if (data.Rows.Count == 0) return null;

            EntityLoginUser user = new EntityLoginUser();
            user.UserId = Convert.ToInt32(data.Rows[0]["user_id"]);
            user.IdCliente = Convert.ToInt32(data.Rows[0]["id_cliente"]);
            user.Admin = Convert.ToBoolean(data.Rows[0]["admin"]);
            user.Nombre = data.Rows[0]["nombre"].ToString();
            user.Apellido = data.Rows[0]["apellido"].ToString();

            return user;
        }

        public bool Register(EntityCliente cliente, string password)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@In_dni", SqlDbType.Int){ Value = cliente.Dni },
                new SqlParameter("@In_nombre", SqlDbType.NVarChar){ Value = cliente.Nombre },
                new SqlParameter("@In_apellido", SqlDbType.NVarChar){ Value = cliente.Apellido },
                new SqlParameter("@In_telefono", SqlDbType.NVarChar){ Value = cliente.Telefono },
                new SqlParameter("@In_password", SqlDbType.NVarChar){ Value = password }
            };

            return conect.Write("sp_create_user", parameters);
        }

    }
}
