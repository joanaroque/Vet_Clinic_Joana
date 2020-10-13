namespace Estrutura_Clinica
{
    partial class GerirMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirMedicos));
            this.tabAdMed = new System.Windows.Forms.TabControl();
            this.tabAdicionar = new System.Windows.Forms.TabPage();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.tbTelemovel = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.textBox1Nome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.tabEditar = new System.Windows.Forms.TabPage();
            this.cbEspecialiEdit = new System.Windows.Forms.ComboBox();
            this.tbIdEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSOEdit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHorarioEdit = new System.Windows.Forms.ComboBox();
            this.tbEmailEdit = new System.Windows.Forms.TextBox();
            this.tbNifEdit = new System.Windows.Forms.TextBox();
            this.tbTelemovelEdit = new System.Windows.Forms.TextBox();
            this.tbCedulaEdit = new System.Windows.Forms.TextBox();
            this.tbNomeEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pbGuardarEdit = new System.Windows.Forms.PictureBox();
            this.pbCancelEdit = new System.Windows.Forms.PictureBox();
            this.listaMedicos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbLixo = new System.Windows.Forms.PictureBox();
            this.tabAdMed.SuspendLayout();
            this.tabAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdMed
            // 
            this.tabAdMed.Controls.Add(this.tabAdicionar);
            this.tabAdMed.Controls.Add(this.tabEditar);
            this.tabAdMed.Location = new System.Drawing.Point(12, 29);
            this.tabAdMed.Name = "tabAdMed";
            this.tabAdMed.SelectedIndex = 0;
            this.tabAdMed.Size = new System.Drawing.Size(312, 428);
            this.tabAdMed.TabIndex = 148;
            this.tabAdMed.Tag = "";
            this.tabAdMed.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabAdMed_Selected_1);
            // 
            // tabAdicionar
            // 
            this.tabAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabAdicionar.Controls.Add(this.cbEspecialidade);
            this.tabAdicionar.Controls.Add(this.tbId);
            this.tabAdicionar.Controls.Add(this.label6);
            this.tabAdicionar.Controls.Add(this.cbSO);
            this.tabAdicionar.Controls.Add(this.label7);
            this.tabAdicionar.Controls.Add(this.cbHorario);
            this.tabAdicionar.Controls.Add(this.tbEmail);
            this.tabAdicionar.Controls.Add(this.tbNIF);
            this.tabAdicionar.Controls.Add(this.tbTelemovel);
            this.tabAdicionar.Controls.Add(this.tbCedula);
            this.tabAdicionar.Controls.Add(this.textBox1Nome);
            this.tabAdicionar.Controls.Add(this.label10);
            this.tabAdicionar.Controls.Add(this.label8);
            this.tabAdicionar.Controls.Add(this.label9);
            this.tabAdicionar.Controls.Add(this.label12);
            this.tabAdicionar.Controls.Add(this.label13);
            this.tabAdicionar.Controls.Add(this.label14);
            this.tabAdicionar.Controls.Add(this.label15);
            this.tabAdicionar.Controls.Add(this.pbGuardar);
            this.tabAdicionar.Controls.Add(this.pbCancel);
            this.tabAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdicionar.Location = new System.Drawing.Point(4, 22);
            this.tabAdicionar.Name = "tabAdicionar";
            this.tabAdicionar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdicionar.Size = new System.Drawing.Size(304, 402);
            this.tabAdicionar.TabIndex = 0;
            this.tabAdicionar.Text = "Adicionar Médico";
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.BackColor = System.Drawing.Color.Bisque;
            this.cbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(116, 94);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(179, 23);
            this.cbEspecialidade.TabIndex = 179;
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.Snow;
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(116, 18);
            this.tbId.MaxLength = 20;
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(176, 21);
            this.tbId.TabIndex = 163;
            this.tbId.Tag = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 162;
            this.label6.Text = "Id:";
            // 
            // cbSO
            // 
            this.cbSO.BackColor = System.Drawing.Color.Bisque;
            this.cbSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSO.FormattingEnabled = true;
            this.cbSO.Location = new System.Drawing.Point(114, 290);
            this.cbSO.Name = "cbSO";
            this.cbSO.Size = new System.Drawing.Size(179, 23);
            this.cbSO.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 160;
            this.label7.Text = "S.O.:";
            // 
            // cbHorario
            // 
            this.cbHorario.BackColor = System.Drawing.Color.Bisque;
            this.cbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(113, 260);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(179, 23);
            this.cbHorario.TabIndex = 158;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Snow;
            this.tbEmail.Location = new System.Drawing.Point(114, 226);
            this.tbEmail.MaxLength = 20;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(179, 21);
            this.tbEmail.TabIndex = 157;
            this.tbEmail.Tag = "7";
            // 
            // tbNIF
            // 
            this.tbNIF.BackColor = System.Drawing.Color.Snow;
            this.tbNIF.Location = new System.Drawing.Point(114, 163);
            this.tbNIF.MaxLength = 9;
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(179, 21);
            this.tbNIF.TabIndex = 156;
            this.tbNIF.Tag = "5";
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.BackColor = System.Drawing.Color.Snow;
            this.tbTelemovel.Location = new System.Drawing.Point(114, 195);
            this.tbTelemovel.MaxLength = 9;
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(179, 21);
            this.tbTelemovel.TabIndex = 155;
            this.tbTelemovel.Tag = "6";
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.Color.Snow;
            this.tbCedula.Location = new System.Drawing.Point(115, 131);
            this.tbCedula.MaxLength = 5;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(179, 21);
            this.tbCedula.TabIndex = 154;
            this.tbCedula.Tag = "4";
            // 
            // textBox1Nome
            // 
            this.textBox1Nome.BackColor = System.Drawing.Color.Snow;
            this.textBox1Nome.Location = new System.Drawing.Point(116, 57);
            this.textBox1Nome.MaxLength = 20;
            this.textBox1Nome.Name = "textBox1Nome";
            this.textBox1Nome.Size = new System.Drawing.Size(178, 21);
            this.textBox1Nome.TabIndex = 153;
            this.textBox1Nome.Tag = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 152;
            this.label10.Text = "Horário:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 151;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 150;
            this.label9.Text = "Telemóvel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 149;
            this.label12.Text = "NIF:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 148;
            this.label13.Text = "Cédula:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 147;
            this.label14.Text = "Especialidade: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 146;
            this.label15.Text = "Nome: ";
            // 
            // pbGuardar
            // 
            this.pbGuardar.Image = global::Estrutura_Clinica.Properties.Resources.save;
            this.pbGuardar.Location = new System.Drawing.Point(134, 334);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(68, 58);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardar.TabIndex = 140;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.PbGuardar_Click);
            // 
            // pbCancel
            // 
            this.pbCancel.Image = global::Estrutura_Clinica.Properties.Resources.canceeel;
            this.pbCancel.Location = new System.Drawing.Point(218, 334);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(74, 58);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCancel.TabIndex = 139;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.PbCancel_Click_1);
            // 
            // tabEditar
            // 
            this.tabEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabEditar.Controls.Add(this.cbEspecialiEdit);
            this.tabEditar.Controls.Add(this.tbIdEdit);
            this.tabEditar.Controls.Add(this.label1);
            this.tabEditar.Controls.Add(this.cbSOEdit);
            this.tabEditar.Controls.Add(this.label2);
            this.tabEditar.Controls.Add(this.cbHorarioEdit);
            this.tabEditar.Controls.Add(this.tbEmailEdit);
            this.tabEditar.Controls.Add(this.tbNifEdit);
            this.tabEditar.Controls.Add(this.tbTelemovelEdit);
            this.tabEditar.Controls.Add(this.tbCedulaEdit);
            this.tabEditar.Controls.Add(this.tbNomeEdit);
            this.tabEditar.Controls.Add(this.label3);
            this.tabEditar.Controls.Add(this.label4);
            this.tabEditar.Controls.Add(this.label5);
            this.tabEditar.Controls.Add(this.label16);
            this.tabEditar.Controls.Add(this.label17);
            this.tabEditar.Controls.Add(this.label18);
            this.tabEditar.Controls.Add(this.label19);
            this.tabEditar.Controls.Add(this.pbGuardarEdit);
            this.tabEditar.Controls.Add(this.pbCancelEdit);
            this.tabEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditar.Location = new System.Drawing.Point(4, 22);
            this.tabEditar.Name = "tabEditar";
            this.tabEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditar.Size = new System.Drawing.Size(304, 402);
            this.tabEditar.TabIndex = 1;
            this.tabEditar.Text = "Editar Médico";
            // 
            // cbEspecialiEdit
            // 
            this.cbEspecialiEdit.BackColor = System.Drawing.Color.Bisque;
            this.cbEspecialiEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialiEdit.FormattingEnabled = true;
            this.cbEspecialiEdit.Location = new System.Drawing.Point(115, 92);
            this.cbEspecialiEdit.Name = "cbEspecialiEdit";
            this.cbEspecialiEdit.Size = new System.Drawing.Size(179, 23);
            this.cbEspecialiEdit.TabIndex = 184;
            // 
            // tbIdEdit
            // 
            this.tbIdEdit.BackColor = System.Drawing.Color.Snow;
            this.tbIdEdit.Enabled = false;
            this.tbIdEdit.Location = new System.Drawing.Point(116, 16);
            this.tbIdEdit.MaxLength = 20;
            this.tbIdEdit.Name = "tbIdEdit";
            this.tbIdEdit.ReadOnly = true;
            this.tbIdEdit.Size = new System.Drawing.Size(176, 21);
            this.tbIdEdit.TabIndex = 183;
            this.tbIdEdit.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 182;
            this.label1.Text = "Id:";
            // 
            // cbSOEdit
            // 
            this.cbSOEdit.BackColor = System.Drawing.Color.Bisque;
            this.cbSOEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSOEdit.FormattingEnabled = true;
            this.cbSOEdit.Location = new System.Drawing.Point(114, 288);
            this.cbSOEdit.Name = "cbSOEdit";
            this.cbSOEdit.Size = new System.Drawing.Size(179, 23);
            this.cbSOEdit.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 180;
            this.label2.Text = "S.O.:";
            // 
            // cbHorarioEdit
            // 
            this.cbHorarioEdit.BackColor = System.Drawing.Color.Bisque;
            this.cbHorarioEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarioEdit.FormattingEnabled = true;
            this.cbHorarioEdit.Location = new System.Drawing.Point(113, 258);
            this.cbHorarioEdit.Name = "cbHorarioEdit";
            this.cbHorarioEdit.Size = new System.Drawing.Size(179, 23);
            this.cbHorarioEdit.TabIndex = 178;
            // 
            // tbEmailEdit
            // 
            this.tbEmailEdit.BackColor = System.Drawing.Color.Snow;
            this.tbEmailEdit.Location = new System.Drawing.Point(114, 224);
            this.tbEmailEdit.MaxLength = 20;
            this.tbEmailEdit.Name = "tbEmailEdit";
            this.tbEmailEdit.Size = new System.Drawing.Size(179, 21);
            this.tbEmailEdit.TabIndex = 177;
            this.tbEmailEdit.Tag = "7";
            // 
            // tbNifEdit
            // 
            this.tbNifEdit.BackColor = System.Drawing.Color.Snow;
            this.tbNifEdit.Enabled = false;
            this.tbNifEdit.Location = new System.Drawing.Point(114, 161);
            this.tbNifEdit.MaxLength = 9;
            this.tbNifEdit.Name = "tbNifEdit";
            this.tbNifEdit.Size = new System.Drawing.Size(179, 21);
            this.tbNifEdit.TabIndex = 176;
            this.tbNifEdit.Tag = "5";
            // 
            // tbTelemovelEdit
            // 
            this.tbTelemovelEdit.BackColor = System.Drawing.Color.Snow;
            this.tbTelemovelEdit.Location = new System.Drawing.Point(114, 193);
            this.tbTelemovelEdit.MaxLength = 9;
            this.tbTelemovelEdit.Name = "tbTelemovelEdit";
            this.tbTelemovelEdit.Size = new System.Drawing.Size(179, 21);
            this.tbTelemovelEdit.TabIndex = 175;
            this.tbTelemovelEdit.Tag = "6";
            // 
            // tbCedulaEdit
            // 
            this.tbCedulaEdit.BackColor = System.Drawing.Color.Snow;
            this.tbCedulaEdit.Enabled = false;
            this.tbCedulaEdit.Location = new System.Drawing.Point(115, 129);
            this.tbCedulaEdit.MaxLength = 10;
            this.tbCedulaEdit.Name = "tbCedulaEdit";
            this.tbCedulaEdit.Size = new System.Drawing.Size(179, 21);
            this.tbCedulaEdit.TabIndex = 174;
            this.tbCedulaEdit.Tag = "4";
            // 
            // tbNomeEdit
            // 
            this.tbNomeEdit.BackColor = System.Drawing.Color.Snow;
            this.tbNomeEdit.Enabled = false;
            this.tbNomeEdit.Location = new System.Drawing.Point(116, 55);
            this.tbNomeEdit.MaxLength = 20;
            this.tbNomeEdit.Name = "tbNomeEdit";
            this.tbNomeEdit.Size = new System.Drawing.Size(178, 21);
            this.tbNomeEdit.TabIndex = 173;
            this.tbNomeEdit.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 172;
            this.label3.Text = "Horário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 171;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 170;
            this.label5.Text = "Telemóvel:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 169;
            this.label16.Text = "NIF:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 15);
            this.label17.TabIndex = 168;
            this.label17.Text = "Cédula:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 15);
            this.label18.TabIndex = 167;
            this.label18.Text = "Especialidade: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 15);
            this.label19.TabIndex = 166;
            this.label19.Text = "Nome: ";
            // 
            // pbGuardarEdit
            // 
            this.pbGuardarEdit.Image = global::Estrutura_Clinica.Properties.Resources.save;
            this.pbGuardarEdit.Location = new System.Drawing.Point(134, 332);
            this.pbGuardarEdit.Name = "pbGuardarEdit";
            this.pbGuardarEdit.Size = new System.Drawing.Size(68, 58);
            this.pbGuardarEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardarEdit.TabIndex = 165;
            this.pbGuardarEdit.TabStop = false;
            this.pbGuardarEdit.Click += new System.EventHandler(this.PbGuardarEdit_Click);
            // 
            // pbCancelEdit
            // 
            this.pbCancelEdit.Image = global::Estrutura_Clinica.Properties.Resources.canceeel;
            this.pbCancelEdit.Location = new System.Drawing.Point(218, 332);
            this.pbCancelEdit.Name = "pbCancelEdit";
            this.pbCancelEdit.Size = new System.Drawing.Size(74, 58);
            this.pbCancelEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCancelEdit.TabIndex = 164;
            this.pbCancelEdit.TabStop = false;
            this.pbCancelEdit.Click += new System.EventHandler(this.PbCancelEdit_Click);
            // 
            // listaMedicos
            // 
            this.listaMedicos.AllowUserToAddRows = false;
            this.listaMedicos.AllowUserToDeleteRows = false;
            this.listaMedicos.AllowUserToResizeColumns = false;
            this.listaMedicos.AllowUserToResizeRows = false;
            this.listaMedicos.AutoGenerateColumns = false;
            this.listaMedicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomeDataGridViewTextBoxColumn,
            this.especialidadeDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.telemovelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.SalaObs});
            this.listaMedicos.DataSource = this.medicoBindingSource;
            this.listaMedicos.Location = new System.Drawing.Point(339, 51);
            this.listaMedicos.MultiSelect = false;
            this.listaMedicos.Name = "listaMedicos";
            this.listaMedicos.ReadOnly = true;
            this.listaMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaMedicos.Size = new System.Drawing.Size(647, 346);
            this.listaMedicos.TabIndex = 146;
            this.listaMedicos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaMedicos_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 85;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especialidadeDataGridViewTextBoxColumn
            // 
            this.especialidadeDataGridViewTextBoxColumn.DataPropertyName = "Especialidade";
            this.especialidadeDataGridViewTextBoxColumn.HeaderText = "Especialidade";
            this.especialidadeDataGridViewTextBoxColumn.Name = "especialidadeDataGridViewTextBoxColumn";
            this.especialidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaDataGridViewTextBoxColumn.Width = 80;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIFDataGridViewTextBoxColumn.Width = 85;
            // 
            // telemovelDataGridViewTextBoxColumn
            // 
            this.telemovelDataGridViewTextBoxColumn.DataPropertyName = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.HeaderText = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.Name = "telemovelDataGridViewTextBoxColumn";
            this.telemovelDataGridViewTextBoxColumn.ReadOnly = true;
            this.telemovelDataGridViewTextBoxColumn.Width = 85;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 120;
            // 
            // SalaObs
            // 
            this.SalaObs.DataPropertyName = "SalaObs";
            this.SalaObs.HeaderText = "Sala de Observação";
            this.SalaObs.Name = "SalaObs";
            this.SalaObs.ReadOnly = true;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataSource = typeof(Clinica_Vet_Joana.Medico);
            // 
            // pbLixo
            // 
            this.pbLixo.Image = global::Estrutura_Clinica.Properties.Resources.lixo;
            this.pbLixo.Location = new System.Drawing.Point(914, 412);
            this.pbLixo.Name = "pbLixo";
            this.pbLixo.Size = new System.Drawing.Size(72, 57);
            this.pbLixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLixo.TabIndex = 147;
            this.pbLixo.TabStop = false;
            this.pbLixo.Click += new System.EventHandler(this.PbLixo_Click);
            // 
            // GerirMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(999, 481);
            this.Controls.Add(this.tabAdMed);
            this.Controls.Add(this.pbLixo);
            this.Controls.Add(this.listaMedicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerir Médicos";
            this.Load += new System.EventHandler(this.GerirMedicos_Load);
            this.tabAdMed.ResumeLayout(false);
            this.tabAdicionar.ResumeLayout(false);
            this.tabAdicionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.tabEditar.ResumeLayout(false);
            this.tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private System.Windows.Forms.TabControl tabAdMed;
        private System.Windows.Forms.TabPage tabAdicionar;
        private System.Windows.Forms.ComboBox cbEspecialidade;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNIF;
        private System.Windows.Forms.TextBox tbTelemovel;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox textBox1Nome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.TabPage tabEditar;
        private System.Windows.Forms.ComboBox cbEspecialiEdit;
        private System.Windows.Forms.TextBox tbIdEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSOEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHorarioEdit;
        private System.Windows.Forms.TextBox tbEmailEdit;
        private System.Windows.Forms.TextBox tbNifEdit;
        private System.Windows.Forms.TextBox tbTelemovelEdit;
        private System.Windows.Forms.TextBox tbCedulaEdit;
        private System.Windows.Forms.TextBox tbNomeEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pbGuardarEdit;
        private System.Windows.Forms.PictureBox pbCancelEdit;
        private System.Windows.Forms.PictureBox pbLixo;
        private System.Windows.Forms.DataGridView listaMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaObs;
    }
}