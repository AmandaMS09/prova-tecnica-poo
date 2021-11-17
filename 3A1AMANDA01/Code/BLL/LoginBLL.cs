using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using _3A1AMANDA01.Code.DTO;
using _3A1AMANDA01.Code.DAL;

namespace _3A1AMANDA01.Code.BLL
{
    class LoginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "usuario";

        public bool RealizarLogin(LoginDTO dto)
        {
            string sql = $"select * from {tabela} where email = '{dto.Email}' and senha = '{dto.Senha}';";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
