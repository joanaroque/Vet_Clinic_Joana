using Clinica_Vet_Joana;
using System;
using System.Windows.Forms;


namespace Estrutura_Clinica
{
    public partial class PaginaInicial : Form
    {
        public DateTime Data { get; set; }
        public string Mensagem { get; set; }

        public PaginaInicial()
        {
            InitializeComponent();
            this.FormClosing += PaginaInicial_FormClosing;
            InfoClinica();
            VersaoJoana();   
        }
        private void InfoClinica()
        {
            Data = DateTime.UtcNow;
            lbData.Text = $"Lisboa, " + Data.ToString("");
            lblInfo.Text = "Hórario da Clínica: de segunda a sexta - das 09h ás 20h";

            MessageBox.Show(">>>  Ver as Marcações de amanhã para enviar Email  <<<",
              "^^^^^^^^^^^^^^^^^^   Lembrete   ^^^^^^^^^^^^^^^^^^",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void PaginaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Ao fechar o programa, vai gravar todos os dados.",
                "~~~  Informação  ~~~", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PbMedicos_Click(object sender, EventArgs e)
        {
            GerirMedicos gerir = new GerirMedicos();
            gerir.ShowDialog();
        }

        private void PbClientes_Click(object sender, EventArgs e)
        {
            GerirClientes gerir = new GerirClientes();
            gerir.ShowDialog();
        }
        private void VersaoJoana()
        {
            lblVersao.Text = "Versão 1.0\n\nTodos os direitos reservados.\n\nJoana Roque";
        }

        private void PbNotificar_Click(object sender, EventArgs e)
        {
            Notificacoes notificar = new Notificacoes();
            notificar.ShowDialog();
        }
    }
}
