using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1AMANDA01.Code.BLL;
using _3A1AMANDA01.Code.DTO;

namespace _3A1AMANDA01
{
    public partial class FrmLogin : Form
    {
        LoginBLL bll = new LoginBLL();
        LoginDTO dto = new LoginDTO();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linklbl_esqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ui.FrmProdutos produto = new Ui.FrmProdutos();
            produto.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            dto.Email = txt_email.Text;
            dto.Senha = txt_senha.Text;

            if (bll.RealizarLogin(dto) == true)
            {
                Ui.FrmProdutos frm_produto = new Ui.FrmProdutos();
                frm_produto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique email e senha inseridos!", "Erro");
            }
        }
    }
}
