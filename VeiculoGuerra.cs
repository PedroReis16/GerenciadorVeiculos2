using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class VeiculoGuerra : Veiculo
    {
        private bool statusGuerra;
        private string mensagemGuerra = "O navio está evitando os inimigos";

        public string MensagemGuerra { get => mensagemGuerra; set => mensagemGuerra = value; }
        public bool StatusGuerra { get => statusGuerra; set => statusGuerra = value; }

        public virtual void StatusAtaque()
        {
            if (StatusGuerra == true)
            {
                MensagemGuerra = "O navio esta em ataque!";
            }
            else
            {
                MensagemGuerra = "O navio esta evitando os inimigos!";
            }
        }
        public virtual void Atacar()
        {
            StatusGuerra = true;
            MensagemGuerra = "O navio esta sob ataque";
        }
        public virtual void Recuar()
        {
            StatusGuerra = false;
            MensagemGuerra = "O navio esta evitando os inimigos!";
        }
        public override string ToString()
        {
            return base.ToString() + "| Status de Guerra :" + $" {MensagemGuerra}";
        }
    }
}
