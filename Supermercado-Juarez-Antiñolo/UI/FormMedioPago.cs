using Business;
using Entity;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMedioPago : ServiceForm
    {
        FormCliente _formCliente;
        EntityLoginUser _user;

        public FormMedioPago(FormCliente formCliente, EntityLoginUser user)
        {
            _formCliente = formCliente;
            _user = user;
            InitializeComponent();
        }


        BusinessMedioPago gestor = new BusinessMedioPago();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _formCliente.Show();
            this.Close();
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntityTipoTarjeta tarj = (EntityTipoTarjeta)lbl_cmb.cmb.SelectedItem;
                EntityMedioPago medio = new EntityMedioPago
                {
                    Id_cliente = _user.IdCliente,
                    NroTarjeta = int.Parse(lbl_txtBox.txt.Text),
                    FechaCaducidad = datePick.Value,
                    Cvv = int.Parse(txtCvv.Text),
                    Id_Tipo_Tarjeta = tarj.Id,
                };
                this.RevisarRespuestaServicio(gestor.agregar(medio));
            }
            catch
            {
                MessageBox.Show("Rellene Campos o arregle formato");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntityMedioPago medio = new EntityMedioPago();
                medio.NroTarjeta = int.Parse(lbl_txtBox.txt.Text);
                this.RevisarRespuestaServicio(gestor.eliminar(medio));
            }
            catch
            {
                MessageBox.Show("Error en el formato");
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EntityTipoTarjeta tarj = (EntityTipoTarjeta)lbl_cmb.cmb.SelectedItem;
                EntityMedioPago medio = new EntityMedioPago
                {
                    Id_cliente = _user.IdCliente,
                    NroTarjeta = int.Parse(lbl_txtBox.txt.Text),
                    FechaCaducidad = datePick.Value,
                    Cvv = int.Parse(txtCvv.Text),
                    Id_Tipo_Tarjeta = tarj.Id,
                };
                this.RevisarRespuestaServicio(gestor.modificar(medio));
            }
            catch
            {
                MessageBox.Show("Rellene Campos o arregle formato");
            }
        }

        private void FormMedioPago_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            lbl_cmb.cmb.DataSource = gestor.tiposTarjeta;
            lbl_cmb.cmb.DisplayMember = "Nombre";
            lbl_txtBox.lbl.Text = "Numero de Tarjeta";
            lbl_cmb.lbl.Text = "Tipo Tarejta";
        }
    }
}
