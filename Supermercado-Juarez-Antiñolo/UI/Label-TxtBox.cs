using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace UI
{
    public partial class Label_TxtBox : UserControl
    {
        public Label_TxtBox()
        {
            InitializeComponent();
        }

        public BunifuLabel lbl => bunifuLabel1;

        public BunifuTextBox txt => bunifuTextBox1;

    }
}
