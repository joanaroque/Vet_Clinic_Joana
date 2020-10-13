using Clinica_Vet_Joana;
using System;
using System.IO;
using System.Windows.Forms;

namespace Estrutura_Clinica
{
    public partial class MarcarConsulta : Form
    {
        Cliente dono;
        Animal animal;

        public MarcarConsulta(Cliente dono, Animal nome)
        {
            InitializeComponent();
            this.dono = dono;
            this.animal = nome;
        }

        private void LimparTexto()
        {
            tbID.Text = string.Empty;
            tbOBS.Text = string.Empty;
            tbOutraConsulta.Text = string.Empty;
            cbConsultas.Text = null;
            cbMedicDisponivel.Text = null;
            cbHoras.Text = null;
        }
        /// <summary>
        ///  No texto da combobox das horas, separo as frases, agarro a manha
        ///  Faço o mesmo para o hórario dos medicos, percorrendo todos eles,
        ///  se encontrar manha no medico, mando pra combobox o medico que faz manha,
        ///  Faço o mesmo para a tarde
        /// </summary>
        /// <param name="box">recebe a combobox do medico disponivel</param>
        private void SelecionarMedicoDisponivel(ComboBox box)
        {
            cbMedicDisponivel.Items.Clear();

            bool horaManhaSelecionada = box.Text.Split(' ')[0].Equals("Manhã");

            foreach (Medico item in GerirMedicos.LerMedicos())
            {
                bool manhaMedico = item.Horario.Split(' ')[0].Equals("Manhã");

                if (horaManhaSelecionada && manhaMedico)
                {
                    cbMedicDisponivel.Items.Add(item.Nome);
                }
                else if (!horaManhaSelecionada && !manhaMedico)
                {
                    cbMedicDisponivel.Items.Add(item.Nome);
                }
            }
        }
        private void PopularHoras(ComboBox cbHoras)
        {
            cbHoras.Items.Add("Manhã 09h00 - 09h30");
            cbHoras.Items.Add("Manhã 09h30 - 10h00");
            cbHoras.Items.Add("Manhã 10h00 - 10h30");
            cbHoras.Items.Add("Manhã 10h30 - 11h00");
            cbHoras.Items.Add("Manhã 11h00 - 11h30");
            cbHoras.Items.Add("Manhã 11h30 - 12h00");
            cbHoras.Items.Add("Manhã 12h00 - 12h30");
            cbHoras.Items.Add("Manhã 12h30 - 13h00");
            cbHoras.Items.Add("Tarde 13h00 - 13h30");
            cbHoras.Items.Add("Tarde 13h30 - 14h00");
            cbHoras.Items.Add("Tarde 14h00 - 14h30");
            cbHoras.Items.Add("Tarde 14h30 - 15h00");
            cbHoras.Items.Add("Tarde 15h00 - 15h30");
            cbHoras.Items.Add("Tarde 15h30 - 16h00");
            cbHoras.Items.Add("Tarde 16h00 - 16h30");
            cbHoras.Items.Add("Tarde 16h30 - 17h00");
            cbHoras.Items.Add("Tarde 17h00 - 17h30");
            cbHoras.Items.Add("Tarde 17h30 - 18h00");
            cbHoras.Items.Add("Tarde 18h00 - 18h30");
            cbHoras.Items.Add("Tarde 18h30 - 19h00");
            cbHoras.Items.Add("Tarde 19h00 - 19h30");
            cbHoras.Items.Add("Tarde 19h30 - 20h00");
        }

        private void PopularConsultas(ComboBox cbConsultas)
        {
            cbConsultas.Items.Add("1ª Vacina");
            cbConsultas.Items.Add("2ª Vacina");
            cbConsultas.Items.Add("3ª Vacina");
            cbConsultas.Items.Add("Vacina da Lesihmaniose");
            cbConsultas.Items.Add("Vacina da Raiva");
            cbConsultas.Items.Add("RX Digital");
            cbConsultas.Items.Add("Ecografia");
            cbConsultas.Items.Add("Outros");
        }

        private void PopularData(DateTimePicker dTimePConsultas)
        {
            dTimePConsultas.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dTimePConsultas.Value = DateTime.UtcNow;
            dTimePConsultas.Format = DateTimePickerFormat.Custom;
            dTimePConsultas.CustomFormat = "dd/MM/yyyy";
        }
        private void GerarIDConsulta()
        {
            long v = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            tbID.Text = v.ToString(); 
        }
        private void MarcarConsulta_Load(object sender, EventArgs e)
        {
            PopularData(dTimePConsultas);
            PopularConsultas(cbConsultas);
            PopularHoras(cbHoras);
            GerarIDConsulta();
        }

        private bool ValidaAdiciona()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cbConsultas.Text))
            {
                MessageBox.Show("Tem que escolher uma consulta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (cbConsultas.Text == "Outros" && string.IsNullOrEmpty(tbOutraConsulta.Text))
            {
                MessageBox.Show("Tem que marcar a consulta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbMedicDisponivel.Text))
            {
                MessageBox.Show("Tem que escolher o médico disponivel!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbOBS.Text))
            {
                MessageBox.Show("Tem que escrever as observações da consulta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }
        /// <summary>
        /// construtor para uma nova consulta
        /// procuro nos ficheiros se a consulta com aquele medico existe naquele momento
        /// procuro nos ficheiros se a consulta com aquele animal existe naquele momento
        /// vejo se é fim de semana
        /// se estas 3 pesquisas foram falsas, marco a consulta e gravo no ficheiro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbGuardar_Click_1(object sender, EventArgs e)
        {
            bool encontrei = false;

            if (ValidaAdiciona())
            {
                Consulta novaConsulta = new Consulta
                {
                    Tratamento = cbConsultas.Text,
                    MedicoSelecionado = new Medico(cbMedicDisponivel.SelectedItem.ToString()),
                    NomeAnimal = new Animal(animal.Nome.ToString()),
                    NomeCliente = new Cliente(dono.Nome.ToString()),
                    DiaConsulta = Convert.ToDateTime(dTimePConsultas.Value.ToString("dd/MM/yyyy")),
                    HoraConsulta = cbHoras.Text,
                    ObsConsultas = tbOBS.Text,
                };

                foreach (Consulta item in Notificacoes.LerConsultas())
                {
                    if (item.DiaConsulta.Equals(novaConsulta.DiaConsulta) &&
                        item.MedicoSelecionado.Nome.Equals(novaConsulta.MedicoSelecionado.Nome)
                         && item.HoraConsulta.Equals(novaConsulta.HoraConsulta))
                    {
                        MessageBox.Show($"Dr/a {item.MedicoSelecionado.Nome} está em consulta a essa hora.\nEscolha outro horário ou outro Médico!",
                            "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        encontrei = true;
                        break;
                    }
                    if (item.DiaConsulta.Equals(novaConsulta.DiaConsulta) &&
                        item.NomeAnimal.Nome.Equals(novaConsulta.NomeAnimal.Nome)
                         && item.HoraConsulta.Equals(novaConsulta.HoraConsulta))
                    {
                        MessageBox.Show($"O animal {item.NomeAnimal.Nome} já tem uma Consulta para este dia, a esta hora",
                           "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        encontrei = true;
                        break;
                    }
                }
                if (dTimePConsultas.Value.DayOfWeek == DayOfWeek.Saturday || dTimePConsultas.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("A Clínica está fechada aos fins de semana.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    encontrei = true;
                    LimparTexto();
                }

                if (!encontrei)
                {
                    if (cbConsultas.Text == "Outros")
                    {
                        novaConsulta.Tratamento = tbOutraConsulta.Text + " ; " + tbOBS.Text;
                    }
                    MensagemConfirmacao();
                }
            }
        }
        private void MensagemConfirmacao()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("A Consulta foi marcada", "Informação", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

            if (DialogResult.OK == resposta)
            {
                GravarMarcacaoConsulta();
                this.Close();
            }
            LimparTexto();
        }
        /// <summary>
        /// Adiciono a nova marcação aos ficheiros das consultas todas
        /// </summary>
        private void GravarMarcacaoConsulta()
        {
            StreamWriter fluxoDeEscrita = File.AppendText(Consulta.FicheiroConsultas);
            try
            {
                string linha = $"{tbID.Text},{cbConsultas.Text},{cbMedicDisponivel.Text}," +
                    $"{animal.Nome.ToString()},{dTimePConsultas.Value.ToString("dd/MM/yyyy")},{cbHoras.Text}" +
                    $",{dono.Nome.ToString()},{tbOBS.Text}";

                fluxoDeEscrita.WriteLine(linha);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro na gravação do ficheiro", erro.ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                //Fechar fluxo de escrita.
                fluxoDeEscrita.Close();
            }
        }
        private void PbCancelar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("A Consulta não vai ser marcada!!", "Aviso",
             MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LimparTexto();
        }

        private void CbHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarMedicoDisponivel(cbHoras);
        }
    }
}



