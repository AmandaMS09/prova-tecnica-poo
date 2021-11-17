using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1AMANDA01.Code.DTO
{
    class ProdutoDTO
    {
        private int _id;
        private string _nome;
        private double _preco;
        private string _marca;
        private string _descricao;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
