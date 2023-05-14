using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class Aviao : VeiculoLimpador
    {
        private bool statusVoo;
        private string mensagemVoo;

        public bool StatusVoo { get { return statusVoo; } set { statusVoo = value; } }
        public string MensagemVoo { get { return mensagemVoo; } set { mensagemVoo = value; } }

        public Aviao()
        {

        }
        public Aviao(string identificacao, Modelo modelo, int velocidade, int passageiros, bool limpador)
        {
            Identificacao = identificacao;
            Modelo = modelo;
            Velocidade = velocidade;
            CapacidadePassageiros = passageiros;
            Limpador = false;
            LimpadorStatus();
        }

        public void Pousar()
        {
            if (StatusVoo)
            {
                Velocidade = 0;
                StatusVoo = false;
                MensagemVoo = "O avião pouso com toda segurança!";
            }
            else
            {
                MensagemVoo = "O avião ainda esta no ar";
            }
        }
        public void Decolar()
        {
            if (!StatusVoo)
            {
                Acelera();
                StatusVoo = true;
                MensagemVoo = "O avião esta decolando";
            }
            else
            {
                MensagemVoo = "O avião ainda esta em solo";
            }
        }
        public void Arremeter()
        {
            if (!StatusVoo)
            {
                Acelera(); 
                StatusVoo = true;

                MensagemVoo = "O avião não conseguiu pousar, e precisou arremeter";
            }
            else
            {
                MensagemVoo = "O avião nem tentou pousar!";
            }
        }
        public override void LimpadorStatus()
        {
            if (Limpador)
            {
                MensagemLimpador = "O avião esta com o limpador ligado";
            }
            else
            {
                MensagemLimpador = "O avião esta com o limpador desativado";
            }
        }
        public override void LimpadorLigado()
        {
            MensagemLimpador = "O avião esta com o limpador ativo";
            Limpador = true;
        }
        public override void LimpadorDesligado()
        {
            MensagemLimpador = "O avião esta com o limpador desativado";
            Limpador = false;
        }
        public override string ToString()
        {
            return base.ToString() + $"| Status Voo: {MensagemVoo}";
        }
    }
}
