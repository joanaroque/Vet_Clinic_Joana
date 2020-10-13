using Clinica_Vet_Joana;
using System;
using System.Windows.Forms;

namespace Estrutura_Clinica
{
    public partial class AdicionarCliente : Form
    {
        BindingSource clienteBindingSource;

        public AdicionarCliente(BindingSource clienteBindingSource)
        {
            InitializeComponent();
            this.clienteBindingSource = clienteBindingSource;
            this.CenterToScreen();
        }
        /// <summary>
        /// faz o método de validaçao, se passar, guarda a informação nos atributos
        /// da classe Cliente e passa a info pra grid view
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            long v = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            if (ValidaForm())
            {
                Cliente novoCliente = new Cliente
                {
                    Id = v.ToString(),
                    Nome = textBox1Nome.Text,
                    NIF = tbNIF.Text,
                    Telemovel = tbTelemovel.Text,
                    Email = tbEmail.Text,
                };

                this.clienteBindingSource.Add(novoCliente);
                this.Close();
            }
        }
        /// <summary>
        /// valida o input do user
        /// </summary>
        /// <returns> retorna verdade, os valores estão corretos </returns>
        private bool ValidaForm()
        {
            bool output = true;
            char arroba = '@';

            if (string.IsNullOrEmpty(textBox1Nome.Text))
            {
                MessageBox.Show("Insira o primeiro nome!", "Erro",
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
            return output;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Cliente não vai ser adicionado!!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }
    }
}
