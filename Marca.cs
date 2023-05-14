using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class Marca
    {
        private int codigo;
        private string descricao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public Marca()
        {
        }
        public Marca(int codigo,string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
