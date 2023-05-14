using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class Moto : Veiculo
    {
        private string EmpinarMensagem = "Por enquanto, tudo no chão";
        public void Empinar()
        {
            EmpinarMensagem = "Acima de nós só Deus e a roda da frente!!!";
        }
        public void PararEmpinar()
        {
            EmpinarMensagem = "Voltando para o chão...";
        }
        public override double PagarPedagio()
        {
            return 3;
        }
        public override string ToString()
        {
            return "Identificação: " + Identificacao + " | Modelo: " + Modelo.Descricao + " | Marca: " + Modelo.Marca.Descricao +
                " | Velocidade: " + Velocidade + "km/h" + " | Capacidade de passageiros: " + CapacidadePassageiros + " | " + EmpinarMensagem;
        }

        public Moto()
        {

        }
        public Moto(string id, Modelo modelo, int velocidade, int passageiros)
        {
            Identificacao = id;
            Modelo = modelo;
            Velocidade = velocidade;
            CapacidadePassageiros = passageiros;
        }
    }
}
