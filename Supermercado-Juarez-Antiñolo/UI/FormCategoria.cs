using Bunifu.UI.WinForms;
using Business;
using Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCategoria : ServiceForm
    {
        FormAdministrador _administrador;
        FormProducto _formProducto;
        public FormCategoria(FormAdministrador administrador, FormProducto formProducto)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _administrador = administrador;
            _formProducto = formProducto;
            CrearDG();
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            DGcatView.Rows.Clear();
            foreach (var cat in gestor.Listar().Data)
            {
                DGcatView.Rows.Add(cat.Nombre, cat.Descripcion);
            }
        }

        private void CrearDG()
        {
            DGcatView.AutoGenerateColumns = false;
            DGcatView.Columns.Add("Nombre", "Nombre");
            DGcatView.Columns.Add("Descripcion", "Descripcion");

            DGcatView.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
        }
        BusinessCategoria gestor = new BusinessCategoria();


        private void DGcatView_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex is -1) { return; }
            DialogResult res = MessageBox.Show("¿Desea Eliminar la categoria? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                EntityCategoria categoria = new EntityCategoria
                {
                    Nombre = txtNombre.Text,
                };
                this.RevisarRespuestaServicio(gestor.Eliminar(categoria));
                MostrarDatos();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _administrador.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _formProducto.Show();
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            EntityCategoria categoria = new EntityCategoria();
            categoria.Nombre = txtNombre.Text;
            categoria.Descripcion = txtCategoria.Text;
            this.RevisarRespuestaServicio(gestor.Agregar(categoria));
            MostrarDatos();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            EntityCategoria categoria = new EntityCategoria
            {
                Nombre = txtNombre.Text,
                Descripcion = txtCategoria.Text
            };
            this.RevisarRespuestaServicio(gestor.Modificar(categoria));
            MostrarDatos();
        }
    }
}
