using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class VeiculoPesado : VeiculoLimpador
    {
        private int quantidadeEixos;

        public int QuantidadeEixos { get => quantidadeEixos; set => quantidadeEixos = value; }
        public override double PagarPedagio()
        {
            return 8.5 * QuantidadeEixos;
        }
    }
}
