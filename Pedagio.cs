using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class Pedagio
    {
        private string identificacao;
        private string localizacao;
        private double saldo;

        public string Identificacao { get => identificacao; set => identificacao = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public void Receber(double valor)
        {
            Saldo = Saldo - valor;
        }
        public void Ganhos(double valor)
        {
            Saldo += valor;
        }
        public override string ToString()
        {
            return $"Identificação: {Identificação} | Localização: {Localização} | Saldo: R$ {Saldo} |";
        }
    }
}
