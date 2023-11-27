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
    public partial class lbl_numeric : UserControl
    {
        public lbl_numeric()
        {
            InitializeComponent();
        }

        public Label lbl => label1;
        public NumericUpDown numeric => numericUpDown1;
    }
}
