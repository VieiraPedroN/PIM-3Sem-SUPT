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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string emailAdm = "Func";
            string senhaAdm = "12345";

            string emailFunc = "User";
            string senhaFunc = "12345";

            if (textEmail.Text.Equals(emailAdm) && textSenha.Text.Equals(senhaAdm))
            {
                ID = 1; // Identificador de Funcionario
            }
            else if (textEmail.Text.Equals(emailFunc) && textSenha.Text.Equals(senhaFunc))
            {
                ID = 2; // Identificador de Usuario
            }

            if (ID == 1)
            {
                FormFuncionario formFunc = new FormFuncionario();
                formFunc.Show();
                this.Hide();
            }
            else if (ID == 2)
            {
                FormUsuario formUsuario = new FormUsuario();
                formUsuario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}