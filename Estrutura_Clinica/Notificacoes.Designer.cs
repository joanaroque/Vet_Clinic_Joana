namespace Estrutura_Clinica
{
    partial class Notificacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificacoes));
            this.tabEditarClt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbHorasEdit = new System.Windows.Forms.ComboBox();
            this.tbIdEdit = new System.Windows.Forms.TextBox();
            this.cbMedicoEdit = new System.Windows.Forms.ComboBox();
            this.tbOutraConsultaEdit = new System.Windows.Forms.TextBox();
            this.cbConsultaEdit = new System.Windows.Forms.ComboBox();
            this.dtConsultasEdit = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tbOnsEdit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pbCancelaEdit = new System.Windows.Forms.PictureBox();
            this.pgGuardaEdit = new System.Windows.Forms.PictureBox();
            this.noti1cliente = new System.Windows.Forms.TabPage();
            this.pbEnviar = new System.Windows.Forms.PictureBox();
            this.cbPara = new System.Windows.Forms.ComboBox();
            this.tbDe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEscolherSms = new System.Windows.Forms.ComboBox();
            this.notificarTodosClientes = new System.Windows.Forms.TabPage();
            this.tbDemimPTodos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMsgTodos = new System.Windows.Forms.ComboBox();
            this.pbEnviarTodos = new System.Windows.Forms.PictureBox();
            this.listaNotific = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoSelecionadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsConsultasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbLixo = new System.Windows.Forms.PictureBox();
            this.tabEditarClt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelaEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGuardaEdit)).BeginInit();
            this.noti1cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnviar)).BeginInit();
            this.notificarTodosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnviarTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNotific)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEditarClt
            // 
            this.tabEditarClt.Controls.Add(this.tabPage1);
            this.tabEditarClt.Controls.Add(this.noti1cliente);
            this.tabEditarClt.Controls.Add(this.notificarTodosClientes);
            this.tabEditarClt.Location = new System.Drawing.Point(758, 34);
            this.tabEditarClt.Name = "tabEditarClt";
            this.tabEditarClt.SelectedIndex = 0;
            this.tabEditarClt.Size = new System.Drawing.Size(310, 446);
            this.tabEditarClt.TabIndex = 188;
            this.tabEditarClt.Tag = "";
            this.tabEditarClt.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabEditarClt_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.cbHorasEdit);
            this.tabPage1.Controls.Add(this.tbIdEdit);
            this.tabPage1.Controls.Add(this.cbMedicoEdit);
            this.tabPage1.Controls.Add(this.tbOutraConsultaEdit);
            this.tabPage1.Controls.Add(this.cbConsultaEdit);
            this.tabPage1.Controls.Add(this.dtConsultasEdit);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tbOnsEdit);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.pbCancelaEdit);
            this.tabPage1.Controls.Add(this.pgGuardaEdit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 420);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Editar Consulta";
            // 
            // cbHorasEdit
            // 
            this.cbHorasEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorasEdit.FormattingEnabled = true;
            this.cbHorasEdit.Location = new System.Drawing.Point(128, 66);
            this.cbHorasEdit.Name = "cbHorasEdit";
            this.cbHorasEdit.Size = new System.Drawing.Size(157, 21);
            this.cbHorasEdit.TabIndex = 254;
            this.cbHorasEdit.SelectedIndexChanged += new System.EventHandler(this.CbHorasEdit_SelectedIndexChanged);
            // 
            // tbIdEdit
            // 
            this.tbIdEdit.Enabled = false;
            this.tbIdEdit.Location = new System.Drawing.Point(128, 12);
            this.tbIdEdit.Name = "tbIdEdit";
            this.tbIdEdit.Size = new System.Drawing.Size(157, 20);
            this.tbIdEdit.TabIndex = 248;
            // 
            // cbMedicoEdit
            // 
            this.cbMedicoEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicoEdit.FormattingEnabled = true;
            this.cbMedicoEdit.Location = new System.Drawing.Point(127, 97);
            this.cbMedicoEdit.Name = "cbMedicoEdit";
            this.cbMedicoEdit.Size = new System.Drawing.Size(157, 21);
            this.cbMedicoEdit.TabIndex = 246;
            // 
            // tbOutraConsultaEdit
            // 
            this.tbOutraConsultaEdit.Location = new System.Drawing.Point(128, 158);
            this.tbOutraConsultaEdit.Name = "tbOutraConsultaEdit";
            this.tbOutraConsultaEdit.Size = new System.Drawing.Size(157, 20);
            this.tbOutraConsultaEdit.TabIndex = 243;
            // 
            // cbConsultaEdit
            // 
            this.cbConsultaEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultaEdit.FormattingEnabled = true;
            this.cbConsultaEdit.Location = new System.Drawing.Point(127, 127);
            this.cbConsultaEdit.Name = "cbConsultaEdit";
            this.cbConsultaEdit.Size = new System.Drawing.Size(157, 21);
            this.cbConsultaEdit.TabIndex = 240;
            // 
            // dtConsultasEdit
            // 
            this.dtConsultasEdit.CalendarMonthBackground = System.Drawing.Color.Coral;
            this.dtConsultasEdit.CalendarTitleBackColor = System.Drawing.Color.DarkOliveGreen;
            this.dtConsultasEdit.CustomFormat = "";
            this.dtConsultasEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtConsultasEdit.Location = new System.Drawing.Point(127, 38);
            this.dtConsultasEdit.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtConsultasEdit.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtConsultasEdit.Name = "dtConsultasEdit";
            this.dtConsultasEdit.Size = new System.Drawing.Size(157, 20);
            this.dtConsultasEdit.TabIndex = 239;
            this.dtConsultasEdit.Value = new System.DateTime(2020, 2, 22, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(19, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 253;
            this.label12.Text = "Horas:";
            // 
            // tbOnsEdit
            // 
            this.tbOnsEdit.Location = new System.Drawing.Point(19, 205);
            this.tbOnsEdit.MaxLength = 200;
            this.tbOnsEdit.Multiline = true;
            this.tbOnsEdit.Name = "tbOnsEdit";
            this.tbOnsEdit.Size = new System.Drawing.Size(266, 132);
            this.tbOnsEdit.TabIndex = 250;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(19, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 249;
            this.label13.Text = "Observações:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(19, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 15);
            this.label14.TabIndex = 247;
            this.label14.Text = "Id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(19, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 15);
            this.label15.TabIndex = 245;
            this.label15.Text = "Médico:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(19, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 244;
            this.label16.Text = "Dia:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(16, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 15);
            this.label17.TabIndex = 242;
            this.label17.Text = "Outra Consulta:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(16, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 241;
            this.label18.Text = "Consulta:";
            // 
            // pbCancelaEdit
            // 
            this.pbCancelaEdit.Image = global::Estrutura_Clinica.Properties.Resources.canceeel;
            this.pbCancelaEdit.Location = new System.Drawing.Point(217, 357);
            this.pbCancelaEdit.Name = "pbCancelaEdit";
            this.pbCancelaEdit.Size = new System.Drawing.Size(68, 58);
            this.pbCancelaEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCancelaEdit.TabIndex = 252;
            this.pbCancelaEdit.TabStop = false;
            this.pbCancelaEdit.Click += new System.EventHandler(this.PbCancelaEdit_Click);
            // 
            // pgGuardaEdit
            // 
            this.pgGuardaEdit.Image = global::Estrutura_Clinica.Properties.Resources.save;
            this.pgGuardaEdit.Location = new System.Drawing.Point(138, 357);
            this.pgGuardaEdit.Name = "pgGuardaEdit";
            this.pgGuardaEdit.Size = new System.Drawing.Size(68, 58);
            this.pgGuardaEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pgGuardaEdit.TabIndex = 251;
            this.pgGuardaEdit.TabStop = false;
            this.pgGuardaEdit.Click += new System.EventHandler(this.PgGuardaEdit_Click);
            // 
            // noti1cliente
            // 
            this.noti1cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.noti1cliente.Controls.Add(this.pbEnviar);
            this.noti1cliente.Controls.Add(this.cbPara);
            this.noti1cliente.Controls.Add(this.tbDe);
            this.noti1cliente.Controls.Add(this.label10);
            this.noti1cliente.Controls.Add(this.label9);
            this.noti1cliente.Controls.Add(this.label8);
            this.noti1cliente.Controls.Add(this.cbEscolherSms);
            this.noti1cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noti1cliente.Location = new System.Drawing.Point(4, 22);
            this.noti1cliente.Name = "noti1cliente";
            this.noti1cliente.Padding = new System.Windows.Forms.Padding(3);
            this.noti1cliente.Size = new System.Drawing.Size(302, 420);
            this.noti1cliente.TabIndex = 0;
            this.noti1cliente.Text = "Notificar Cliente";
            // 
            // pbEnviar
            // 
            this.pbEnviar.Image = global::Estrutura_Clinica.Properties.Resources.send;
            this.pbEnviar.Location = new System.Drawing.Point(122, 285);
            this.pbEnviar.Name = "pbEnviar";
            this.pbEnviar.Size = new System.Drawing.Size(132, 89);
            this.pbEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnviar.TabIndex = 179;
            this.pbEnviar.TabStop = false;
            this.pbEnviar.Click += new System.EventHandler(this.pbEnviar_Click);
            // 
            // cbPara
            // 
            this.cbPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPara.FormattingEnabled = true;
            this.cbPara.Location = new System.Drawing.Point(15, 98);
            this.cbPara.Name = "cbPara";
            this.cbPara.Size = new System.Drawing.Size(255, 23);
            this.cbPara.TabIndex = 178;
            // 
            // tbDe
            // 
            this.tbDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDe.Location = new System.Drawing.Point(15, 47);
            this.tbDe.Name = "tbDe";
            this.tbDe.ReadOnly = true;
            this.tbDe.Size = new System.Drawing.Size(255, 21);
            this.tbDe.TabIndex = 176;
            this.tbDe.Text = "joana.ramos.roque@formandos.cinel.pt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 175;
            this.label10.Text = "Assunto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 174;
            this.label9.Text = "De:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 173;
            this.label8.Text = "Para:";
            // 
            // cbEscolherSms
            // 
            this.cbEscolherSms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscolherSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEscolherSms.FormattingEnabled = true;
            this.cbEscolherSms.Location = new System.Drawing.Point(15, 161);
            this.cbEscolherSms.Name = "cbEscolherSms";
            this.cbEscolherSms.Size = new System.Drawing.Size(255, 23);
            this.cbEscolherSms.TabIndex = 172;
            // 
            // notificarTodosClientes
            // 
            this.notificarTodosClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.notificarTodosClientes.Controls.Add(this.tbDemimPTodos);
            this.notificarTodosClientes.Controls.Add(this.label1);
            this.notificarTodosClientes.Controls.Add(this.label2);
            this.notificarTodosClientes.Controls.Add(this.cbMsgTodos);
            this.notificarTodosClientes.Controls.Add(this.pbEnviarTodos);
            this.notificarTodosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificarTodosClientes.Location = new System.Drawing.Point(4, 22);
            this.notificarTodosClientes.Name = "notificarTodosClientes";
            this.notificarTodosClientes.Padding = new System.Windows.Forms.Padding(3);
            this.notificarTodosClientes.Size = new System.Drawing.Size(302, 420);
            this.notificarTodosClientes.TabIndex = 1;
            this.notificarTodosClientes.Text = "Notificar todos os Clientes";
            // 
            // tbDemimPTodos
            // 
            this.tbDemimPTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDemimPTodos.Location = new System.Drawing.Point(15, 47);
            this.tbDemimPTodos.Name = "tbDemimPTodos";
            this.tbDemimPTodos.ReadOnly = true;
            this.tbDemimPTodos.Size = new System.Drawing.Size(255, 21);
            this.tbDemimPTodos.TabIndex = 176;
            this.tbDemimPTodos.Text = "joana.ramos.roque@formandos.cinel.pt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 175;
            this.label1.Text = "Assunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 174;
            this.label2.Text = "De:";
            // 
            // cbMsgTodos
            // 
            this.cbMsgTodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMsgTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMsgTodos.FormattingEnabled = true;
            this.cbMsgTodos.Location = new System.Drawing.Point(15, 132);
            this.cbMsgTodos.Name = "cbMsgTodos";
            this.cbMsgTodos.Size = new System.Drawing.Size(255, 23);
            this.cbMsgTodos.TabIndex = 172;
            // 
            // pbEnviarTodos
            // 
            this.pbEnviarTodos.Image = global::Estrutura_Clinica.Properties.Resources.send;
            this.pbEnviarTodos.Location = new System.Drawing.Point(121, 286);
            this.pbEnviarTodos.Name = "pbEnviarTodos";
            this.pbEnviarTodos.Size = new System.Drawing.Size(138, 88);
            this.pbEnviarTodos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnviarTodos.TabIndex = 179;
            this.pbEnviarTodos.TabStop = false;
            this.pbEnviarTodos.Click += new System.EventHandler(this.pbEnviarTodos_Click);
            // 
            // listaNotific
            // 
            this.listaNotific.AllowUserToAddRows = false;
            this.listaNotific.AllowUserToDeleteRows = false;
            this.listaNotific.AllowUserToResizeColumns = false;
            this.listaNotific.AllowUserToResizeRows = false;
            this.listaNotific.AutoGenerateColumns = false;
            this.listaNotific.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listaNotific.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaNotific.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeAnimal,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.tratamentoDataGridViewTextBoxColumn,
            this.medicoSelecionadoDataGridViewTextBoxColumn,
            this.diaConsultaDataGridViewTextBoxColumn,
            this.horaConsultaDataGridViewTextBoxColumn,
            this.obsConsultasDataGridViewTextBoxColumn});
            this.listaNotific.DataSource = this.consultaBindingSource;
            this.listaNotific.Location = new System.Drawing.Point(32, 34);
            this.listaNotific.MultiSelect = false;
            this.listaNotific.Name = "listaNotific";
            this.listaNotific.ReadOnly = true;
            this.listaNotific.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaNotific.Size = new System.Drawing.Size(689, 396);
            this.listaNotific.TabIndex = 187;
            this.listaNotific.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaNotific_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // NomeAnimal
            // 
            this.NomeAnimal.DataPropertyName = "NomeAnimal";
            this.NomeAnimal.HeaderText = "Animal";
            this.NomeAnimal.Name = "NomeAnimal";
            this.NomeAnimal.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tratamentoDataGridViewTextBoxColumn
            // 
            this.tratamentoDataGridViewTextBoxColumn.DataPropertyName = "Tratamento";
            this.tratamentoDataGridViewTextBoxColumn.HeaderText = "Tratamento";
            this.tratamentoDataGridViewTextBoxColumn.Name = "tratamentoDataGridViewTextBoxColumn";
            this.tratamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tratamentoDataGridViewTextBoxColumn.Width = 130;
            // 
            // medicoSelecionadoDataGridViewTextBoxColumn
            // 
            this.medicoSelecionadoDataGridViewTextBoxColumn.DataPropertyName = "MedicoSelecionado";
            this.medicoSelecionadoDataGridViewTextBoxColumn.HeaderText = "Medico";
            this.medicoSelecionadoDataGridViewTextBoxColumn.Name = "medicoSelecionadoDataGridViewTextBoxColumn";
            this.medicoSelecionadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaConsultaDataGridViewTextBoxColumn
            // 
            this.diaConsultaDataGridViewTextBoxColumn.DataPropertyName = "DiaConsulta";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.diaConsultaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.diaConsultaDataGridViewTextBoxColumn.HeaderText = "Dia";
            this.diaConsultaDataGridViewTextBoxColumn.Name = "diaConsultaDataGridViewTextBoxColumn";
            this.diaConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaConsultaDataGridViewTextBoxColumn.Width = 75;
            // 
            // horaConsultaDataGridViewTextBoxColumn
            // 
            this.horaConsultaDataGridViewTextBoxColumn.DataPropertyName = "HoraConsulta";
            dataGridViewCellStyle2.NullValue = null;
            this.horaConsultaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.horaConsultaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaConsultaDataGridViewTextBoxColumn.Name = "horaConsultaDataGridViewTextBoxColumn";
            this.horaConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaConsultaDataGridViewTextBoxColumn.Width = 130;
            // 
            // obsConsultasDataGridViewTextBoxColumn
            // 
            this.obsConsultasDataGridViewTextBoxColumn.DataPropertyName = "ObsConsultas";
            this.obsConsultasDataGridViewTextBoxColumn.HeaderText = "Observações da Consulta";
            this.obsConsultasDataGridViewTextBoxColumn.Name = "obsConsultasDataGridViewTextBoxColumn";
            this.obsConsultasDataGridViewTextBoxColumn.ReadOnly = true;
            this.obsConsultasDataGridViewTextBoxColumn.Width = 150;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataSource = typeof(Clinica_Vet_Joana.Consulta);
            // 
            // pbLixo
            // 
            this.pbLixo.Image = global::Estrutura_Clinica.Properties.Resources.lixo;
            this.pbLixo.Location = new System.Drawing.Point(32, 436);
            this.pbLixo.Name = "pbLixo";
            this.pbLixo.Size = new System.Drawing.Size(75, 59);
            this.pbLixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLixo.TabIndex = 195;
            this.pbLixo.TabStop = false;
            this.pbLixo.Click += new System.EventHandler(this.PbLixo_Click);
            // 
            // Notificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1092, 501);
            this.Controls.Add(this.pbLixo);
            this.Controls.Add(this.tabEditarClt);
            this.Controls.Add(this.listaNotific);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notificacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamentos + Notificações";
            this.Load += new System.EventHandler(this.Notificacoes_Load);
            this.tabEditarClt.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelaEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGuardaEdit)).EndInit();
            this.noti1cliente.ResumeLayout(false);
            this.noti1cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnviar)).EndInit();
            this.notificarTodosClientes.ResumeLayout(false);
            this.notificarTodosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnviarTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNotific)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEditarClt;
        private System.Windows.Forms.TabPage noti1cliente;
        private System.Windows.Forms.PictureBox pbEnviar;
        private System.Windows.Forms.ComboBox cbPara;
        private System.Windows.Forms.TextBox tbDe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEscolherSms;
        private System.Windows.Forms.TabPage notificarTodosClientes;
        private System.Windows.Forms.PictureBox pbEnviarTodos;
        private System.Windows.Forms.TextBox tbDemimPTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMsgTodos;
        private System.Windows.Forms.DataGridView listaNotific;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbHorasEdit;
        private System.Windows.Forms.TextBox tbIdEdit;
        private System.Windows.Forms.ComboBox cbMedicoEdit;
        private System.Windows.Forms.TextBox tbOutraConsultaEdit;
        private System.Windows.Forms.ComboBox cbConsultaEdit;
        private System.Windows.Forms.DateTimePicker dtConsultasEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbOnsEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pbCancelaEdit;
        private System.Windows.Forms.PictureBox pgGuardaEdit;
        private System.Windows.Forms.PictureBox pbLixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoSelecionadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsConsultasDataGridViewTextBoxColumn;
    }
}