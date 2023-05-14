using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    abstract class Veiculo
    {
        private string Id;
        private Modelo modelo;
        private double velocidade;
        private int Passageiros;

        public string Identificação
        {
            get => Id;
            set
            {
                if(value == null)
                {
                    throw new Exception("Escreva os valores no campo de identificação");
                }
                Id = value;
            }
        }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public int CapacidadePassageiros
        {
            get => Passageiros;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Capacidade inválidade de passageiros");
                }
                Passageiros = value;
            }
        }
        public double Velocidade
        {
            get => velocidade;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Velocidade inválida");
                }
                velocidade = value;
            }
        }
        public virtual void Acelera()
        {
            Velocidade++;
        }
        public virtual void Desacelera()
        {
            Velocidade--;
        }
        public virtual double PagarPedagio()
        {
            return 0;
        }
        public override string ToString()
        {
            return "Identificação: " + Identificação + "| Modelo :" + Modelo.Descricao + "| Marca : " + Modelo.Marca.Descricao +
                "Velocidade: " + Velocidade + "Km/h" + "| Capacidade de passageiros: " + CapacidadePassageiros;
        }
    }
}
