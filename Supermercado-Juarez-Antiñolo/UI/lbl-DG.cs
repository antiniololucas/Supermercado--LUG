using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace UI
{
    public partial class lbl_DG : UserControl
    {
        public lbl_DG()
        {
            InitializeComponent();
        }

        public BunifuLabel lbl => bunifuLabel1;

        public BunifuDataGridView DG => DataGrid;

    }
}
