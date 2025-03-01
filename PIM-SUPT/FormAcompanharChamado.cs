using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_SUPT
{
    public partial class FormAcompanharChamado : Form
    {
        public FormAcompanharChamado()
        {
            InitializeComponent();
        }

        private void FormAcompanharChamado_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 4;
        }
    }
}
