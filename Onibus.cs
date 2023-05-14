using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class Onibus : VeiculoPesado
    {
        private bool leito;
        public string mensagemLeito = "";

        public bool Leito
        {
            get => leito;

            set
            {
                if (value == true)
                {
                    mensagemLeito = "Possui";
                }
                else
                {
                    mensagemLeito = "Não possui";
                }
            }
        }
        public override void LimpadorStatus()
        {
            if (Limpador == true)
            {
                MensagemLimpador = "O ônibus esta com o limpador ligado!";
            }
            else
            {
                MensagemLimpador = "O ônibus esta com o limpador desativado";
            }
        }
        public override void LimpadorLigado()
        {
            MensagemLimpador = "O ônibus esta com o limpador ligado!";
            Limpador = true;
        }
        public override void LimpadorDesligado()
        {
            MensagemLimpador = "O ônibus esta com o limpador desligado!";
            Limpador = false;
        }
        public Onibus()
        {

        }
        public Onibus(string id, Modelo modelo, int vel, int passageiros, bool limpador, int eixos, bool leitos)
        {
            Identificacao = id;
            Modelo = modelo;
            Velocidade = vel;
            CapacidadePassageiros = passageiros;
            Limpador = limpador;
            LimpadorStatus();
            QuantidadeEixos = eixos;
            Leito = leitos;
        }
    }
}
