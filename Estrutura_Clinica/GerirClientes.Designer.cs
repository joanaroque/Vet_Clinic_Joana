namespace Estrutura_Clinica
{
    partial class GerirClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirClientes));
            this.tabEditarClt = new System.Windows.Forms.TabControl();
            this.tabAdicionar = new System.Windows.Forms.TabPage();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.tbTelemovel = new System.Windows.Forms.TextBox();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabEditar = new System.Windows.Forms.TabPage();
            this.tbIdEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMailEdit = new System.Windows.Forms.TextBox();
            this.tbNifEdit = new System.Windows.Forms.TextBox();
            this.tbTelemovelEdit = new System.Windows.Forms.TextBox();
            this.tbNomeEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbGuardarEdit = new System.Windows.Forms.PictureBox();
            this.pbCancelEdit = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listaClientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbLixo = new System.Windows.Forms.PictureBox();
            this.pbGerirAnimal = new System.Windows.Forms.PictureBox();
            this.tabEditarClt.SuspendLayout();
            this.tabAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGerirAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEditarClt
            // 
            this.tabEditarClt.Controls.Add(this.tabAdicionar);
            this.tabEditarClt.Controls.Add(this.tabEditar);
            this.tabEditarClt.Location = new System.Drawing.Point(12, 27);
            this.tabEditarClt.Name = "tabEditarClt";
            this.tabEditarClt.SelectedIndex = 0;
            this.tabEditarClt.Size = new System.Drawing.Size(291, 396);
            this.tabEditarClt.TabIndex = 149;
            this.tabEditarClt.Tag = "";
            this.tabEditarClt.SelectedIndexChanged += new System.EventHandler(this.TabEditarClt_SelectedIndexChanged);
            // 
            // tabAdicionar
            // 
            this.tabAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabAdicionar.Controls.Add(this.tbId);
            this.tabAdicionar.Controls.Add(this.label12);
            this.tabAdicionar.Controls.Add(this.pbGuardar);
            this.tabAdicionar.Controls.Add(this.tbMail);
            this.tabAdicionar.Controls.Add(this.tbNif);
            this.tabAdicionar.Controls.Add(this.tbTelemovel);
            this.tabAdicionar.Controls.Add(this.pbCancel);
            this.tabAdicionar.Controls.Add(this.tbNome);
            this.tabAdicionar.Controls.Add(this.label13);
            this.tabAdicionar.Controls.Add(this.label14);
            this.tabAdicionar.Controls.Add(this.label15);
            this.tabAdicionar.Controls.Add(this.label16);
            this.tabAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdicionar.Location = new System.Drawing.Point(4, 22);
            this.tabAdicionar.Name = "tabAdicionar";
            this.tabAdicionar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdicionar.Size = new System.Drawing.Size(283, 370);
            this.tabAdicionar.TabIndex = 0;
            this.tabAdicionar.Text = "Adicionar Cliente";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(101, 38);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(149, 21);
            this.tbId.TabIndex = 150;
            this.tbId.Tag = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 149;
            this.label12.Text = "Id:";
            // 
            // pbGuardar
            // 
            this.pbGuardar.Image = global::Estrutura_Clinica.Properties.Resources.save;
            this.pbGuardar.Location = new System.Drawing.Point(92, 274);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(68, 58);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardar.TabIndex = 140;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.White;
            this.tbMail.Location = new System.Drawing.Point(101, 197);
            this.tbMail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbMail.MaxLength = 50;
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(149, 21);
            this.tbMail.TabIndex = 148;
            this.tbMail.Tag = "7";
            // 
            // tbNif
            // 
            this.tbNif.BackColor = System.Drawing.Color.White;
            this.tbNif.Location = new System.Drawing.Point(101, 125);
            this.tbNif.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNif.MaxLength = 9;
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(149, 21);
            this.tbNif.TabIndex = 147;
            this.tbNif.Tag = "5";
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.BackColor = System.Drawing.Color.White;
            this.tbTelemovel.Location = new System.Drawing.Point(101, 163);
            this.tbTelemovel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbTelemovel.MaxLength = 9;
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(149, 21);
            this.tbTelemovel.TabIndex = 146;
            this.tbTelemovel.Tag = "6";
            // 
            // pbCancel
            // 
            this.pbCancel.Image = global::Estrutura_Clinica.Properties.Resources.canceeel;
            this.pbCancel.Location = new System.Drawing.Point(176, 274);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(74, 58);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCancel.TabIndex = 139;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.PbCancel_Click);
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.White;
            this.tbNome.Location = new System.Drawing.Point(101, 81);
            this.tbNome.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNome.MaxLength = 20;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(149, 21);
            this.tbNome.TabIndex = 145;
            this.tbNome.Tag = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 198);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 144;
            this.label13.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 163);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 143;
            this.label14.Text = "Telemóvel:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 127);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 142;
            this.label15.Text = "NIF:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 83);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 15);
            this.label16.TabIndex = 141;
            this.label16.Text = "Nome: ";
            // 
            // tabEditar
            // 
            this.tabEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabEditar.Controls.Add(this.tbIdEdit);
            this.tabEditar.Controls.Add(this.label1);
            this.tabEditar.Controls.Add(this.tbMailEdit);
            this.tabEditar.Controls.Add(this.tbNifEdit);
            this.tabEditar.Controls.Add(this.tbTelemovelEdit);
            this.tabEditar.Controls.Add(this.tbNomeEdit);
            this.tabEditar.Controls.Add(this.label2);
            this.tabEditar.Controls.Add(this.label3);
            this.tabEditar.Controls.Add(this.label4);
            this.tabEditar.Controls.Add(this.label5);
            this.tabEditar.Controls.Add(this.pbGuardarEdit);
            this.tabEditar.Controls.Add(this.pbCancelEdit);
            this.tabEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditar.Location = new System.Drawing.Point(4, 22);
            this.tabEditar.Name = "tabEditar";
            this.tabEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditar.Size = new System.Drawing.Size(283, 370);
            this.tabEditar.TabIndex = 1;
            this.tabEditar.Text = "Editar Cliente";
            // 
            // tbIdEdit
            // 
            this.tbIdEdit.Enabled = false;
            this.tbIdEdit.Location = new System.Drawing.Point(106, 38);
            this.tbIdEdit.Name = "tbIdEdit";
            this.tbIdEdit.ReadOnly = true;
            this.tbIdEdit.Size = new System.Drawing.Size(149, 21);
            this.tbIdEdit.TabIndex = 162;
            this.tbIdEdit.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 161;
            this.label1.Text = "Id:";
            // 
            // tbMailEdit
            // 
            this.tbMailEdit.BackColor = System.Drawing.Color.White;
            this.tbMailEdit.Location = new System.Drawing.Point(106, 194);
            this.tbMailEdit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbMailEdit.MaxLength = 50;
            this.tbMailEdit.Name = "tbMailEdit";
            this.tbMailEdit.Size = new System.Drawing.Size(149, 21);
            this.tbMailEdit.TabIndex = 160;
            this.tbMailEdit.Tag = "7";
            // 
            // tbNifEdit
            // 
            this.tbNifEdit.BackColor = System.Drawing.Color.White;
            this.tbNifEdit.Enabled = false;
            this.tbNifEdit.Location = new System.Drawing.Point(106, 122);
            this.tbNifEdit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNifEdit.MaxLength = 9;
            this.tbNifEdit.Name = "tbNifEdit";
            this.tbNifEdit.Size = new System.Drawing.Size(149, 21);
            this.tbNifEdit.TabIndex = 159;
            this.tbNifEdit.Tag = "5";
            // 
            // tbTelemovelEdit
            // 
            this.tbTelemovelEdit.BackColor = System.Drawing.Color.White;
            this.tbTelemovelEdit.Location = new System.Drawing.Point(106, 160);
            this.tbTelemovelEdit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbTelemovelEdit.MaxLength = 9;
            this.tbTelemovelEdit.Name = "tbTelemovelEdit";
            this.tbTelemovelEdit.Size = new System.Drawing.Size(149, 21);
            this.tbTelemovelEdit.TabIndex = 158;
            this.tbTelemovelEdit.Tag = "6";
            // 
            // tbNomeEdit
            // 
            this.tbNomeEdit.BackColor = System.Drawing.Color.White;
            this.tbNomeEdit.Enabled = false;
            this.tbNomeEdit.Location = new System.Drawing.Point(106, 78);
            this.tbNomeEdit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNomeEdit.MaxLength = 20;
            this.tbNomeEdit.Name = "tbNomeEdit";
            this.tbNomeEdit.Size = new System.Drawing.Size(149, 21);
            this.tbNomeEdit.TabIndex = 157;
            this.tbNomeEdit.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 156;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 155;
            this.label3.Text = "Telemóvel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 154;
            this.label4.Text = "NIF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 153;
            this.label5.Text = "Nome: ";
            // 
            // pbGuardarEdit
            // 
            this.pbGuardarEdit.Image = global::Estrutura_Clinica.Properties.Resources.save;
            this.pbGuardarEdit.Location = new System.Drawing.Point(97, 274);
            this.pbGuardarEdit.Name = "pbGuardarEdit";
            this.pbGuardarEdit.Size = new System.Drawing.Size(68, 58);
            this.pbGuardarEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardarEdit.TabIndex = 152;
            this.pbGuardarEdit.TabStop = false;
            this.pbGuardarEdit.Click += new System.EventHandler(this.PbGuardarEdit_Click);
            // 
            // pbCancelEdit
            // 
            this.pbCancelEdit.Image = global::Estrutura_Clinica.Properties.Resources.canceeel;
            this.pbCancelEdit.Location = new System.Drawing.Point(181, 274);
            this.pbCancelEdit.Name = "pbCancelEdit";
            this.pbCancelEdit.Size = new System.Drawing.Size(74, 58);
            this.pbCancelEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCancelEdit.TabIndex = 151;
            this.pbCancelEdit.TabStop = false;
            this.pbCancelEdit.Click += new System.EventHandler(this.PbCancelEdit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(447, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 20);
            this.label11.TabIndex = 148;
            this.label11.Text = "Gerir Animal:          ";
            // 
            // listaClientes
            // 
            this.listaClientes.AllowUserToAddRows = false;
            this.listaClientes.AllowUserToDeleteRows = false;
            this.listaClientes.AllowUserToResizeColumns = false;
            this.listaClientes.AllowUserToResizeRows = false;
            this.listaClientes.AutoGenerateColumns = false;
            this.listaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomeDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.telemovelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.listaClientes.DataSource = this.clienteBindingSource;
            this.listaClientes.Location = new System.Drawing.Point(334, 49);
            this.listaClientes.MultiSelect = false;
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaClientes.Size = new System.Drawing.Size(538, 255);
            this.listaClientes.TabIndex = 145;
            this.listaClientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaClientes_RowEnter);
            this.listaClientes.DoubleClick += new System.EventHandler(this.ListaClientes_DoubleClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telemovelDataGridViewTextBoxColumn
            // 
            this.telemovelDataGridViewTextBoxColumn.DataPropertyName = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.HeaderText = "Telemovel";
            this.telemovelDataGridViewTextBoxColumn.Name = "telemovelDataGridViewTextBoxColumn";
            this.telemovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Clinica_Vet_Joana.Cliente);
            // 
            // pbLixo
            // 
            this.pbLixo.Image = global::Estrutura_Clinica.Properties.Resources.lixo;
            this.pbLixo.Location = new System.Drawing.Point(801, 323);
            this.pbLixo.Name = "pbLixo";
            this.pbLixo.Size = new System.Drawing.Size(71, 58);
            this.pbLixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLixo.TabIndex = 146;
            this.pbLixo.TabStop = false;
            this.pbLixo.Click += new System.EventHandler(this.pbLixo_Click_1);
            // 
            // pbGerirAnimal
            // 
            this.pbGerirAnimal.Image = global::Estrutura_Clinica.Properties.Resources.pet;
            this.pbGerirAnimal.Location = new System.Drawing.Point(422, 323);
            this.pbGerirAnimal.Name = "pbGerirAnimal";
            this.pbGerirAnimal.Size = new System.Drawing.Size(188, 135);
            this.pbGerirAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGerirAnimal.TabIndex = 147;
            this.pbGerirAnimal.TabStop = false;
            this.pbGerirAnimal.Click += new System.EventHandler(this.pbGerirAnimal_Click_1);
            // 
            // GerirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(912, 458);
            this.Controls.Add(this.tabEditarClt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pbLixo);
            this.Controls.Add(this.listaClientes);
            this.Controls.Add(this.pbGerirAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerir Clientes";
            this.Load += new System.EventHandler(this.GerirClientes_Load);
            this.tabEditarClt.ResumeLayout(false);
            this.tabAdicionar.ResumeLayout(false);
            this.tabAdicionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.tabEditar.ResumeLayout(false);
            this.tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGerirAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TabControl tabEditarClt;
        private System.Windows.Forms.TabPage tabAdicionar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.TextBox tbTelemovel;
        private System.Windows.Forms.PictureBox pbCancel;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabEditar;
        private System.Windows.Forms.TextBox tbIdEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMailEdit;
        private System.Windows.Forms.TextBox tbNifEdit;
        private System.Windows.Forms.TextBox tbTelemovelEdit;
        private System.Windows.Forms.TextBox tbNomeEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbGuardarEdit;
        private System.Windows.Forms.PictureBox pbCancelEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbGerirAnimal;
        private System.Windows.Forms.PictureBox pbLixo;
        private System.Windows.Forms.DataGridView listaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}