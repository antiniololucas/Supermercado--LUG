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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador(EntityLoginUser user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            businessVenta = new BusinessVenta();
            MostrarMetricas();
            lblSaludo.Text = $"{user.Nombre} {user.Apellido}!";
        }

        BusinessVenta businessVenta;

        private void MostrarMetricas()
        {
            MetricaUltimaSemana metricaUltimaSemana = businessVenta.ObtenerMetricas();
            lblTotalRecaudado.Text += $"${metricaUltimaSemana.TotalRecaudado.ToString("N2")}";
            lblCantidadVentas.Text += metricaUltimaSemana.CantidadProducto.ToString(); 
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormGestionCliente frm = new FormGestionCliente(this);
            frm.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProducto frm = new FormProducto(this);
            frm.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormDetalles frm = new FormDetalles(this);
            frm.Show();
            this.Hide();
        }

        private void btnGenerarXML_Click(object sender, EventArgs e)
        {
            bool isGenerated = businessVenta.GenerarMetricasXML();
            if (isGenerated) 
            {
                MessageBox.Show("Descargado con exito");
                return;
            }

            MessageBox.Show("Error al descargar");
            return;
        }
    }
}
