using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            _businessLogin = new BusinessLoginUser();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        BusinessLoginUser _businessLogin;

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string password = txtPassword.Text;

            if (dni.Length is 0)
            {
                lblErrorDni.Text = "Debe Ingresar DNI";
                lblErrorDni.Visible = true;
                return;
            }

            if (password.Length is 0)
            {
                lblErrorPass.Text = "Debe Ingresar Password";
                lblErrorPass.Visible = true;
                return;
            }

            if (!int.TryParse(dni, out int _))
            {
                lblErrorDni.Text = "Formato del Dni Incorrecto, Ingrese solo numeros";
                lblErrorDni.Visible = true;
                return;
            }


            EntityLoginUser user = _businessLogin.Login(password, Convert.ToInt32(dni));

            if (user is null)
            {
                lblErrorDni.Text = "Verifique DNI";
                lblErrorDni.Visible = true;
                lblErrorPass.Text = "Verifique Password";
                lblErrorPass.Visible = true;
                return;
            }

            if (user.Admin)
            {
                // Redireccion a vista admin
                FormAdministrador formInicioAdmin = new FormAdministrador(user);
                formInicioAdmin.Show();
                this.Hide();
                return;
            }

            // Redireccion a vista cliente
            FormCliente formCliente =  new FormCliente(user);
            formCliente.Show();
            this.Hide();
            return;
        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            if (lblErrorDni.Visible)
            {
                lblErrorDni.Text = "";
                lblErrorDni.Visible = false;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (lblErrorPass.Visible)
            {
                lblErrorPass.Text = "";
                lblErrorPass.Visible = false;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }

        public void LimpiarCampos()
        {
            txtDni.Text = "";
            txtPassword.Text = "";
        }
    }
}
