using Bunifu.UI.WinForms;
using Business;
using Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormDetalles : ServiceForm
    {
        FormAdministrador _administrador;
        public FormDetalles(FormAdministrador administrador)
        {
            _administrador = administrador;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargarCmb();
            crearDG();
            
        }

        BusinessVenta gestorVenta = new BusinessVenta();
        BusinessProducto gestorProducto = new BusinessProducto();
        BusinessCliente gestorClientes = new BusinessCliente();

        private void crearDG()
        {
            DGdetallesView.AutoGenerateColumns = false;
            DGdetallesView.Columns.Add("NombreProducto", "Nombre Producto");
            DGdetallesView.Columns.Add("Cantidad", "Cantidad");
            DGdetallesView.Columns.Add("Sub total", "Sub total");
            DGventaView.AutoGenerateColumns = false;
            DGventaView.Columns.Add("Cliente", "Cliente");
            DGventaView.Columns.Add("Total", "Total");
            DGventaView.Columns.Add("Medio de Pago", "Medio de Pago");
            DGventaView.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            DGdetallesView.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
        }

        private void cargarCmb()
        {
            cmbDetalles.DataSource = gestorVenta.listarVentas().Data;
            cmbDetalles.DisplayMember = "Id";
        }

      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _administrador.Show();
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DGventaView.Rows.Clear();

            foreach (var item in gestorVenta.listarVentas().Data)
            {
                if (item.Id.ToString() == cmbDetalles.Text)
                {
                    EntityCliente cliente = gestorClientes.listar().Data.FirstOrDefault(cl => cl.Dni == item.ID_Cliente);
                    DGventaView.Rows.Add(cliente.Nombre + "" + cliente.Apellido, item.Total, item.Fecha);
                }
            }

            DGdetallesView.Rows.Clear();
            foreach (var item in gestorVenta.listarDetalles(cmbDetalles.Text).Data)
            {
                EntityProducto prod = gestorProducto.listar().Data.FirstOrDefault(producto => item.Id_Producto == producto.Id);
                DGdetallesView.Rows.Add(prod.Nombre, item.CantProducto, item.SubTotal);
            }
        }

        private void BtnGenerateXML_Click(object sender, EventArgs e)
        {
            if (cmbDetalles.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe seleccionar un numero de venta");
                return;
            }

            gestorVenta.GenerateXML(Convert.ToInt32(cmbDetalles.Text));
        }
    }
}
