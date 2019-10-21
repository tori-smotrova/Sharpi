using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class InputKindForm : Form
    {
        public enumKind kind = enumKind.Black;
        public InputKindForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            kind = Coffee.StringToKind(cbKind.SelectedItem.ToString());
        }
    }
}
