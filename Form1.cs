using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculos
{
    public partial class Form1 : Form
    {
        Marca m = new Marca();
        Modelo mod = new Modelo();

        public List<Marca> dadosMarca { get; set; }
        public List<Marca> dadosMarca1 { get; set; }
        public List<Modelo> dadosModelo { get; set; }
        public List<Modelo> dadosModelo1 { get; set; }
        public List<Pedagio> dadosPedagio { get; set; }
        public List<Veiculo> dadosVeiculo { get; set; }
        public Form1()
        {
            InitializeComponent();
            dadosMarca = new List<Marca>();
            dadosMarca1 = new List<Marca>();
            dadosModelo = new List<Modelo>();
            dadosModelo1 = new List<Modelo>();
            dadosVeiculo = new List<Veiculo>();
            CarregandoCampos();
        }

        private void Veiculos_SelectionChanged(object sender, EventArgs e)
        {
            SelecoesDeVeiculo();
        }

        private void Marcas_SelectIndexChanged(object sender, EventArgs e)
        {
            if (veiculocb.SelectedIndex == 0 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "Gol", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 0 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "Celta", dadosMarca[1]);
                dadosModelo.Add(mod);
            }
            //caminhao
            else if (veiculocb.SelectedIndex == 1 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "Agrale 9200", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 1 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "FH 540", dadosMarca[1]);
                dadosModelo.Add(mod);
            }
            //onibus
            else if (veiculocb.SelectedIndex == 2 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "G7", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 2 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "Benz 710", dadosMarca[1]);
                dadosModelo.Add(mod);
            }
            //moto
            else if (veiculocb.SelectedIndex == 3 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "Cargo", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 3 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "Fazer", dadosMarca[1]);
                dadosModelo.Add(mod);
            }
            //aviao 
            else if (veiculocb.SelectedIndex == 4 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "Embraer 175", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 4 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "a380", dadosMarca[1]);
                dadosModelo.Add(mod);
            }
            //aviao de guerra
            else if (veiculocb.SelectedIndex == 5 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "Night Hawk", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 5 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "Raptor", dadosMarca[1]);
                dadosModelo.Add(mod);
            }
            //trem
            else if (veiculocb.SelectedIndex == 6 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "U20C", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 6 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "DH10", dadosMarca[1]);
                dadosModelo.Add(mod);
            }
            //navio
            else if (veiculocb.SelectedIndex == 7 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "Honam", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 7 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "Prezioza", dadosMarca[1]);
                dadosModelo.Add(mod);
            }
            //navio de guerra
            else if (veiculocb.SelectedIndex == 8 && MarcasCb.SelectedIndex == 0)
            {
                dadosModelo.Clear();
                mod = new Modelo(1, "CVN78", dadosMarca[0]);
                dadosModelo.Add(mod);
            }
            else if (veiculocb.SelectedIndex == 8 && MarcasCb.SelectedIndex == 1)
            {
                dadosModelo.Clear();
                mod = new Modelo(2, "Yamato", dadosMarca[1]);
                dadosModelo.Add(mod);
            }

            ModeloCb.DataSource = null;
            ModeloCb.DataSource = dadosModelo;
            ModeloCb.DisplayMember = "Descricao";
        }

        private void AcoesCb_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoMarca = 0;
                int codigoModelo = 0;
                string c = MarcasCb.Text;
                string d = ModeloCb.Text;

                if (d == "AG" || d == "VW" || d == "Marcopolo" || d == "Honda" || d == "Embraer" ||
                    d == "Northrop" || d == "GE" || d == "Maersk" || d == "Ford")
                    codigoMarca = 1;
                else
                    codigoMarca = 2;
                if (c == "Gol" || c == "Agrale 9200" || c == "G7" || c == "Cargo" || c == "Embraer 175" ||
                    c == "Night Hawk" || c == "U20C" || c == "Honam" || c == "CVN78")
                    codigoModelo = 1;
                else
                    codigoModelo = 2;
                Marca marca = new Marca()
                {
                    Codigo = codigoMarca,
                    Descricao = MarcasCb.Text
                };
                dadosMarca1.Add(marca);
                Modelo modelo = new Modelo()
                {
                    Codigo = codigoModelo,
                    Descricao = ModeloCb.Text,
                    Marca = dadosMarca1[dadosVeiculo.Count]
                };
                dadosModelo1.Add(modelo);
                if (veiculocb.Text == "Carro")
                {
                    Carro carro = new Carro()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = dadosModelo1[dadosVeiculo.Count],
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text),
                        Limpador = LimpadorCb.Text == "Ligado",
                        QtdPortas = Convert.ToInt32(PortasTxt.Text)
                    };
                    dadosVeiculo.Add(carro);
                }
                else if (veiculocb.Text == "Caminhão")
                {
                    Caminhao caminhao = new Caminhao()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = new Modelo(ModeloCb.SelectedIndex + 1, ModeloCb.Text, new Marca(MarcasCb.SelectedIndex + 1, MarcasCb.Text)),
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text),
                        Limpador = LimpadorCb.Text == "Ligado",
                        Carga = Convert.ToInt32(Cargatxt.Text),
                        QuantidadeEixos = Convert.ToInt32(EixosTxt.Text),
                        CapacidadeCarga = Convert.ToDouble(Capacidadetxt.Text)
                    };
                    dadosVeiculo.Add(caminhao);
                }
                else if (veiculocb.Text == "Ônibus")
                {
                    Onibus onibus = new Onibus()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = new Modelo(ModeloCb.SelectedIndex + 1, ModeloCb.Text, new Marca(MarcasCb.SelectedIndex + 1, MarcasCb.Text)),
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text),
                        Limpador = LimpadorCb.Text == "Ligado",
                        QuantidadeEixos = Convert.ToInt32(EixosTxt.Text),
                        Leito = LeitoCb.Text == "Sim"
                    };
                    dadosVeiculo.Add(onibus);
                }
                else if (veiculocb.Text == "Moto")
                {
                    Moto moto = new Moto()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = new Modelo(ModeloCb.SelectedIndex + 1, ModeloCb.Text, new Marca(MarcasCb.SelectedIndex + 1, MarcasCb.Text)),
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text)
                    };
                    dadosVeiculo.Add(moto);
                }
                else if (veiculocb.Text == "Avião")
                {
                    Aviao aviao = new Aviao()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = new Modelo(ModeloCb.SelectedIndex + 1, ModeloCb.Text, new Marca(MarcasCb.SelectedIndex + 1, MarcasCb.Text)),
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text),
                        Limpador = LimpadorCb.Text == "Ligado"
                    };
                    dadosVeiculo.Add(aviao);
                }
                else if (veiculocb.Text == "Avião de Guerra")
                {
                    AviaoGuerra aviaoDeGuerra = new AviaoGuerra()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = new Modelo(ModeloCb.SelectedIndex + 1, ModeloCb.Text, new Marca(MarcasCb.SelectedIndex + 1, MarcasCb.Text)),
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text)
                    };
                    dadosVeiculo.Add(aviaoDeGuerra);
                }
                else if (veiculocb.Text == "Trem")
                {
                    Trem trem = new Trem()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = new Modelo(ModeloCb.SelectedIndex + 1, ModeloCb.Text, new Marca(MarcasCb.SelectedIndex + 1, MarcasCb.Text)),
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text),
                        Limpador = LimpadorCb.Text == "Ligado",
                        QtdVagoes = Convert.ToInt32(VagoesCb.Text)
                    };
                    dadosVeiculo.Add(trem);
                }
                else if (veiculocb.Text == "Navio")
                {
                    Navio navio = new Navio()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = new Modelo(ModeloCb.SelectedIndex + 1, ModeloCb.Text, new Marca(MarcasCb.SelectedIndex + 1, MarcasCb.Text)),
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text)
                    };
                    dadosVeiculo.Add(navio);
                }
                else if (veiculocb.Text == "Navio de Guerra")
                {
                    NavioGuerra navioDeGuerra = new NavioGuerra()
                    {
                        Identificacao = Idtxt.Text,
                        Modelo = new Modelo(ModeloCb.SelectedIndex + 1, ModeloCb.Text, new Marca(MarcasCb.SelectedIndex + 1, MarcasCb.Text)),
                        Velocidade = Convert.ToInt32(Velocidadetxt.Text),
                        CapacidadePassageiros = Convert.ToInt32(PassageirosTxt.Text)
                    };
                    dadosVeiculo.Add(navioDeGuerra);
                }
                DAO.GravarArquivo(this);
                cbIdentificacaoPedagio.DataSource = null;
                cbIdentificacaoPedagio.DataSource = dadosVeiculo;
                cbIdentificacaoPedagio.DisplayMember = "Identificacao";
                cbConsultarVeiculos.DataSource = null;
                cbConsultarVeiculos.DataSource = dadosVeiculo;
                cbConsultarVeiculos.DisplayMember = "Identificacao";
                MessageBox.Show("gravado!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void ListarTodosbtn_Click(object sender, EventArgs e)
        {
            ListarTxt.Clear();
            if (dadosVeiculo != null)
                foreach (Veiculo v in dadosVeiculo)
                    ListarTxt.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
        }

        private void btnAtracar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao)
                    {
                        (item as Navio).Atracar();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDecolar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao && item is Aviao)
                    {
                        (item as Aviao).Decolar();
                        break;
                    }
                    if (cbConsultarVeiculos.Text == item.Identificacao && item is AviaoGuerra)
                    {
                        (item as AviaoGuerra).Decolar();
                        break;
                    }
                }
                DAO.GravarArquivo(this);


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnEjetar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao)
                    {
                        (item as AviaoGuerra).Ejetar();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPousar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao && item is Aviao)
                    {
                        (item as Aviao).Pousar();
                        break;
                    }
                    if (cbConsultarVeiculos.Text == item.Identificacao && item is AviaoGuerra)
                    {
                        (item as AviaoGuerra).Pousar();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnArremeter_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao && item is Aviao)
                    {
                        (item as Aviao).Arremeter();
                        break;
                    }
                    if (cbConsultarVeiculos.Text == item.Identificacao && item is AviaoGuerra)
                    {
                        (item as AviaoGuerra).Arremeter();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao)
                    {
                        (item as VeiculoGuerra).Atacar();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDesligarLimpador_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (item.Identificacao == cbConsultarVeiculos.Text && item is VeiculoLimpador)
                    {
                        (item as VeiculoLimpador).Limpador = false;
                        (item as VeiculoLimpador).LimpadorStatus();
                        MessageBox.Show((item as VeiculoLimpador).MensagemLimpador);
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch
            {

            }
        }

        private void btnLigarLimpador_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (item.Identificacao == cbConsultarVeiculos.Text && item is VeiculoLimpador)
                    {
                        (item as VeiculoLimpador).Limpador = true;
                        (item as VeiculoLimpador).LimpadorStatus();
                        MessageBox.Show((item as VeiculoLimpador).MensagemLimpador);
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch
            {

            }
        }

        private void btnDesacelerar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (item.Identificacao == cbConsultarVeiculos.Text)
                    {
                        item.Desacelera();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (item.Identificacao == cbConsultarVeiculos.Text)
                    {
                        item.Acelera();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao)
                    {
                        (item as Moto).Empinar();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDesempinar_Click(object sender, EventArgs e)
        {
            foreach (Veiculo item in dadosVeiculo)
            {
                if (item.Identificacao == cbConsultarVeiculos.Text)
                {
                    (item as Moto).PararEmpinar();
                    break;
                }

            }
            DAO.GravarArquivo(this);
            ReList();
        }

        private void btnDescarregar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao)
                    {
                        (item as Caminhao).Descarregar();
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo item in dadosVeiculo)
                {
                    if (cbConsultarVeiculos.Text == item.Identificacao)
                    {
                        (item as Caminhao).Carregar(Convert.ToDouble(tbCarregarCaminhao.Text));
                        break;
                    }
                }
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                if (AcoesCb.SelectedIndex == 0)
                {
                    foreach (Veiculo item in dadosVeiculo)
                    {
                        if (item is VeiculoLimpador)
                        {
                            (item as VeiculoLimpador).Limpador = true;
                            (item as VeiculoLimpador).LimpadorStatus();
                        }
                    }
                    MessageBox.Show("Todos Limapdores foram LIGADOS.");
                }
                else if (AcoesCb.SelectedIndex == 1)
                {
                    foreach (Veiculo item in dadosVeiculo)
                    {
                        if (item is Navio)
                        {
                            (item as Navio).Atracar();
                        }
                        if (item is NavioGuerra)
                        {
                            (item as NavioGuerra).Atracar();
                        }
                    }
                    MessageBox.Show("Todos os Navios foram ATRACADOS.");
                }
                else if (AcoesCb.SelectedIndex == 2)
                {
                    foreach (Veiculo item in dadosVeiculo)
                    {
                        if (item is VeiculoGuerra)
                        {
                            (item as VeiculoGuerra).Atacar();
                        }
                    }
                    MessageBox.Show("Todos Veiculos de Guerra estão ATACANDO.");
                }
                else if (AcoesCb.SelectedIndex == 3)
                {
                    foreach (Veiculo item in dadosVeiculo)
                    {
                        if (item is Moto)
                        {
                            (item as Moto).Empinar();
                        }
                    }
                    MessageBox.Show("Todas Motos estão EMPINANDO.");
                }
                else
                    MessageBox.Show("Opção não selecionada.");
                DAO.GravarArquivo(this);
                ReList();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnGerarPedagio_Click(object sender, EventArgs e)
        {
            txtListarPedagio.Clear();
            try
            {
                Pedagio p = new Pedagio();
                p.Identificacao = cbIdentificacaoPedagio.Text;

                foreach (Veiculo identificacao in dadosVeiculo)
                {
                    if (identificacao.Identificacao == cbIdentificacaoPedagio.Text)
                    {
                        p.Ganhos(identificacao.PagarPedagio());
                        break;
                    }
                }
                p.Localizacao = cbLocalizacaoPedagio.Text;
                bool valida = false;
                for (int i = 0; i < dadosPedagio.Count; i++)
                {
                    if (dadosPedagio[i].Identificacao == p.Identificacao && dadosPedagio[i].Localizacao == p.Localizacao)
                    {
                        dadosPedagio[i].Saldo += p.Saldo;
                        valida = true;

                        break;
                    }
                }
                dadosPedagio.Add(p);
                if (valida == true)
                    dadosPedagio.RemoveAt(dadosPedagio.Count - 1);

                DAO.GravarPedagio(this);

                txtListarPedagio.Clear();
                foreach (Pedagio ped in dadosPedagio)
                {
                    txtListarPedagio.Text += ped.ToString() + Environment.NewLine;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnListarPedagio_Click(object sender, EventArgs e)
        {
            txtListarPedagio.Clear();
            foreach (Pedagio ped in dadosPedagio)
            {
                txtListarPedagio.Text += ped.ToString() + Environment.NewLine;
            }
        }

        private void btnPagarPedagio_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPagarTodoPedagio.Checked == true)
                {
                    foreach (Pedagio pedagio in dadosPedagio)
                    {
                        pedagio.Saldo = 0;

                    }
                    MessageBox.Show("Todos os pedagios foram pagos.");
                }
                else
                {
                    foreach (Pedagio p in dadosPedagio)
                    {
                        if (p.Identificacao == cbIdentificacaoPedagio.Text)
                        {

                            if (p.Saldo < Convert.ToDouble(tbPagarPedagio.Text))
                            {
                                MessageBox.Show("Seu troco é de" + (Convert.ToDouble(tbPagarPedagio.Text) - p.Saldo));
                                p.Receber(Convert.ToDouble(p.Saldo));
                            }
                            if (p.Saldo > Convert.ToDouble(tbPagarPedagio.Text))
                            {

                                p.Saldo = p.Saldo - Convert.ToDouble(tbPagarPedagio.Text);
                            }
                            else if (p.Saldo == 0)
                            {
                                MessageBox.Show("Pedagio ja foi pago.");
                            }

                        }
                    }
                }
                DAO.GravarPedagio(this);

                txtListarPedagio.Clear();
                foreach (Pedagio p in dadosPedagio)
                {
                    txtListarPedagio.Text += p.ToString() + Environment.NewLine;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void SelecoesDeVeiculo()
        {
            if (veiculocb.SelectedIndex == 0)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = true;

                Cargalbl.Visible = Cargatxt.Visible = false;
                Eixoslbl.Visible = EixosTxt.Visible = false;
                Capacidadelbl.Visible = Capacidadetxt.Visible = false;
                LeitoCb.Visible = Leitolbl.Visible = false;
                Portaslbl.Visible = PortasTxt.Visible = true;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = false;

            }
            else if (veiculocb.SelectedIndex == 1)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = true;

                Cargalbl.Visible = Cargatxt.Visible = true;
                Eixoslbl.Visible = EixosTxt.Visible = true;
                Capacidadelbl.Visible = Capacidadetxt.Visible = true;
                LeitoCb.Visible = Leitolbl.Visible = false;
                Portaslbl.Visible = PortasTxt.Visible = false;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = false;

            }
            else if (veiculocb.SelectedIndex == 2)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = true;

                Cargalbl.Visible = Cargatxt.Visible = false;
                Eixoslbl.Visible = EixosTxt.Visible = true;
                Capacidadelbl.Visible = Capacidadetxt.Visible = false;
                LeitoCb.Visible = Leitolbl.Visible = true;
                Portaslbl.Visible = PortasTxt.Visible = false;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = false;

            }
            else if (veiculocb.SelectedIndex == 3)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = false;

                Cargalbl.Visible = Cargatxt.Visible = false;
                Eixoslbl.Visible = EixosTxt.Visible = false;
                Capacidadelbl.Visible = Capacidadetxt.Visible = false;
                LeitoCb.Visible = Leitolbl.Visible = false;
                Portaslbl.Visible = PortasTxt.Visible = false;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = false;
            }
            else if (veiculocb.SelectedIndex == 4)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = true;

                Cargalbl.Visible = Cargatxt.Visible = false;
                Eixoslbl.Visible = EixosTxt.Visible = false;
                Capacidadelbl.Visible = Capacidadetxt.Visible = false;
                LeitoCb.Visible = Leitolbl.Visible = false;
                Portaslbl.Visible = PortasTxt.Visible = false;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = false;
            }
            else if (veiculocb.SelectedIndex == 5)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = false;

                Cargalbl.Visible = Cargatxt.Visible = false;
                Eixoslbl.Visible = EixosTxt.Visible = false;
                Capacidadelbl.Visible = Capacidadetxt.Visible = false;
                LeitoCb.Visible = Leitolbl.Visible = false;
                Portaslbl.Visible = PortasTxt.Visible = false;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = false;
            }
            else if (veiculocb.SelectedIndex == 6)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = true;

                Cargalbl.Visible = Cargatxt.Visible = false;
                Eixoslbl.Visible = EixosTxt.Visible = false;
                Capacidadelbl.Visible = Capacidadetxt.Visible = false;
                LeitoCb.Visible = Leitolbl.Visible = false;
                Portaslbl.Visible = PortasTxt.Visible = false;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = true;
            }
            else if (veiculocb.SelectedIndex == 7)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = true;

                Cargalbl.Visible = Cargatxt.Visible = false;
                Eixoslbl.Visible = EixosTxt.Visible = false;
                Capacidadelbl.Visible = Capacidadetxt.Visible = false;
                LeitoCb.Visible = Leitolbl.Visible = false;
                Portaslbl.Visible = PortasTxt.Visible = false;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = false;
            }
            else if (veiculocb.SelectedIndex == 8)
            {
                Idtxt.Visible = true;
                Velocidadetxt.Visible = true;
                PassageirosTxt.Visible = true;
                MarcasCb.Visible = true;
                ModeloCb.Visible = true;

                Limpadorlbl.Visible = LimpadorCb.Visible = false;

                Cargalbl.Visible = Cargatxt.Visible = false;
                Eixoslbl.Visible = EixosTxt.Visible = false;
                Capacidadelbl.Visible = Capacidadetxt.Visible = false;
                LeitoCb.Visible = Leitolbl.Visible = false;
                Portaslbl.Visible = PortasTxt.Visible = false;
                Cadastrarbtn.Visible = true;
                VagoesCb.Visible = Vagoeslbl.Visible = false;
            }

            if (veiculocb.Text == "Carro")
            {
                dadosMarca.Clear();

                m = new Marca(1, "VW");
                dadosMarca.Add(m);

                m = new Marca(2, "GM");
                dadosMarca.Add(m);

            }
            else if (veiculocb.Text == "Caminhão")
            {
                dadosMarca.Clear();

                m = new Marca(1, "Scania");
                dadosMarca.Add(m);

                m = new Marca(2, "Volvo");
                dadosMarca.Add(m);
            }
            else if (veiculocb.Text == "Ônibus")
            {
                dadosMarca.Clear();

                m = new Marca(1, "Marcopolo");
                dadosMarca.Add(m);

                m = new Marca(2, "Mercedes");
                dadosMarca.Add(m);
            }
            else if (veiculocb.Text == "Moto")
            {
                dadosMarca.Clear();

                m = new Marca(1, "Honda");
                dadosMarca.Add(m);

                m = new Marca(2, "Yamaha");
                dadosMarca.Add(m);
            }
            else if (veiculocb.Text == "Avião")
            {
                dadosMarca.Clear();

                m = new Marca(1, "Embraer");
                dadosMarca.Add(m);

                m = new Marca(2, "Airbus");
                dadosMarca.Add(m);
            }
            else if (veiculocb.Text == "Avião de Guerra")
            {
                dadosMarca.Clear();

                m = new Marca(1, "Northrop");
                dadosMarca.Add(m);

                m = new Marca(2, "Lockheed");
                dadosMarca.Add(m);
            }
            else if (veiculocb.Text == "Trem")
            {
                dadosMarca.Clear();

                m = new Marca(1, "GE");
                dadosMarca.Add(m);

                m = new Marca(2, "MAXION");
                dadosMarca.Add(m);
            }
            else if (veiculocb.Text == "Navio")
            {
                dadosMarca.Clear();

                m = new Marca(1, "Maersk");
                dadosMarca.Add(m);

                m = new Marca(2, "MSC");
                dadosMarca.Add(m);
            }
            else if (veiculocb.Text == "Navio de Guerra")
            {
                dadosMarca.Clear();

                m = new Marca(1, "Ford");
                dadosMarca.Add(m);

                m = new Marca(2, "Kure");
                dadosMarca.Add(m);
            }
            MarcasCb.DataSource = null;
            MarcasCb.DataSource = dadosMarca;
            MarcasCb.DisplayMember = "Descricao";
        }
        private void ReList()
        {
            ListarTxt.Clear();
            if (dadosVeiculo != null)
                foreach (Veiculo v in dadosVeiculo)
                    ListarTxt.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
        }
        private void CarregandoCampos()
        {
            if (File.Exists("dadosveiculo.json"))
                DAO.CarregaArquivo(this);
            cbIdentificacaoPedagio.DataSource = null;
            cbIdentificacaoPedagio.DataSource = dadosVeiculo;
            cbIdentificacaoPedagio.DisplayMember = "Identificacao";

            cbConsultarVeiculos.DataSource = null;
            cbConsultarVeiculos.DataSource = dadosVeiculo;
            cbConsultarVeiculos.DisplayMember = "Identificacao";
        }

        private void rbGerarPedagio_CheckedChanged(object sender, EventArgs e)
        {
            pDadosPedagio.Visible = true;
            pPagamento.Visible = false;
            btnGerarPedagio.Visible = true;
            cbLocalizacaoPedagio.Enabled = true;
        }

        private void rbPagarPedagio_CheckedChanged(object sender, EventArgs e)
        {
            pDadosPedagio.Visible = true;
            pPagamento.Visible = true;
            btnGerarPedagio.Visible = false;
            cbLocalizacaoPedagio.Enabled = true;
            tbTipoVeiculoPedagio.Enabled = true;
        }

        private void rbPagarTodoPedagio_CheckedChanged(object sender, EventArgs e)
        {
            pDadosPedagio.Visible = false;
            pPagamento.Visible = true;
            btnGerarPedagio.Visible = false;
            cbLocalizacaoPedagio.Enabled = false;
            tbTipoVeiculoPedagio.Enabled = false;
        }

    }
}
