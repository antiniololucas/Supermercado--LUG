using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityLoginUser : EntityCliente
    {
		private int _userId;

		public int UserId
		{
			get { return _userId; }
			set { _userId = value; }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		private int _idCliente;

		public int IdCliente
		{
			get { return _idCliente; }
			set { _idCliente = value; }
		}

		private bool _admin;

		public bool Admin
		{
			get { return _admin; }
			set { _admin = value; }
		}
	}
}
