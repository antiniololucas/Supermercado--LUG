using System.Windows.Forms;

namespace UI
{
    public partial class lbl_cmb : UserControl
    {
        public lbl_cmb()
        {
            InitializeComponent();
        }

        public Label lbl => label1;

        public ComboBox cmb => comboBox1;

    }
}
