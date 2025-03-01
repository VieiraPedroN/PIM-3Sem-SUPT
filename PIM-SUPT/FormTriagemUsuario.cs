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
    public partial class FormTriagemUsuario: Form
    {
        public FormTriagemUsuario()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAcompanharChamado formAcompanhar =  new FormAcompanharChamado();
            formAcompanhar.Show();
            this.Hide();

        }
    }
}
