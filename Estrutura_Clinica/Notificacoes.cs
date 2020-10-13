using Clinica_Vet_Joana;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Estrutura_Clinica
{
    public partial class Notificacoes : Form
    {
        public Notificacoes()
        {
            InitializeComponent();
            this.FormClosing += Notificacoes_FormClosing;
        }
        /// <summary>
        /// Crio instancia da classe lista
        /// se o ficheiro existir, abro-lo
        /// enquanto as linhas nao tiverem vazias, separo cada palavra(coluna) e leio
        /// </summary>
        /// <returns>lista de consultas</returns>
        public static List<Consulta> LerConsultas()
        {
            StreamReader sr;
            List<Consulta> listaConsulta = new List<Consulta>();

            if (File.Exists(Consulta.FicheiroConsultas))
            {
                sr = File.OpenText(Consulta.FicheiroConsultas);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                    {
                        string[] colunas = linha.ToString().Split(',');

                        if (colunas.Length >= 8)
                        {
                            Consulta novaConsulta = new Consulta
                            {
                                Id = colunas[0].ToString(),
                                Tratamento = colunas[1],
                                MedicoSelecionado = new Medico(colunas[2]),
                                NomeAnimal = new Animal(colunas[3]),
                                DiaConsulta = Convert.ToDateTime(colunas[4]),
                                HoraConsulta = colunas[5],
                                NomeCliente = new Cliente(colunas[6]),
                                ObsConsultas = colunas[7],
                            };
                            listaConsulta.Add(novaConsulta);
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
            return listaConsulta;
        }

        /// <summary>
        /// Valida email para todos
        /// </summary>
        /// <returns></returns>
        private bool ValidaClienteTodos()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cbMsgTodos.Text))
            {
                MessageBox.Show("Os dados têm que estar todos preenchidos!", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }
        /// <summary>
        /// valida email para cliente singular
        /// </summary>
        /// <returns></returns>
        private bool ValidaCliente()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cbPara.Text) || string.IsNullOrEmpty(cbEscolherSms.Text))
            {
                MessageBox.Show("Os dados têm que estar todos preenchidos!", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }
        /// <summary>
        /// instancio as classes de mensagens de email e do protocolo de transferencia de email
        /// Envio email com um pdf anexado, aos clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbEnviarTodos_Click(object sender, System.EventArgs e)
        {
            MailMessage m = new MailMessage();
            SmtpClient sc = new SmtpClient();

            if (listaNotific.Rows.Count > 0)
            {
                if (ValidaClienteTodos())
                {
                    foreach (Cliente item in GerirClientes.LerClientes())
                    {
                        m.From = new MailAddress(tbDe.Text);
                        m.To.Add(new MailAddress(item.Email));
                        m.Subject = cbMsgTodos.Text;
                        m.IsBodyHtml = true;
                        m.Body = cbMsgTodos.Text;
                        m.BodyEncoding = System.Text.Encoding.UTF8;
                        m.Attachments.Add(new Attachment(@"ClinicaVetJoana.pdf"));

                        sc.Host = "smtp.office365.com";
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("joana.ramos.roque@formandos.cinel.pt", ".");

                        sc.EnableSsl = true;

                        if (cbMsgTodos.Text.Equals("Aviso de fecho da Clinica"))
                        {
                            m.Body = "Caros clientes, por motivos de força maior, a Clinica encontár-se-á fechada, o resto do mês corrente.\n" +
                                 "Pedimos desculpa pelo incomodo e contamos com a sua compreensão.\n" +
                                 "Obrigado. Até já!";
                        }
                        sc.Send(m);
                    }
                    MensagemInformativa();
                }
            }
        }

        private void pbEnviar_Click(object sender, System.EventArgs e)
        {
            MailMessage m = new MailMessage();
            SmtpClient sc = new SmtpClient();

            if (listaNotific.Rows.Count > 0)
            {
                Consulta notificar = (Consulta)listaNotific.SelectedRows[0].DataBoundItem;

                if (ValidaCliente())
                {
                    m.From = new MailAddress(tbDe.Text);
                    m.To.Add(new MailAddress(cbPara.Text));
                    m.Subject = cbEscolherSms.Text;
                    m.IsBodyHtml = true;
                    m.Body = cbEscolherSms.Text;
                    m.BodyEncoding = System.Text.Encoding.UTF8;
                    m.Attachments.Add(new Attachment(@"ClinicaVetJoana.pdf"));

                    sc.Host = "smtp.office365.com";
                    sc.Port = 587;
                    sc.Credentials = new System.Net.NetworkCredential("joana.ramos.roque@formandos.cinel.pt", ".");

                    sc.EnableSsl = true;

                    if (cbEscolherSms.Text.Equals("Marcaçao para o dia seguinte"))
                    {
                        m.Body = $"Olá {notificar.NomeCliente}, vimos por este meio, relembrar a sua marcação de amanhã," +
                            $" de {notificar.HoraConsulta}, " +
                            $"para o {notificar.NomeAnimal.Nome} " +
                            $"com o/a Dr/Dra {notificar.MedicoSelecionado.Nome}.\n" +
                            $"Motivo da Consulta: {notificar.ObsConsultas}.\n Até já!";
                    }
                    if (cbEscolherSms.Text.Equals("Desmarcação de Consulta"))
                    {
                        m.Body = $"Olá {notificar.NomeCliente}, vimos por este meio, desmarcar a sua consulta do animal " +
                            $"{notificar.NomeAnimal.Nome}, sendo o motivo: {notificar.ObsConsultas}, para o dia" +
                            $" {notificar.DiaConsulta.ToString("dd/MM/yyyy")}, na parte da {notificar.HoraConsulta}, " +
                            $"com o/a Dr/Dra {notificar.MedicoSelecionado.Nome}.\n" +
                            $"Por favor, queira ligar-nos para nova marcação.\n" +
                            "Pedimos desculpa pelo incomodo. Até já!";
                    }
                    sc.Send(m);
                    MensagemInformativa();
                }
            }
        }

        private void MensagemInformativa()
        {
            MessageBox.Show("O Email, com o PDF em anexo, foi enviado com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// vai ler aos ficheiros da consulta e popula a gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notificacoes_Load(object sender, System.EventArgs e)
        {
            cbEscolherSms.Items.Add("Marcaçao para o dia seguinte");
            cbEscolherSms.Items.Add("Desmarcação de Consulta");
            cbMsgTodos.Items.Add("Aviso de fecho da Clinica");

            PopularData(dtConsultasEdit);
            PopularHoras(cbHorasEdit);
            PopularConsultas(cbConsultaEdit);
            SelecionarMedicoDisponivel(cbHorasEdit);

            foreach (Cliente item in GerirClientes.LerClientes())
            {
                cbPara.Items.Add(item.Email);
            }

            foreach (Consulta item in LerConsultas())
            {
                consultaBindingSource.Add(item);
            }
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

        private void PopularData(DateTimePicker dTimePConsultas)
        {
            dTimePConsultas.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dTimePConsultas.Value = DateTime.UtcNow;
            dTimePConsultas.Format = DateTimePickerFormat.Custom;
            dTimePConsultas.CustomFormat = "dd/MM/yyyy";
        }

        private void PgGuardaEdit_Click(object sender, EventArgs e)
        {
            if (listaNotific.Rows.Count > 0)
            {
                Consulta mostrar = (Consulta)listaNotific.SelectedRows[0].DataBoundItem;

                if (ValidaEdita())
                {
                    mostrar.DiaConsulta = dtConsultasEdit.Value;
                    mostrar.MedicoSelecionado = new Medico(cbMedicoEdit.SelectedItem.ToString());
                    mostrar.Tratamento = cbConsultaEdit.Text;
                    mostrar.ObsConsultas = tbOnsEdit.Text;

                    listaNotific.Refresh();
                }
            }
        }

        private bool ValidaEdita()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cbConsultaEdit.Text))
            {
                MessageBox.Show("Tem que escolher uma consulta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (cbConsultaEdit.Text == "Outros" && string.IsNullOrEmpty(tbOutraConsultaEdit.Text))
            {
                MessageBox.Show("Tem que marcar a consulta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbMedicoEdit.Text))
            {
                MessageBox.Show("Tem que escolher o médico disponivel!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbOnsEdit.Text))
            {
                MessageBox.Show("Tem que escrever as observações da consulta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }

        private void PbCancelaEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Consulta não vai ser marcada!!", "Aviso",
         MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LimparTexto();
        }

        private void LimparTexto()
        {
            tbIdEdit.Text = string.Empty;
            tbOnsEdit.Text = string.Empty;
            tbOutraConsultaEdit.Text = string.Empty;
            cbConsultaEdit.Text = null;
            cbMedicoEdit.Text = string.Empty;
            cbHorasEdit.Text = null;
        }
        private void SelecionarMedicoDisponivel(ComboBox box)
        {
            cbMedicoEdit.Items.Clear();

            bool horaManhaSelecionada = box.Text.Split(' ')[0].Equals("Manhã");

            foreach (Medico item in GerirMedicos.LerMedicos())
            {
                bool manhaMedico = item.Horario.Split(' ')[0].Equals("Manhã");

                if (horaManhaSelecionada && manhaMedico)
                {
                    cbMedicoEdit.Items.Add(item.Nome);
                }
                else if (!horaManhaSelecionada && !manhaMedico)
                {
                    cbMedicoEdit.Items.Add(item.Nome);
                }
            }
        }
        private void MostraConsulta()
        {
            if (listaNotific.SelectedRows.Count > 0)
            {
                Consulta mostrar = (Consulta)listaNotific.SelectedRows[0].DataBoundItem;

                tbIdEdit.Text = mostrar.Id;
                dtConsultasEdit.Value = mostrar.DiaConsulta;
                cbHorasEdit.Text = mostrar.HoraConsulta;
                cbMedicoEdit.Text = mostrar.MedicoSelecionado.Nome;
                cbConsultaEdit.Text = mostrar.Tratamento;
                tbOutraConsultaEdit.Text = mostrar.Tratamento;
                tbOnsEdit.Text = mostrar.ObsConsultas;
            }
            else
            {
                LimparTexto();
            }
        }

        private void TabEditarClt_Selected(object sender, TabControlEventArgs e)
        {
            LimparTexto();
            MostraConsulta();
        }

        private void PbLixo_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            if (listaNotific.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in this.listaNotific.SelectedRows)
                {
                    Consulta apagar = (Consulta)item.DataBoundItem;

                    resposta = MessageBox.Show($"Tem a certeza que quer apagar a marcação nrº {apagar.Id} ?",
                     "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        listaNotific.Rows.RemoveAt(item.Index);
                        listaNotific.Refresh();
                        MostraConsulta();
                    }
                }
            }
        }

        private void ListaNotific_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MostraConsulta();
        }

        private void CbHorasEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarMedicoDisponivel(cbHorasEdit);
        }
        /// <summary>
        /// Crio um ficheiro e gravo em txt todas as consultas que estao na gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notificacoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter fluxoDeEscrita = File.CreateText(Consulta.FicheiroConsultas);

            try
            {
                //Iterar grid view por cada medico.
                foreach (DataGridViewRow row in listaNotific.Rows)
                {
                    Consulta consulta = (Consulta)row.DataBoundItem;

                    string linha = $"{consulta.Id},{consulta.Tratamento}," +
                        $"{consulta.MedicoSelecionado},{consulta.NomeAnimal},{consulta.DiaConsulta.ToString("dd/MM/yyyy")}," +
                        $"{consulta.HoraConsulta},{consulta.NomeCliente}," +
                        $"{consulta.ObsConsultas}";

                    //escreve linha ao ficheiro.
                    fluxoDeEscrita.WriteLine(linha);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro na gravação do ficheiro", erro.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Fechar fluxo de escrita.
                fluxoDeEscrita.Close();
            }
        }
    }
}
