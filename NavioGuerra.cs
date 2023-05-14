using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class NavioGuerra : VeiculoGuerra
    {
        private string AtracadoMensagem;
        private bool AtracadoStatus;

        public string MensagemAtracado { get => AtracadoMensagem; set => AtracadoMensagem = value; }
        public bool Atracado { get => AtracadoStatus; set => AtracadoStatus = value; }

        public void Atracar()
        {
            if (Velocidade > 0)
            {
                Atracado = true;
                Velocidade = 0;
                MensagemAtracado = "O navio esta atracado";
            }
            else
            {
                MensagemAtracado = "O navio ainda esta parado";
                Atracado = false;
            }
            
        }
        public override string ToString()
        {
            return "Identificação: " + Identificacao + " | Modelo: " + Modelo.Descricao + " | Marca: " + Modelo.Marca.Descricao + " | Velocidade: " + Velocidade + "km/h" + " " +
                "| Capacidade de passageiros: " + CapacidadePassageiros + " | Status de Guerra: " + MensagemGuerra;
        }
        public NavioGuerra()
        {

        }
        public NavioGuerra(string identificacao, Modelo modelo, int velocidade, int passageiros)
        {
            Identificacao = identificacao;
            Modelo = modelo;
            Velocidade = velocidade;
            CapacidadePassageiros = passageiros;

        }
    }
}
