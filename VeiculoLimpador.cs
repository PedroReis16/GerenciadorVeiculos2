using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class VeiculoLimpador : Veiculo
    {
        private bool limpador;
        private string mensagemLimpador;

        public bool Limpador { get => limpador; set => limpador = value; }
        public string MensagemLimpador { get => mensagemLimpador; set => mensagemLimpador = value; }

        public virtual void LimpadorStatus()
        {
            if(Limpador == true)
            {
                MensagemLimpador = "O veículo esta com o limpador ligado";
            }
            else
            {
                MensagemLimpador = "O veículo esta com o limpador desligado";
            }
        }
        public virtual void LimpadorLigado()
        {
            MensagemLimpador = "Limpador do Veiculo Ligado";
            Limpador = true;
        }
        public virtual void LimpadorDesligado()
        {
            MensagemLimpador = "Limpador do Veiculo Desligado";
            Limpador = false;
        }
        public override string ToString()
        {
            return base.ToString() + " | Limpador: " + MensagemLimpador;
        }
    }
}
