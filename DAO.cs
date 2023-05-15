using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public class DAO
    {
        Form1 menu;

        public DAO(Form1 menu)
        {
            this.menu = menu;
        }

        public static void GravarArquivo(Form1 menu)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string conteudoMarca = JsonConvert.SerializeObject(menu.dadosMarca1, settings);
            File.WriteAllText("dadosMarca.json", conteudoMarca);

            string conteudoModelo = JsonConvert.SerializeObject(menu.dadosModelo1, settings);
            File.WriteAllText("dadosModelo.json", conteudoModelo);

            string conteudo = JsonConvert.SerializeObject(menu.dadosVeiculo, settings);
            File.WriteAllText("dadosveiculo.json", conteudo);
        }
        public static void CarregaArquivo(Form1 menu)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string conteudoMarca = File.ReadAllText("dadosMarca.json");
            menu.dadosMarca1 = JsonConvert.DeserializeObject<List<Marca>>(conteudoMarca, settings);

            string conteudoModelo = File.ReadAllText("dadosModelo.json");
            menu.dadosModelo1 = JsonConvert.DeserializeObject<List<Modelo>>(conteudoModelo, settings);

            string conteudo = File.ReadAllText("dadosveiculo.json");
            menu.dadosVeiculo = JsonConvert.DeserializeObject<List<Veiculo>>(conteudo, settings);
            int i = 0;

            if (menu.dadosVeiculo != null)
                foreach (var item in menu.dadosVeiculo)
                {
                    int codigoMarca = 0;
                    int codigoModelo = 0;
                    string c = menu.dadosModelo1[i].Descricao;
                    string d = menu.dadosMarca1[i].Descricao;
                    if (d == "AG" ||
                        d == "VW" ||
                        d == "Marcopolo" ||
                        d == "Honda" ||
                        d == "Embraer" ||
                        d == "Northrop" ||
                        d == "GE" ||
                        d == "Maersk" ||
                        d == "Ford")
                        codigoMarca = 1;
                    else
                        codigoMarca = 2;
                    if (c == "Gol" ||
                        c == "Agrale 9200" ||
                        c == "G7" ||
                        c == "Cargo" ||
                        c == "Embraer 175" ||
                        c == "Night Hawk" ||
                        c == "U20C" ||
                        c == "Honam" ||
                        c == "CVN78")
                        codigoModelo = 1;
                    else
                        codigoModelo = 2;

                    item.Modelo = new Modelo(codigoModelo, menu.dadosModelo1[i].Descricao, new Marca(codigoMarca, menu.dadosMarca1[i].Descricao));
                    i++;


                }
            string conteudoPedagio = File.ReadAllText("dadosPedagio.json");
            menu.dadosPedagio = JsonConvert.DeserializeObject<List<Pedagio>>(conteudoPedagio, settings);

        }
        public static void GravarPedagio(Form1 menu)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string conteudoPedagio = JsonConvert.SerializeObject(menu.dadosPedagio, settings);
            File.WriteAllText("dadosPedagio.json", conteudoPedagio);
        }
    }
}
