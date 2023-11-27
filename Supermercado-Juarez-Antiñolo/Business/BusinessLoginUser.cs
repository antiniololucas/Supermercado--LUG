using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessLoginUser
    {
        private readonly DataAccessLoginUser _dataAccesLoginUser;

        public BusinessLoginUser()
        {
            _dataAccesLoginUser = new DataAccessLoginUser();
        }

        public EntityLoginUser Login(string password, int dni)
        {
            string passHash = EncryptPass(password);

            return _dataAccesLoginUser.Login(passHash, dni);
        }

        public bool Register(EntityCliente cliente, string password)
        {
            string passHash = EncryptPass(password);

            return _dataAccesLoginUser.Register(cliente, passHash);
        }

        private string EncryptPass(string pass)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            StringBuilder sb = new StringBuilder();

            byte[] stream = sha256.ComputeHash(encoding.GetBytes(pass));

            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }
    }
}
