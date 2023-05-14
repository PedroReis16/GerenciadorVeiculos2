using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class Navio : Veiculo
    {
        public string Atracar()
        {
            if (Velocidade > 0)
            {
                Velocidade= 0;
                return "O navio acabou de atracar";
            }
            else
            {
                return "O navio ainda esta parado";
            }
        }
        public override string ToString()
        {
            return "Identificação: " + Identificacao + " | Modelo: " + Modelo.Descricao + " | Marca: " + Modelo.Marca.Descricao + 
                " | Velocidade: " + Velocidade + "km/h" + " | Capacidade de passageiros: " + CapacidadePassageiros;
        }
        public Navio()
        {

        }
        public Navio(string id,Modelo modelo,int vel,int passageiros)
        {
            Identificacao= id;
            Modelo= modelo;
            Velocidade = vel;
            CapacidadePassageiros = passageiros;
        }
    }
}
