using Clinica_Vet_Joana;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Estrutura_Clinica
{
    public partial class GerirClientes : Form
    {
        public GerirClientes()
        {
            InitializeComponent();
            this.FormClosing += GerirClientes_FormClosing;
        }
        /// <summary>
        /// no botao para fechar o form, crio ou abro um ficheiro de texto e, tento,
        /// percorrer as linhas da gridview e gravo em cada linha,
        /// todos os atributos do cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerirClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter fluxoDeEscrita = File.CreateText(Cliente.FicheiroClientes);

            try
            {
                foreach (DataGridViewRow row in listaClientes.Rows)
                {
                    Cliente cliente = (Cliente)row.DataBoundItem;

                    string linha = $"{cliente.Id},{cliente.Nome}," +
                        $"{cliente.NIF},{cliente.Telemovel},{cliente.Email}";

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
        /// Crio instancia da classe lista
        /// se o ficheiro existir, abro-lo
        /// enquanto as linhas nao tiverem vazias, separo cada palavra(coluna) e leio
        /// </summary>
        /// <returns>lista de clientes</returns>
        public static List<Cliente> LerClientes()
        {
            StreamReader sr;
            List<Cliente> listaClientes = new List<Cliente>();

            if (File.Exists(Cliente.FicheiroClientes))
            {
                sr = File.OpenText(Cliente.FicheiroClientes);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                    {
                        string[] colunas = linha.ToString().Split(',');

                        if (colunas.Length >= 5)
                        {
                            Cliente novoCliente = new Cliente
                            {
                                Id = colunas[0],
                                Nome = colunas[1],
                                NIF = colunas[2],
                                Telemovel = colunas[3],
                                Email = colunas[4],
                            };
                            listaClientes.Add(novoCliente);
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro na gravação do ficheiro", erro.ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
            return listaClientes;
        }
        /// <summary>
        /// chama o metodo de ler a info dos clientes
        /// e se as linhas tiverem info, ativo os botoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerirClientes_Load(object sender, EventArgs e)
        {
            foreach (Cliente item in LerClientes())
            {
                clienteBindingSource.Add(item);
            }

            if (listaClientes.Rows.Count > 0)
            {
                pbGerirAnimal.Enabled = true;
                pbLixo.Enabled = true;
            }
        }

        private bool ValidaAdiciona()
        {
            bool output = true;
            char arroba = '@';

            if (string.IsNullOrEmpty(tbNome.Text) || tbNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira o nome!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbNif.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(tbNif.Text, "^[0-9]*$") || tbNif.Text.Length != 9)
            {
                MessageBox.Show("Insira o NIF corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            foreach (Cliente item in clienteBindingSource)
            {
                if (tbNif.Text == item.NIF)
                {
                    MessageBox.Show($"O Cliente com o NIF {item.NIF}, insira um novo Cliente", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tbNif.Text = string.Empty;

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
            if (string.IsNullOrEmpty(tbMail.Text) || !tbMail.Text.Contains(Convert.ToString(arroba)))
            {
                MessageBox.Show("Insira o Email corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }

        private void CancelarAddEdit()
        {
            MessageBox.Show("As alterações não vão ser guardadas!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LimpaCampos();
        }
        private void LimpaCampos()
        {
            tbIdEdit.Text = string.Empty;
            tbNomeEdit.Text = string.Empty;
            tbMailEdit.Text = string.Empty;
            tbNifEdit.Text = string.Empty;
            tbTelemovelEdit.Text = string.Empty;
            tbId.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbTelemovel.Text = string.Empty;
            tbMail.Text = string.Empty;
            tbNif.Text = string.Empty;
        }
        /// <summary>
        /// introduz a info dos atributos do Cliente nas textbox
        /// </summary>
        private void MostrarFicha()
        {
            if (listaClientes.SelectedRows.Count > 0)
            {
                Cliente clienteAtual = (Cliente)listaClientes.SelectedRows[0].DataBoundItem;

                tbIdEdit.Text = clienteAtual.Id;
                tbNomeEdit.Text = clienteAtual.Nome;
                tbMailEdit.Text = clienteAtual.Email;
                tbNifEdit.Text = clienteAtual.NIF;
                tbTelemovelEdit.Text = clienteAtual.Telemovel;
            }
            else
            {
                LimpaCampos();
            }
        }
        /// <summary>
        /// valida o input do user
        /// </summary>
        /// <returns> retorna verdade, os valores estão corretos</returns>
        private bool ValidaEdit()
        {
            bool output = true;
            char arroba = '@';

            if (string.IsNullOrEmpty(tbTelemovelEdit.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(tbTelemovelEdit.Text, "^[0-9]*$") || tbTelemovelEdit.Text.Length != 9)
            {
                MessageBox.Show("Insira o número de Telemóvel corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbMailEdit.Text) || !tbMailEdit.Text.Contains(Convert.ToString(arroba)))
            {
                MessageBox.Show("Insira o Email corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }
        /// <summary>
        /// se a lista tiver preenchida, percorre cada linha da gridview,
        /// mostra a info da grid nas textbox do novo form, que é aberto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbGerirAnimal_Click_1(object sender, EventArgs e)
        {
            if (listaClientes.Rows.Count > 0)
            {
                Cliente mostrar = (Cliente)listaClientes.CurrentRow.DataBoundItem;

                foreach (DataGridViewRow item in this.listaClientes.SelectedRows)
                {
                    GerirAnimais gerir = new GerirAnimais(mostrar);
                    gerir.ShowDialog();
                }
            }
        }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            long v = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            if (ValidaAdiciona())
            {
                Cliente novoCliente = new Cliente
                {
                    Id = v.ToString(),
                    Nome = tbNome.Text,
                    NIF = tbNif.Text,
                    Telemovel = tbTelemovel.Text,
                    Email = tbMail.Text,
                };

                this.clienteBindingSource.Add(novoCliente);
                LimpaCampos();
                pbGerirAnimal.Enabled = true;
                pbLixo.Enabled = true;
            }
        }
        /// <summary>
        /// se a lista tiver info, percorre as linhas na gridview, 
        /// instancio o objeto Cliente, para poder apagar a linha, selecionada, na gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pbLixo_Click_1(object sender, EventArgs e)
        {
            DialogResult resposta;

            if (listaClientes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.listaClientes.SelectedRows)
                {
                    Cliente apagar = (Cliente)item.DataBoundItem;

                    resposta = MessageBox.Show($"Tem a certeza que quer apagar o Cliente {apagar.Nome}?",
                     "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        listaClientes.Rows.RemoveAt(item.Index);
                        listaClientes.Refresh();
                        MostrarFicha();
                    }
                }
            }
        }

        private void ListaClientes_DoubleClick_1(object sender, EventArgs e)
        {
            if (listaClientes.SelectedRows.Count > 0)
            {
                Cliente mostrar = (Cliente)listaClientes.CurrentRow.DataBoundItem;

                FichaCliente verFicha = new FichaCliente(mostrar);
                verFicha.ShowDialog();
            }
        }
        /// <summary>
        /// se passar pelo metodo que valida,
        /// introduz a info das textbox nos atrubutos do Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbGuardarEdit_Click(object sender, EventArgs e)
        {
            if (listaClientes.SelectedRows.Count > 0)
            {
                if (ValidaEdit())
                {
                    Cliente clienteAtual = (Cliente)listaClientes.SelectedRows[0].DataBoundItem;

                    clienteAtual.Telemovel = tbTelemovelEdit.Text;
                    clienteAtual.Email = tbMailEdit.Text;

                    listaClientes.Refresh();

                    LimpaCampos();
                }
            }
        }

        private void PbCancelEdit_Click(object sender, EventArgs e)
        {
            CancelarAddEdit();
        }

        private void PbCancel_Click(object sender, EventArgs e)
        {
            CancelarAddEdit();
        }

        private void ListaClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MostrarFicha();
        }

        private void TabEditarClt_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpaCampos();
            MostrarFicha();
        }
    }
}