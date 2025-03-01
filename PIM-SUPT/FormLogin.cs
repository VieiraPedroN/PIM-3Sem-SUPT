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
            string emailFunc = "Func";
            string senhaFunc = "12345";

            string emailUser = "User";
            string senhaUser = "12345";

            if (textEmail.Text.Equals(emailFunc) && textSenha.Text.Equals(senhaFunc))
            {
                ID = 1; // Identificador de Funcionario
            }
            else if (textEmail.Text.Equals(emailUser) && textSenha.Text.Equals(senhaUser))
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
                FormTriagemUsuario formTriagemUsuario = new FormTriagemUsuario();
                formTriagemUsuario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = BtnAcessar;
        }
    }
}