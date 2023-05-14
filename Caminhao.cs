using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class Caminhao : VeiculoPesado
    {
        private double carga;
        private double capacidadeCarga;

        public double Carga { get { return carga; } set => carga = value; }
        public double CapacidadeCarga { get { return capacidadeCarga; } set { carga = value; } }

        public Caminhao() { }
        public Caminhao(string identificacao, Modelo modelo, int velocidade, int passageiros, bool limpador, int peso, int quantidadeEixos, double cargamaxima)
        {
            Identificacao = identificacao;
            Modelo = modelo;
            if (Carga >= CapacidadeCarga)
                Velocidade = 0;
            else
                Velocidade = velocidade;
            CapacidadePassageiros = passageiros;
            Limpador = limpador;
            LimpadorStatus();
            Carga = peso;
            QuantidadeEixos = quantidadeEixos;
            CapacidadeCarga = cargamaxima;
        }
        public virtual void Carregar(double peso)
        {
            Carga += peso;
        }
        public void Descarregar(double peso)
        {
            Carga = 0;
        }
        public override void LimpadorStatus()
        {
            if (Limpador)
            {
                MensagemLimpador = "O caminhão esta com o limpador ativo!";
            }
            else
            {
                MensagemLimpador = "O caminhão esta com o limpador desativado!";
            }
        }
        public override void LimpadorLigado()
        {
            MensagemLimpador = "O caminhão esta com o limpador ativo!";
            Limpador = true;
        }
        public override void LimpadorDesligado()
        {
            MensagemLimpador = "O caminhão esta com o limpador desativado";
            Limpador = false;
        }
        public override void Acelera()
        {
            if (Carga < CapacidadeCarga)
            {
                base.Acelera();
            }
            else
            {
                throw new Exception("O veículo não pode acelerar devido a sobrecarga");
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"| Peso: {Carga} Kg | Quantidade de eixos: {QuantidadeEixos} | Capacidade de Carga: {CapacidadeCarga}";
        }
    }
}
