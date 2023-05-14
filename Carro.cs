using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculos
{
    public class Carro : VeiculoLimpador
    {
        private int qtdPortas;
        public Carro()
        {

        }
        public Carro(string id, Modelo modelo, int vel, int passageiros, bool limpador, int portas)
        {
            Identificacao = id;
            Modelo = modelo;
            Velocidade = vel;
            CapacidadePassageiros = passageiros;
            Limpador = limpador;
            LimpadorStatus();
            QtdPortas = portas;
        }
        public int QtdPortas { get => qtdPortas; set => qtdPortas = value; }

        public override void LimpadorStatus()
        {
            if (Limpador)
            {
                MensagemLimpador = "O carro esta com o limpador ligado!";
            }
            else
            {
                MensagemLimpador = "O carro esta com o limpador desligado!";
            }
        }
        public override void LimpadorLigado()
        {
            MensagemLimpador = "O carro esta com o limpador ligado!";
            Limpador = true;
        }
        public override void LimpadorDesligado()
        {
            MensagemLimpador = "O carro esta com o limpador desligado!";
            Limpador = false;
        }
        public override double PagarPedagio()
        {
            return 7;
        }
        public override string ToString()
        {
            return base.ToString() + $"| Quantidade de portas: {QtdPortas}";
        }

    }
}
