using Clinica_Vet_Joana;
using System;
using System.Windows.Forms;

namespace Estrutura_Clinica
{
    public partial class EditarCliente : Form
    {
        Cliente mostrar;
        DataGridView gridView;

        public EditarCliente(Cliente mostrar, DataGridView gridView)
        {
            InitializeComponent();
            this.gridView = gridView;
            this.mostrar = mostrar;
            MostrarFicha();
            this.CenterToScreen();
        }
        /// <summary>
        /// introduz a info dos atributos do Animal nas textbox
        /// </summary>
        private void MostrarFicha()
        {
            textBox1Nome.Text = mostrar.Nome.ToString();
            tbEmail.Text = mostrar.Email.ToString();
            tbNIF.Text = mostrar.NIF.ToString();
            tbTelemovel.Text = mostrar.Telemovel.ToString(); 
        }
        /// <summary>
        /// se passar pelo metodo que valida,
        /// introduz a info das textbox nos atrubutos do Animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                mostrar.Id = tbId.Text;
                mostrar.Nome = textBox1Nome.Text;
                mostrar.NIF = tbNIF.Text;
                mostrar.Telemovel = tbTelemovel.Text;
                mostrar.Email = tbEmail.Text;

                gridView.Refresh();
                this.Close();
            }
        }
        /// <summary>
        /// valida o input do user
        /// </summary>
        /// <returns> retorna verdade, os valores estão corretos</returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tbTelemovel.Text))
            {
                MessageBox.Show("Insira o número de Telemóvel corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Insira o Email corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Cliente não vai ser editado!!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }
    }
}
