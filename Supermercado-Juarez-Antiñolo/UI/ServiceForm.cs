using Business;
using System.Windows.Forms;

namespace UI
{
    public class ServiceForm : Form
    {

        protected void RevisarRespuestaServicio<T>(BusinessRespuesta<T> respuesta)
        {
            if (!respuesta.Ok)
            {
                MessageBox.Show(respuesta.Mensaje, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!string.IsNullOrEmpty(respuesta.Mensaje))
                MessageBox.Show(respuesta.Mensaje, "Great!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ServiceForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ServiceForm";
            this.ResumeLayout(false);

        }
    }
}
