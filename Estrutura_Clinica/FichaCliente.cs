using Clinica_Vet_Joana;
using System;
using System.Windows.Forms;

namespace Estrutura_Clinica
{
    public partial class FichaCliente : Form
    {
        Cliente mostrar;

        public FichaCliente(Cliente mostrar)
        {
            InitializeComponent();
            this.mostrar = mostrar;
            MostrarFicha();
            this.CenterToScreen();
        }
        /// <summary>
        /// introduz a info dos atributos do Cliente nas textbox
        /// </summary>
        private void MostrarFicha()
        {
            tbId.Text = mostrar.Id;
            textBox1Nome.Text = mostrar.Nome;
            tbEmail.Text = mostrar.Email;
            tbNIF.Text = mostrar.NIF;
            tbTelemovel.Text = mostrar.Telemovel;

            foreach (Animal item in GerirAnimais.LerAnimais(mostrar.NIF))
            {
                lbAnimais.Items.Add(item.Nome);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
