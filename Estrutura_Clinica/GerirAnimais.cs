using Clinica_Vet_Joana;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Estrutura_Clinica
{
    public partial class GerirAnimais : Form
    {
        Cliente dono;

        public GerirAnimais(Cliente dono)
        {
            InitializeComponent();
            this.dono = dono;
            this.FormClosing += GerirAnimais_FormClosing;
        }
        /// <summary>
        /// no botao para fechar o form, assigno uma variavel que contem o nif do cliente + info do Animal
        /// crio ou abro um ficheiro de texto e, tento, percorrer as linhas da gridview e gravo em cada linha,
        /// todos os atributos do animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerirAnimais_FormClosing(object sender, FormClosingEventArgs e)
        {
            string ficheiro = this.dono.NIF + "_" + Animal.FicheiroAnimais;

            StreamWriter fluxoDeEscrita = File.CreateText(ficheiro);

            try
            {
                foreach (DataGridViewRow row in listaAnimais.Rows)
                {
                    Animal animal = (Animal)row.DataBoundItem;

                    string linha = $"{animal.Id}*{animal.Nome}*" +
                        $"{animal.DataNascimento.ToString("dd/MM/yyyy")}*{animal.Especie}*{animal.Raca}*" +
                        $"{animal.Peso}*{animal.Genero}*{animal.Esterilizacao}";

                    fluxoDeEscrita.WriteLine(linha);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro na gravação do ficheiro", erro.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                fluxoDeEscrita.Close();
            }
        }
        /// <summary>
        /// associo o nif do cliente ao animal
        /// Crio instancia da classe lista
        /// se o ficheiro existir, abro-lo
        /// enquanto as linhas nao tiverem vazias, separo cada palavra(coluna) e leio
        /// </summary>
        /// <returns>lista de animais</returns>
        public static List<Animal> LerAnimais(string NIF)
        {
            string ficheiro = NIF + "_" + Animal.FicheiroAnimais;

            StreamReader sr;
            List<Animal> listaAnimais = new List<Animal>();

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] colunas = linha.ToString().Split('*');

                        if (colunas.Length >= 8)
                        {
                            Animal novoAnimal = new Animal
                            {
                                Id = colunas[0].ToString(),
                                Nome = colunas[1],
                                DataNascimento = Convert.ToDateTime(colunas[2]),
                                Especie = colunas[3],
                                Raca = colunas[4],
                                Peso = Convert.ToDouble(colunas[5]),
                                Genero =colunas[6],
                                Esterilizacao = Convert.ToBoolean(colunas[7]),
                            };
                            listaAnimais.Add(novoAnimal);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocorreu um erro na gravação do ficheiro", e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
            return listaAnimais;
        }
        /// <summary>
        /// chama o metodo de ler a info dos animais
        /// e se as linhas tiverem info, ativo os botoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerirAnimais_Load(object sender, EventArgs e)
        {
            foreach (Animal item in LerAnimais(dono.NIF))
            {
                animalBindingSource.Add(item);
            }

            PopularInfo();

            if (listaAnimais.Rows.Count > 0)
            {
                pbLixo.Enabled = true;
                pbMarcarConsulta.Enabled = true;
            }
        }
        /// <summary>
        /// se a lista tiver info, percorre as linhas na gridview, 
        /// instancio o objeto Animal, para poder apagar a linha, selecionada, na gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbLixo_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            if (listaAnimais.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in this.listaAnimais.SelectedRows)
                {
                    Animal apagar = (Animal)item.DataBoundItem;

                    resposta = MessageBox.Show($"Tem a certeza que quer apagar o/a {apagar.Nome}?",
                     "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        listaAnimais.Rows.RemoveAt(item.Index);
                        listaAnimais.Refresh();
                        this.dono.Animais.Remove(apagar);
                        MostraFicha();
                    }
                }
            }
        }

        private bool EsterilizadoOuNao()
        {
            bool esterilizado = false;
            if (cbCastracao.Text.Equals("Sim"))
            {
                esterilizado = true;
            }
            return esterilizado;
        }
        /// <summary>
        /// executa o metodo de validaçao, se passar, guardo as variaveis nos atributos da classe Animal
        /// coloco a info na grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbGuardar_Click(object sender, EventArgs e)
        {
            long v = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            if (ValidaAdiciona())
            {
                Animal novoAnimal = new Animal
                {
                    Id = v.ToString(),
                    Nome = tbNomeAnimal.Text,
                    DataNascimento = dateTimePickerAnimal.Value,
                    Especie = tbEspecie.Text,
                    Raca = tbRace.Text,
                    Genero = cbGenero.Text,
                    Peso = Convert.ToDouble(tbPeso.Text),
                    Esterilizacao = EsterilizadoOuNao(),
                };
                RespostaAnimal();

                this.animalBindingSource.Add(novoAnimal);
                this.dono.Animais.Add(novoAnimal);
            }
        }

        private void RespostaAnimal()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Pretente adicionar mais um Animal?", "Antes de sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == resposta || DialogResult.No == resposta)
            {
                LimpaInfo();
            }
        }
        /// <summary>
        /// metodo para validar as textbox
        /// </summary>
        /// <returns></returns>
        private bool ValidaAdiciona()
        {
            bool output = true;
            double peso;

            if (string.IsNullOrEmpty(tbNomeAnimal.Text) || tbNomeAnimal.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira o nome do Animal!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbEspecie.Text) || tbEspecie.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira a Espécie!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbRace.Text) || tbRace.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira a raça", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbGenero.Text))
            {
                MessageBox.Show("Insira o género", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbPeso.Text) || !double.TryParse(tbPeso.Text, out peso))
            {
                MessageBox.Show("Insira o peso", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbCastracao.Text))
            {
                MessageBox.Show("Indique se é, ou não, esterilizado/a", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }
     
        private void tbIdEdit_Selected(object sender, TabControlEventArgs e)
        {
            LimpaInfo();
            MostraFicha();
        }
        private void LimpaInfo()
        {
            tbId.Text = string.Empty;
            tbNomeAnimal.Text = string.Empty;
            tbEspecie.Text = string.Empty;
            tbRace.Text = string.Empty;
            tbPeso.Text = string.Empty;
            cbCastracao.Text = null;
            cbGenero.Text = null;
            tbIdEdita.Text = string.Empty;
            tbNomeEdit.Text = string.Empty;
            tbRaceEdit.Text = string.Empty;
            tbPesoEdit.Text = string.Empty;
            tbEspecieEdit.Text = string.Empty;
            cbGeneroEdit.Text = null;
            cbEsterilizaEdit.Text = null;
        }
        /// <summary>
        /// Preencher as combobox com informação
        /// </summary>
        private void PopularInfo()
        {
            cbGenero.Items.Add("Fêmea");
            cbGenero.Items.Add("Macho");
            cbGeneroEdit.Items.Add("Fêmea");
            cbGeneroEdit.Items.Add("Macho");
            cbCastracao.Items.Add("Sim");
            cbCastracao.Items.Add("Não");
            cbEsterilizaEdit.Items.Add("Sim");
            cbEsterilizaEdit.Items.Add("Não");
            dateTimePickerAnimal.MaxDate = DateTime.Now;
            dateTimePickerAnimal.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        private void CancelaSai()
        {
            MessageBox.Show("As alterações não vão ser guardadas!!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LimpaInfo();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            CancelaSai();
        }
        /// <summary>
        /// se passar pelo metodo que valida,
        /// introduz a info das textbox nos atrubutos do Animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbGuardaEdit_Click(object sender, EventArgs e)
        {
            if (listaAnimais.Rows.Count > 0)
            {
                Animal animalSelecionado = (Animal)listaAnimais.SelectedRows[0].DataBoundItem;

                if (ValidaEditar())
                {
                    animalSelecionado.Peso = Convert.ToDouble(tbPesoEdit.Text);
                    animalSelecionado.Esterilizacao = EsterilizadoOuNao();
                    listaAnimais.Refresh();
                }
            }
        }
        /// <summary>
        /// valida o input do user
        /// </summary>
        /// <returns> retorna verdade, os valores estão corretos</returns>
        private bool ValidaEditar()
        {
            bool output = true;
            double peso;

            if (string.IsNullOrEmpty(tbPesoEdit.Text) || !double.TryParse(tbPesoEdit.Text, out peso))
            {
                MessageBox.Show("Insira o peso", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbEsterilizaEdit.Text))
            {
                MessageBox.Show("Indique se é, ou não, esterilizado/a", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }

        private void PbCancelaEdit_Click(object sender, EventArgs e)
        {
            CancelaSai();
        }
        private void MostraFicha()
        {
            if (listaAnimais.SelectedRows.Count > 0)
            {
                Animal animalSelecionado = (Animal)listaAnimais.SelectedRows[0].DataBoundItem;

                tbIdEdita.Text = animalSelecionado.Id;
                tbNomeEdit.Text = animalSelecionado.Nome;
                dtConsultaEdit.Text = animalSelecionado.DataNascimento.ToString();
                tbEspecieEdit.Text = animalSelecionado.Especie;
                tbRaceEdit.Text = animalSelecionado.Raca;
                tbPesoEdit.Text = animalSelecionado.Peso.ToString();
                cbGeneroEdit.Text = animalSelecionado.Genero;
                cbEsterilizaEdit.Text = animalSelecionado.Esterilizacao.ToString();
            }
            else
            {
                LimpaInfo();
            }
        }

        private void ListaAnimais_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MostraFicha();
        }

        private void PbMarcarConsulta_Click_1(object sender, EventArgs e)
        {
            if (listaAnimais.Rows.Count > 0)
            {
                Animal nome = (Animal)listaAnimais.SelectedRows[0].DataBoundItem;

                MarcarConsulta marcar = new MarcarConsulta(dono, nome);
                marcar.ShowDialog();
            }  
        }
    }
}
