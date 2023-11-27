using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Business;
using Entity;

namespace UI
{
    public partial class Register : Form
    {
        private Login _loginForm;
        private readonly BusinessLoginUser _businessLogin;

        public Register(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _businessLogin = new BusinessLoginUser();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            bool isOk = ValidateAllFields();

            if (!isOk) return;

            EntityCliente cliente = new EntityCliente
            {
                Dni = Convert.ToInt32(txtDni.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = Convert.ToInt32(txtTelefono.Text)
            };

            bool save = _businessLogin.Register(cliente, TxtPassword.Text);

            if (!save)
            {
                MessageBox.Show("Error al registrarse");
                return;
            }

            btnVolver_Click();
        }

        private void btnVolver_Click(object sender = null, EventArgs e = null)
        {
            _loginForm.LimpiarCampos();
            _loginForm.Show();
            this.Hide();
        }

        private bool validatePasswordFormat(string password)
        {
            return !string.IsNullOrEmpty(password) && !Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[.@#_$]).*$");
        }

        private bool ValidateAllFields()
        {
            bool isOk = true;

            isOk &= ValidateRequiredField(txtNombre, lblErrorNombre);
            isOk &= ValidateRequiredField(txtApellido, lblErrorApellido);
            isOk &= ValidateRequiredField(txtTelefono, lblErrorTelefono);

            if (!int.TryParse(txtDni.Text, out _))
            {
                lblErrorDni.Text = txtDni.Text.Length == 0 ? "Debe Ingresar DNI" : "Formato del DNI Incorrecto, Ingrese solo números";
                lblErrorDni.Visible = true;
                isOk = false;
            }

            if (!int.TryParse(txtTelefono.Text, out _))
            {
                lblErrorTelefono.Text = txtTelefono.Text.Length == 0 ? "Debe Ingresar Telefono" : "Formato del Telefono Incorrecto, Ingrese solo números";
                lblErrorTelefono.Visible = true;
                isOk = false;
            }

            isOk &= ValidateRequiredField(TxtPassword, lblErrorPassword);
            isOk &= ValidateRequiredField(TxtPasswordRepeated, lblErrorPasswordRepeated);

            if (validatePasswordFormat(TxtPassword.Text) && TxtPassword.Text.Length != 0)
            {
                lblErrorPassword.Text = "Verifique formato: una mayúscula y .@#_$ ";
                lblErrorPassword.Visible = true;
                isOk = false;
            }

            if (TxtPassword.Text != TxtPasswordRepeated.Text)
            {
                lblErrorPasswordRepeated.Text = "No coinciden las contraseñas";
                lblErrorPasswordRepeated.Visible = true;
                isOk = false;
            }

            return isOk;
        }

        private bool ValidateRequiredField(BunifuTextBox textBox, BunifuLabel errorLabel)
        {
            if (textBox.Text.Length == 0)
            {
                errorLabel.Visible = true;
                return false;
            }
            errorLabel.Visible = false;
            return true;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            lblErrorNombre.Visible = false; 
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            lblErrorApellido.Visible = false;
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            lblErrorTelefono.Visible = false;
        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            lblErrorDni.Visible = false;
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            lblErrorPassword.Visible = false;
            lblErrorPassword.Text = "Debe Ingresar Password";
        }

        private void TxtPasswordRepeated_Click(object sender, EventArgs e)
        {
            lblErrorPasswordRepeated.Visible = false;
        }
    }
}
