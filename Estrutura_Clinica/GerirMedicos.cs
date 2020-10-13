using Clinica_Vet_Joana;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Estrutura_Clinica
{
    public partial class GerirMedicos : Form
    {
        public GerirMedicos()
        {
            InitializeComponent();
            this.FormClosing += GerirMedicos_FormClosing;
        }

        private void GerirMedicos_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter fluxoDeEscrita = File.CreateText(Medico.FicheiroMedicos);

            try
            {
                foreach (DataGridViewRow row in listaMedicos.Rows)
                {
                    Medico medico = (Medico)row.DataBoundItem;

                    string linha = $"{medico.Id},{medico.Nome},{medico.Especialidade},{medico.Cedula}," +
                        $"{medico.Email},{medico.Telemovel},{medico.NIF},{medico.Horario}," +
                        $"{medico.SalaObs}";

                    //escreve linha ao ficheiro.
                    fluxoDeEscrita.WriteLine(linha);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro na gravação do ficheiro", erro.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Iterar grid view por cada medico.
            finally
            {
                //Fechar fluxo de escrita.
                fluxoDeEscrita.Close();
            }
        }
        /// <summary>
        /// Crio instancia da classe lista
        /// se o ficheiro existir, abro-lo
        /// enquanto as linhas nao tiverem vazias, separo cada palavra(coluna) e leio
        /// </summary>
        /// <returns>lista de medicos</returns>
        public static List<Medico> LerMedicos()
        {
            StreamReader sr;

            List<Medico> listaMedicos = new List<Medico>();

            if (File.Exists(Medico.FicheiroMedicos))
            {
                sr = File.OpenText(Medico.FicheiroMedicos);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] colunas = linha.ToString().Split(',');

                        if (colunas.Length >= 9)
                        {
                            Medico novoMedico = new Medico
                            {
                                Id = colunas[0].ToString(),
                                Nome = colunas[1],
                                Especialidade = colunas[2],
                                Cedula = Convert.ToInt32(colunas[3]),
                                Email = colunas[4],
                                Telemovel = colunas[5],
                                NIF = colunas[6],
                                Horario = colunas[7],
                                SalaObs = colunas[8],
                            };
                            listaMedicos.Add(novoMedico);
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro na gravação do ficheiro", erro.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
            return listaMedicos;
        }

        private void PbGuardar_Click(object sender, EventArgs e)
        {
            long v = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
           
            if (ValidaForm())
            {
                Medico novoMedico = new Medico
                {
                    Id = v.ToString(),
                    Nome = textBox1Nome.Text,
                    Especialidade = cbEspecialidade.Text,
                    Cedula = Convert.ToInt32(tbCedula.Text),
                    NIF = tbNIF.Text,
                    Telemovel = tbTelemovel.Text,
                    Email = tbEmail.Text,
                    Horario = cbHorario.Text,
                    SalaObs = cbSO.Text,
                };

                medicoBindingSource.Add(novoMedico);
                LimpaCampos();
            }
        }
        /// <summary>
        /// valida o input do user
        /// </summary>
        /// <returns> retorna verdade, os valores estão corretos</returns>
        private bool ValidaForm()
        {
            bool output = true;
            char arroba = '@';

            if (string.IsNullOrEmpty(textBox1Nome.Text) || textBox1Nome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira o primeiro nome!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbEspecialidade.Text))
            {
                MessageBox.Show("Insira a Especialidade!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                output = false;
            }
            if (string.IsNullOrEmpty(tbCedula.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(tbCedula.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Insira o número da Cédula corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbNIF.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(tbNIF.Text, "^[0-9]*$") || tbNIF.Text.Length != 9)
            {
                MessageBox.Show("Insira o NIF corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            foreach (Medico item in medicoBindingSource)
            {
                if (tbNIF.Text == item.NIF)
                {
                    MessageBox.Show($"Já existe Médico com o NIF {item.NIF}, insira um novo Médico", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tbNIF.Text = string.Empty;

                    output = false;
                }
                if (tbCedula.Text == item.Cedula.ToString())
                {
                    MessageBox.Show($"Já existe Médico com a Cédula {item.Cedula}, insira um novo Médico", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tbCedula.Text = string.Empty;
                    output = false;
                }
            }
            if (string.IsNullOrEmpty(tbTelemovel.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(tbTelemovel.Text, "^[0-9]*$") || tbTelemovel.Text.Length != 9)
            {
                MessageBox.Show("Insira o número de Telemóvel corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbEmail.Text) || !tbEmail.Text.Contains(Convert.ToString(arroba)))
            {
                MessageBox.Show("Insira o Email corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbHorario.Text))
            {
                MessageBox.Show("Insira o Hórario!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbSO.Text))
            {
                MessageBox.Show("Insira a sala de observação!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }
        /// <summary>
        /// preenche as combobox com texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopularCbAdiciona()
        {
            cbEspecialidade.Items.Add("Dermatologia");
            cbEspecialidade.Items.Add("Oftalmologia");
            cbEspecialidade.Items.Add("Cardiologia");
            cbEspecialidade.Items.Add("Neurologia");
            cbEspecialidade.Items.Add("Ortopedia");
            cbEspecialidade.Items.Add("Odontologia");

            cbHorario.Items.Add("Manhã (09h - 13h)");
            cbHorario.Items.Add("Tarde (13h - 20h)");

            cbSO.Items.Add("Sala Observação 1");
            cbSO.Items.Add("Sala Observação 2");
            cbSO.Items.Add("Sala Observação 3");
        }
        private void PopularCbEdita()
        {
            cbEspecialiEdit.Items.Add("Dermatologia");
            cbEspecialiEdit.Items.Add("Oftalmologia");
            cbEspecialiEdit.Items.Add("Cardiologia");
            cbEspecialiEdit.Items.Add("Neurologia");
            cbEspecialiEdit.Items.Add("Ortopedia");
            cbEspecialiEdit.Items.Add("Odontologia");

            cbHorarioEdit.Items.Add("Manhã (10h - 16h)");
            cbHorarioEdit.Items.Add("Tarde (13h - 20h)");

            cbSOEdit.Items.Add("Sala Observação 1");
            cbSOEdit.Items.Add("Sala Observação 2");
            cbSOEdit.Items.Add("Sala Observação 3");
        }

        private void PbGuardarEdit_Click(object sender, EventArgs e)
        {
            if (listaMedicos.SelectedRows.Count > 0)
            {
                Medico medicoAtual = (Medico)listaMedicos.SelectedRows[0].DataBoundItem;

                if (ValidaEdit())
                {
                    medicoAtual.Telemovel = tbTelemovelEdit.Text;
                    medicoAtual.Email = tbEmailEdit.Text;
                    medicoAtual.Horario = cbHorarioEdit.Text;
                    medicoAtual.SalaObs = cbSOEdit.Text;

                    listaMedicos.Refresh();
                    LimpaCampos();
                }
            }
        }

        private void LimpaCampos()
        {
            tbIdEdit.Text = string.Empty;
            tbNomeEdit.Text = string.Empty;
            cbEspecialiEdit.Text = null;
            tbCedulaEdit.Text = string.Empty;
            tbEmailEdit.Text = string.Empty;
            cbHorarioEdit.Text = null;
            tbNifEdit.Text = string.Empty;
            tbTelemovelEdit.Text = string.Empty;
            cbSOEdit.Text = null;
            tbId.Text = string.Empty;
            textBox1Nome.Text = string.Empty;
            tbNIF.Text = string.Empty;
            cbEspecialidade.Text = null;
            cbHorario.Text = null;
            tbCedula.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbTelemovel.Text = string.Empty;
            cbSO.Text = null;
        }

        private bool ValidaEdit()
        {
            bool output = true;
            char arroba = '@';

            if (string.IsNullOrEmpty(cbEspecialiEdit.Text))
            {
                MessageBox.Show("Insira a Especialidade!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbTelemovelEdit.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(tbTelemovelEdit.Text, "^[0-9]*$") || tbTelemovelEdit.Text.Length != 9)
            {
                MessageBox.Show("Insira o número de Telemóvel corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }

            if (string.IsNullOrEmpty(tbEmailEdit.Text) || !tbEmailEdit.Text.Contains(Convert.ToString(arroba)))
            {
                MessageBox.Show("Insira o Email corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbHorarioEdit.Text))
            {
                MessageBox.Show("Insira o Hórario!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbSOEdit.Text))
            {
                MessageBox.Show("Insira a sala de observação!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }

        /// <summary>
        /// se a lista tiver info, percorre as linhas na gridview, 
        /// instancio o objeto Medico, para poder apagar a linha, selecionada, na gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbLixo_Click(object sender, EventArgs e)
        {
            if (listaMedicos.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in this.listaMedicos.SelectedRows)
                {
                    Medico apagar = (Medico)item.DataBoundItem;

                    foreach (Consulta consulta in Notificacoes.LerConsultas())
                    {
                        if (apagar.Nome == consulta.MedicoSelecionado.Nome && consulta.DiaConsulta > DateTime.UtcNow)
                        {
                            MessageBox.Show($"Não pode apagar o/a Dr/Dra {apagar.Nome}, pois tem consultas agendadas.", 
                                "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    DialogResult resposta;

                    resposta = MessageBox.Show($"Tem a certeza que quer apagar o Dr {apagar.Nome}?",
                     "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        listaMedicos.Rows.RemoveAt(item.Index);
                        listaMedicos.Refresh();
                        MostraFicha();
                    }
                }
            }
        }
        private void CancelaSai()
        {
            MessageBox.Show("As alterações não vão ser guardadas!!", "Aviso",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LimpaCampos();
        }
        private void PbCancelEdit_Click(object sender, EventArgs e)
        {
            CancelaSai();
        }

        private void PbCancel_Click_1(object sender, EventArgs e)
        {
            CancelaSai();
        }

        private void MostraFicha()
        {
            if (listaMedicos.SelectedRows.Count > 0)
            {
                Medico medicoAtual = (Medico)listaMedicos.SelectedRows[0].DataBoundItem;

                tbIdEdit.Text = medicoAtual.Id;
                tbNomeEdit.Text = medicoAtual.Nome;
                cbEspecialiEdit.Text = medicoAtual.Especialidade;
                tbCedulaEdit.Text = medicoAtual.Cedula.ToString();
                tbEmailEdit.Text = medicoAtual.Email;
                cbHorarioEdit.Text = medicoAtual.Horario;
                tbNifEdit.Text = medicoAtual.NIF;
                tbTelemovelEdit.Text = medicoAtual.Telemovel;
                cbSOEdit.Text = medicoAtual.SalaObs;
            }
            else
            {
                LimpaCampos();
            }
        }
        private void TabAdMed_Selected_1(object sender, TabControlEventArgs e)
        {
            LimpaCampos();
            MostraFicha();
        }

        private void ListaMedicos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MostraFicha();
        }
        /// <summary>
        /// crio ou abro um ficheiro de texto e, tento,
        /// percorrer as linhas da gridview e gravo em cada linha,
        /// todos os atributos do Medico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerirMedicos_Load(object sender, EventArgs e)
        {
            foreach (Medico item in LerMedicos())
            {
                medicoBindingSource.Add(item);
            }

            PopularCbAdiciona();
            PopularCbEdita();

            if (listaMedicos.Rows.Count > 0)
            {
                pbLixo.Enabled = true;
            }
        }
    }
}

