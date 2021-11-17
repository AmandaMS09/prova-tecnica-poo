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

namespace _3A1AMANDA01.Ui
{
    public partial class FrmProdutos : Form
    {
        ProdutoBLL bll = new ProdutoBLL();
        ProdutoDTO dto = new ProdutoDTO();

        public FrmProdutos()
        {
            InitializeComponent();

            dgv_produtos.DataSource = bll.Listar();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            dto.Nome = txt_nome.Text;
            dto.Preco = double.Parse(txt_preco.Text);
            dto.Marca = txt_marca.Text;
            dto.Descricao = txt_descricao.Text;

            bll.Inserir(dto);

            MessageBox.Show("Cadastrado com sucesso!", "Produto");

            dgv_produtos.DataSource = bll.Listar();

            txt_id.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
            txt_marca.Clear();
            txt_descricao.Clear();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            dto.Id = int.Parse(txt_id.Text);
            dto.Nome = txt_nome.Text;
            dto.Preco = double.Parse(txt_preco.Text);
            dto.Marca = txt_marca.Text;
            dto.Descricao = txt_descricao.Text;

            bll.Alterar(dto);

            MessageBox.Show("Alterado com sucesso!", "Produto");

            dgv_produtos.DataSource = bll.Listar();

            txt_id.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
            txt_marca.Clear();
            txt_descricao.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            dto.Id = int.Parse(txt_id.Text);

            bll.Excluir(dto);

            MessageBox.Show("Excluído com sucesso", "Produto");

            dgv_produtos.DataSource = bll.Listar();

            txt_id.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
            txt_marca.Clear();
            txt_descricao.Clear();
        }

        private void dgv_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_produtos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_produtos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_preco.Text = dgv_produtos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_marca.Text = dgv_produtos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_descricao.Text = dgv_produtos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
