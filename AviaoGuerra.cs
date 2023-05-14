using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class AviaoGuerra : VeiculoGuerra
    {
        private bool statusVoo;
        private string mensagemVoo;

        public bool StatusVoo { get { return statusVoo; } set { statusVoo = value; } }
        public string MensagemVoo { get { return mensagemVoo; } set { mensagemVoo = value; } }

        public AviaoGuerra()
        {

        }
        public AviaoGuerra(string id, Modelo modelo, int vel, int passageiros)
        {
            Identificacao = id;
            Modelo = modelo;
            Velocidade = vel;
            CapacidadePassageiros = passageiros;
        }
        public void Pousar()
        {
            if (StatusVoo)
            {
                Velocidade = 0;
                StatusVoo = false;
                StatusGuerra = false;
                StatusAtaque();
                MensagemVoo = "O avião pousou!";
            }
            else
            {
                MensagemVoo = "O avião já esta em solo";
            }
        }
        public void Arremeter()
        {
            if (!StatusVoo)
            {
                Acelera();
                StatusVoo = true;

                MensagemVoo = "O avião precisou arremeter o pouso!";
            }
            else
            {
                MensagemVoo = "O avião já esta voando";
            }
        }
        public void Decolar()
        {
            if (!StatusVoo)
            {
                Acelera();
                StatusVoo = true;
                MensagemVoo = "O avião decolou";
            }
            else
            {
                MensagemVoo = "O avião já esta voando";
            }
        }
        public void Ejetar()
        {
            StatusGuerra = false;
            StatusAtaque();
            MensagemVoo = "O tripulante precisou deixar o avião!";
        }
    }
}
