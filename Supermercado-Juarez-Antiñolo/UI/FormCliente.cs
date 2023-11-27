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
    public partial class FormCliente : ServiceForm
    {
        EntityLoginUser _loginUser;
        public FormCliente(EntityLoginUser user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _loginUser = user;
            lblSaludo.Text = $"{user.Nombre} {user.Apellido}!";
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cargarCmb();
            crearDG();
            actualizar();
            cmbProducto.SelectedIndex = -1;
            lbl_numeric.lbl.Text = "Cantidad";
        }

        BusinessVenta gestor = new BusinessVenta();
        BusinessProducto gestorProducto = new BusinessProducto();
        BusinessCliente gestorClientes = new BusinessCliente();
        BusinessMedioPago GestorMedioPago = new BusinessMedioPago();

        int montoAcumulado;
        int ventaActual;

        private void crearDG()
        {
            DGdetalleView.AutoGenerateColumns = false;
            DGdetalleView.Columns.Add("NombreProducto", "Nombre Producto");
            DGdetalleView.Columns.Add("Cantidad", "Cantidad");
            DGdetalleView.Columns.Add("Sub total", "Sub total");
            DGdetalleView.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
        }

        private void actualizar()
        {
            ventaActual = gestor.getId();
            lblNroVenta.Text = ventaActual.ToString();
            montoAcumulado = 0;
            lblMonto.Text = "0";
            DGdetalleView.Rows.Clear();
            gestor.detallesActuales.Clear();
            lbl_numeric.numeric.Value = 1;
        }

        private void cargarCmb()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = gestorProducto.listar().Data;
            cmbProducto.DisplayMember = "Nombre";
            cmbTarjeta.Items.Clear();
            foreach (var item in GestorMedioPago.listar().Data)
            {
                if (item.Id_cliente == _loginUser.IdCliente)
                {
                    cmbTarjeta.Items.Add(item);
                }
                cmbTarjeta.DisplayMember = "NroTarjeta";
            }
        }


        private void mostrarLista()
        {
            DGdetalleView.Rows.Clear();
            montoAcumulado = 0;
            foreach (var item in gestor.detallesActuales)
            {
                DGdetalleView.Rows.Add(gestorProducto.listar().Data.FirstOrDefault(producto => item.Id_Producto == producto.Id).Nombre, item.CantProducto, item.SubTotal);
                montoAcumulado += item.SubTotal;
            }
            lblMonto.Text = montoAcumulado.ToString();
        }

        private void btnAgregarMedioPago_Click(object sender, EventArgs e)
        {
            FormMedioPago formMedioPago = new FormMedioPago(this, _loginUser);
            formMedioPago.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (montoAcumulado > 0)
            {
                foreach (var item in gestor.detallesActuales)
                {
                    CancelarProductoVenta(item);
                }
            }
            this.Close();
            Login frm = new Login();
            frm.Show();
        }

        private void CancelarProductoVenta(EntityDetalle item)
        {
            foreach (var producto in gestorProducto.listar().Data)
            {
                if (producto.Id == item.Id_Producto)
                {
                    producto.Stock += item.CantProducto;
                    gestorProducto.modificar(producto);
                }
            }
        }

        private void DGdetalleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex is -1) { return; }
            DialogResult res = MessageBox.Show("Desea borrar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                CancelarProductoVenta(gestor.detallesActuales[e.RowIndex]);
                gestor.detallesActuales.Remove(gestor.detallesActuales[e.RowIndex]);
                mostrarLista();
            }
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EntityProducto prod = (EntityProducto)cmbProducto.SelectedItem;
            lbl_numeric.numeric.Maximum = prod.Stock;
            if (prod.Stock <= 0) { MessageBox.Show("No hay stock del producto seleccionado"); cmbProducto.SelectedIndex = -1; }
        }

        private void btnFinalizarVentas_Click(object sender, EventArgs e)
        {
            if (montoAcumulado <= 0) { MessageBox.Show("Seleccione productos"); return; }
            EntityVenta venta = new EntityVenta
            {
                Id = ventaActual,
                ID_Cliente = _loginUser.IdCliente,
                Total = montoAcumulado,
                Fecha = DateTime.Now,
                Nro_Tarjeta = int.Parse(cmbTarjeta.Text),
            };
            
            this.RevisarRespuestaServicio(gestor.agregar(venta));
            gestor.crearXml(ventaActual);
            actualizar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1 || lbl_numeric.numeric.Value.Equals(0))
            {
                string mensaje = cmbProducto.SelectedIndex is -1 ? "Debe seleccionar un producto" : "No se puede agregar cantidad = 0";
                MessageBox.Show(mensaje);
                return;
            }

            EntityProducto prod = (EntityProducto)cmbProducto.SelectedItem;

            EntityDetalle detail = new EntityDetalle
            {
                Nro_Venta = ventaActual,
                Id_Producto = prod.Id,
                CantProducto = (int)lbl_numeric.numeric.Value,
                SubTotal = (int)((int)lbl_numeric.numeric.Value * prod.Precio),
            };
            prod.Stock -= (int)lbl_numeric.numeric.Value;
            gestorProducto.modificar(prod);
            cmbProducto.SelectedIndex = -1;
            lbl_numeric.numeric.Value = 1;
            gestor.detallesActuales.Add(detail);
            mostrarLista();
        }

    }
}
