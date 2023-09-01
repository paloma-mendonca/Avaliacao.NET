using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ServiceReference1;
using System.Net;

namespace Avaliacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cliente = new AtendeClienteClient();
            _httpClient = new HttpClient();
        }

        //TabControl1
        List<int> numeros = new List<int>();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInt1.Text, out int num)) // converte texto digitado na cx de txt para int
            {
                numeros.Add(num); // caso a conversão seja sucedida, o numero convertido vai para a lista de numeros
                AtualizarListBox();
                AtualizaVisibilidade();
            }
            else
            {
                txtComeco.Visible = false;
                txtInfo.Visible = true;
                txtInfo.Text = "Informe 1 número";
            }
            txtInt1.Clear();
        }
        private void AtualizarListBox()
        {
            numeros.Sort();
            listNumbs.Items.Clear(); // limpa a memoria caixa para que os numeros digitados anteriormente não se repitam
            foreach (int num in numeros)
            {
                listNumbs.Items.Add(num); // adiciona os numeros no listbox
            }
        }
        private void AtualizaVisibilidade()
        {
            buttonGravar.Visible = listNumbs.Items.Count > 0; // habilita a visualizacao do botão gravar, apenas quando tiver conteudo no listbox
            txtComeco.Visible = false;
            txtInfo.Visible = false;
        }
        private string caminhoArquivo = @"numeros_ordenar.txt";
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            List<string> linhas = new List<string>();
            foreach (var item in listNumbs.Items) // percorre os itens da caixa 
                linhas.Add(item.ToString()); // e adiciona na List
            File.WriteAllLines(caminhoArquivo, linhas); // salva os itens da lista no aquivo txt
            txtInfo.Visible = false;
            txtComeco.Visible = true;
            txtComeco.Text = "Arquivo Gravado [numero_ordenar.txt] com Sucesso";
            buttonAbreArq.Visible = true;
        }
        private void buttonAbreArq_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoArquivo))
            {
                Process.Start("notepad.exe", caminhoArquivo); //inicializa o notepad e exibe a lista salva
                txtInfo.Visible = false;
                txtComeco.Visible = true;
                txtComeco.Text = "Arquivo aberto com sucesso!!";
            }
        }

        //TabControl2
        List<clsTeste> list = new List<clsTeste>();
        private const string NOME_ARQV_JSON = "data.json";
        private string caminhoTemp;
        private void buttonCriaJson_Click(object sender, EventArgs e)
        {
            CriaJson();
            txtInfo.Visible = false;
            txtComeco.Visible = true;
            txtComeco.Text = "Lista Criada e Arquivo data.json gravado com sucesso!!";
        }
        private void CriaJson()
        {
            string dataHoraAtual = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"); //determina a data e hora para implementar na propriedade descrição
            for (int i = 0; i < 100; i++)
            {
                list.Add(new clsTeste { Codigo = i, Descricao = dataHoraAtual }); // adiciona 100 numeros com a descrição em uma lista
            }
            string json = JsonConvert.SerializeObject(list, Formatting.Indented); // salva os objetos da lista em formato json
            caminhoTemp = Path.Combine(Path.GetTempPath(), NOME_ARQV_JSON);
            File.WriteAllText(caminhoTemp, json); // salva o texto da constante
        }
        private void buttonCarregaGrid_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoTemp))
            {
                string arqJson = File.ReadAllText(NOME_ARQV_JSON); // le a constante e salva na string
                if (arqJson != null)
                {
                    list = JsonConvert.DeserializeObject<List<clsTeste>>(arqJson); // que é convertida para texto
                    dataGridView1.DataSource = list; // e impressa no grid
                }
                txtInfo.Visible = false;
                txtComeco.Visible = true;
                txtComeco.Text = "Grid Carregado com sucesso!!";
            }
            else
            {
                txtComeco.Visible = false;
                txtInfo.Visible = true;
                txtInfo.Text = ($"Não foi possível lovalizar o arquivo {NOME_ARQV_JSON} no local {AppDomain.CurrentDomain.BaseDirectory}");
            }
        }

        //TabControl3
        private AtendeClienteClient _cliente;
        private async void consultaCEP()
        {
            string cep = txtIntCEP.Text;
            try
            {
                var resposta = await _cliente.consultaCEPAsync(cep);
                Endereco endereco = new Endereco
                {
                    bairro = resposta.@return.bairro,
                    cep = resposta.@return.cep,
                    cidade = resposta.@return.cidade,
                    complemento2 = resposta.@return.complemento2,
                    end = resposta.@return.end,
                    uf = resposta.@return.uf
                };
                string jsonFormatted = JsonConvert.SerializeObject(endereco, Formatting.Indented);
                cxCEP.Text = jsonFormatted.ToString();
            }
            catch (System.Exception ex)
            {
                cxCEP.Text = ex.Message;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIntCEP.Text))
            {
                consultaCEP();
                txtInfo.Visible = false;
                txtComeco.Visible = true;
                txtComeco.Text = "Consulta feita com Sucesso!";
            }
            else
            {
                txtComeco.Visible = false;
                txtInfo.Visible = true;
                txtInfo.Text = "Informe um CEP";
            }
        }

        //TabControl4
        private HttpClient _httpClient;
        private async void buttonAPI_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://brasilapi.com.br/api/banks/v1";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    List<apiBank> listAPI = JsonConvert.DeserializeObject<List<apiBank>>(content);
                    dataGridView2.DataSource = listAPI;
                    txtInfo.Visible = false;
                    txtComeco.Visible = true;
                    txtComeco.Text = "Consulta feita com Sucesso!";
                }
                else
                {
                    txtInfo.Visible = false;
                    txtComeco.Visible = false;
                    txtErro.Visible = true;
                    txtErro.Text = $"Erro: {response.StatusCode}";
                }
            }
            catch (System.Exception ex)
            {
                txtInfo.Visible = false;
                txtComeco.Visible = false;
                txtErro.Visible = true;
                txtErro.Text = ex.Message;
            }
        }

        //TabControl5
        private void buttonBaixaImg_Click(object sender, EventArgs e)
        {
            string imgUrl = "https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png";
            string localImg = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "redeservice-logo.png");
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(imgUrl, localImg);
                }
                byte[] imgByte = File.ReadAllBytes(localImg);
                string base64Img = Convert.ToBase64String(imgByte);
                base64.Text = base64Img;
                txtErro.Visible = false;
                txtInfo.Visible = false;
                txtComeco.Visible = true;
                txtComeco.Text = "Arquivo Baixada e Visualizada em Base64";
            }
            catch (System.Exception err)
            {
                txtInfo.Visible = false;
                txtComeco.Visible = false;
                txtErro.Visible = true;
                txtErro.Text = err.Message;
            }
        }
    }
}
