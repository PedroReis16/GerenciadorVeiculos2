using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculos
{
    public class Trem : VeiculoLimpador
    {
        private int qtdVagoes;

        public int QtdVagoes { get=>qtdVagoes; set => qtdVagoes = value;}

        public override void LimpadorStatus()
        {
            if(Limpador == true)
            {
                MensagemLimpador = "O trem esta com o limpador ligado!";
            }
            else
            {
                MensagemLimpador = "O trem esta com o limpador desligado";
            }
        }
        public override void LimpadorLigado()
        {
            MensagemLimpador = "O trem esta com o limpador ligado";
            Limpador = true;
        }
        public override void LimpadorDesligado()
        {
            MensagemLimpador = "O trem esta com o limpador desligado";
            Limpador = false;
        }
        public override string ToString()
        {
            return base.ToString() + $"| Quantidade de vagões: {QtdVagoes}";
        }
        public Trem()
        {

        }
        public Trem(string id,Modelo modelo,int velocidade, int passageiros, bool limpador, int vagoes)
        {
            Identificacao = id;
            Modelo= modelo;
            Velocidade= velocidade;
            CapacidadePassageiros= passageiros;
            Limpador= limpador;
            LimpadorStatus();
            QtdVagoes = vagoes;
        }
    }
}
