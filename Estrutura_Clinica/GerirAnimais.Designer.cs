namespace Estrutura_Clinica
{
    partial class GerirAnimais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirAnimais));
            this.listaAnimais = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esterilizacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbIdEdit = new System.Windows.Forms.TabControl();
            this.tabAdicionar = new System.Windows.Forms.TabPage();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.cbCastracao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerAnimal = new System.Windows.Forms.DateTimePicker();
            this.tbRace = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEspecie = new System.Windows.Forms.TextBox();
            this.tbNomeAnimal = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabEditar = new System.Windows.Forms.TabPage();
            this.pbCancelaEdit = new System.Windows.Forms.PictureBox();
            this.pbGuardaEdit = new System.Windows.Forms.PictureBox();
            this.cbEsterilizaEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesoEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGeneroEdit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtConsultaEdit = new System.Windows.Forms.DateTimePicker();
            this.tbRaceEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEspecieEdit = new System.Windows.Forms.TextBox();
            this.tbNomeEdit = new System.Windows.Forms.TextBox();
            this.tbIdEdita = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbMarcarConsulta = new System.Windows.Forms.PictureBox();
            this.pbLixo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaAnimais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.tbIdEdit.SuspendLayout();
            this.tabAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelaEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardaEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarcarConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixo)).BeginInit();
            this.SuspendLayout();
            // 
            // listaAnimais
            // 
            this.listaAnimais.AllowUserToAddRows = false;
            this.listaAnimais.AllowUserToDeleteRows = false;
            this.listaAnimais.AllowUserToResizeColumns = false;
            this.listaAnimais.AllowUserToResizeRows = false;
            this.listaAnimais.AutoGenerateColumns = false;
            this.listaAnimais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listaAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAnimais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.Especie,
            this.Raca,
            this.Genero,
            this.Peso,
            this.Esterilizacao,
            this.DataNascimento});
            this.listaAnimais.DataSource = this.animalBindingSource;
            this.listaAnimais.GridColor = System.Drawing.Color.Thistle;
            this.listaAnimais.Location = new System.Drawing.Point(324, 35);
            this.listaAnimais.MultiSelect = false;
            this.listaAnimais.Name = "listaAnimais";
            this.listaAnimais.ReadOnly = true;
            this.listaAnimais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaAnimais.Size = new System.Drawing.Size(693, 313);
            this.listaAnimais.TabIndex = 120;
            this.listaAnimais.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAnimais_RowEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.DataPropertyName = "Especie";
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Raca
            // 
            this.Raca.DataPropertyName = "Raca";
            this.Raca.HeaderText = "Raça";
            this.Raca.Name = "Raca";
            this.Raca.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Esterilizacao
            // 
            this.Esterilizacao.DataPropertyName = "Esterilizacao";
            this.Esterilizacao.HeaderText = "Esterilizacao";
            this.Esterilizacao.Name = "Esterilizacao";
            this.Esterilizacao.ReadOnly = true;
            this.Esterilizacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Esterilizacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DataNascimento
            // 
            this.DataNascimento.DataPropertyName = "DataNascimento";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.DataNascimento.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataNascimento.HeaderText = "Data de Nascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Width = 150;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(Clinica_Vet_Joana.Animal);
            // 
            // tbIdEdit
            // 
            this.tbIdEdit.Controls.Add(this.tabAdicionar);
            this.tbIdEdit.Controls.Add(this.tabEditar);
            this.tbIdEdit.Location = new System.Drawing.Point(23, 35);
            this.tbIdEdit.Name = "tbIdEdit";
            this.tbIdEdit.SelectedIndex = 0;
            this.tbIdEdit.Size = new System.Drawing.Size(282, 396);
            this.tbIdEdit.TabIndex = 149;
            this.tbIdEdit.Tag = "";
            this.tbIdEdit.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbIdEdit_Selected);
            // 
            // tabAdicionar
            // 
            this.tabAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabAdicionar.Controls.Add(this.pbCancelar);
            this.tabAdicionar.Controls.Add(this.pbGuardar);
            this.tabAdicionar.Controls.Add(this.cbCastracao);
            this.tabAdicionar.Controls.Add(this.label8);
            this.tabAdicionar.Controls.Add(this.tbPeso);
            this.tabAdicionar.Controls.Add(this.label6);
            this.tabAdicionar.Controls.Add(this.cbGenero);
            this.tabAdicionar.Controls.Add(this.label7);
            this.tabAdicionar.Controls.Add(this.dateTimePickerAnimal);
            this.tabAdicionar.Controls.Add(this.tbRace);
            this.tabAdicionar.Controls.Add(this.label9);
            this.tabAdicionar.Controls.Add(this.tbEspecie);
            this.tabAdicionar.Controls.Add(this.tbNomeAnimal);
            this.tabAdicionar.Controls.Add(this.tbId);
            this.tabAdicionar.Controls.Add(this.label10);
            this.tabAdicionar.Controls.Add(this.label12);
            this.tabAdicionar.Controls.Add(this.label13);
            this.tabAdicionar.Controls.Add(this.label14);
            this.tabAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdicionar.Location = new System.Drawing.Point(4, 22);
            this.tabAdicionar.Name = "tabAdicionar";
            this.tabAdicionar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdicionar.Size = new System.Drawing.Size(274, 370);
            this.tabAdicionar.TabIndex = 0;
            this.tabAdicionar.Text = "Adicionar Animal";
            // 
            // pbCancelar
            // 
            this.pbCancelar.Image = global::Estrutura_Clinica.Properties.Resources.canceeel;
            this.pbCancelar.Location = new System.Drawing.Point(178, 293);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(68, 58);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCancelar.TabIndex = 165;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // pbGuardar
            // 
            this.pbGuardar.Image = global::Estrutura_Clinica.Properties.Resources.save;
            this.pbGuardar.Location = new System.Drawing.Point(105, 293);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(68, 58);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardar.TabIndex = 164;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // cbCastracao
            // 
            this.cbCastracao.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbCastracao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCastracao.FormattingEnabled = true;
            this.cbCastracao.Location = new System.Drawing.Point(125, 232);
            this.cbCastracao.Name = "cbCastracao";
            this.cbCastracao.Size = new System.Drawing.Size(120, 23);
            this.cbCastracao.TabIndex = 163;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 162;
            this.label8.Text = "Esterilizado/a:";
            // 
            // tbPeso
            // 
            this.tbPeso.BackColor = System.Drawing.Color.Snow;
            this.tbPeso.Location = new System.Drawing.Point(104, 206);
            this.tbPeso.MaxLength = 9;
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(142, 21);
            this.tbPeso.TabIndex = 161;
            this.tbPeso.Tag = "6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 160;
            this.label6.Text = "Peso:";
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(103, 174);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(142, 23);
            this.cbGenero.TabIndex = 159;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 158;
            this.label7.Text = "Género:";
            // 
            // dateTimePickerAnimal
            // 
            this.dateTimePickerAnimal.CustomFormat = "";
            this.dateTimePickerAnimal.Location = new System.Drawing.Point(143, 82);
            this.dateTimePickerAnimal.Name = "dateTimePickerAnimal";
            this.dateTimePickerAnimal.Size = new System.Drawing.Size(101, 21);
            this.dateTimePickerAnimal.TabIndex = 157;
            this.dateTimePickerAnimal.Value = new System.DateTime(2020, 2, 24, 0, 0, 0, 0);
            // 
            // tbRace
            // 
            this.tbRace.BackColor = System.Drawing.Color.Snow;
            this.tbRace.Location = new System.Drawing.Point(84, 144);
            this.tbRace.MaxLength = 9;
            this.tbRace.Name = "tbRace";
            this.tbRace.Size = new System.Drawing.Size(161, 21);
            this.tbRace.TabIndex = 156;
            this.tbRace.Tag = "6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 155;
            this.label9.Text = "Raça:";
            // 
            // tbEspecie
            // 
            this.tbEspecie.BackColor = System.Drawing.Color.Snow;
            this.tbEspecie.Location = new System.Drawing.Point(83, 114);
            this.tbEspecie.MaxLength = 9;
            this.tbEspecie.Name = "tbEspecie";
            this.tbEspecie.Size = new System.Drawing.Size(161, 21);
            this.tbEspecie.TabIndex = 154;
            this.tbEspecie.Tag = "6";
            // 
            // tbNomeAnimal
            // 
            this.tbNomeAnimal.BackColor = System.Drawing.Color.Snow;
            this.tbNomeAnimal.Location = new System.Drawing.Point(84, 50);
            this.tbNomeAnimal.MaxLength = 20;
            this.tbNomeAnimal.Name = "tbNomeAnimal";
            this.tbNomeAnimal.Size = new System.Drawing.Size(160, 21);
            this.tbNomeAnimal.TabIndex = 153;
            this.tbNomeAnimal.Tag = "2";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.Snow;
            this.tbId.Location = new System.Drawing.Point(103, 18);
            this.tbId.MaxLength = 10;
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(141, 21);
            this.tbId.TabIndex = 152;
            this.tbId.Tag = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 151;
            this.label10.Text = "Espécie:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 15);
            this.label12.TabIndex = 150;
            this.label12.Text = "Data Nascimento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 15);
            this.label13.TabIndex = 149;
            this.label13.Text = "Id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 15);
            this.label14.TabIndex = 148;
            this.label14.Text = "Nome: ";
            // 
            // tabEditar
            // 
            this.tabEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabEditar.Controls.Add(this.pbCancelaEdit);
            this.tabEditar.Controls.Add(this.pbGuardaEdit);
            this.tabEditar.Controls.Add(this.cbEsterilizaEdit);
            this.tabEditar.Controls.Add(this.label1);
            this.tabEditar.Controls.Add(this.tbPesoEdit);
            this.tabEditar.Controls.Add(this.label5);
            this.tabEditar.Controls.Add(this.cbGeneroEdit);
            this.tabEditar.Controls.Add(this.label4);
            this.tabEditar.Controls.Add(this.dtConsultaEdit);
            this.tabEditar.Controls.Add(this.tbRaceEdit);
            this.tabEditar.Controls.Add(this.label3);
            this.tabEditar.Controls.Add(this.tbEspecieEdit);
            this.tabEditar.Controls.Add(this.tbNomeEdit);
            this.tabEditar.Controls.Add(this.tbIdEdita);
            this.tabEditar.Controls.Add(this.label11);
            this.tabEditar.Controls.Add(this.label15);
            this.tabEditar.Controls.Add(this.label16);
            this.tabEditar.Controls.Add(this.label17);
            this.tabEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditar.Location = new System.Drawing.Point(4, 22);
            this.tabEditar.Name = "tabEditar";
            this.tabEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditar.Size = new System.Drawing.Size(274, 370);
            this.tabEditar.TabIndex = 1;
            this.tabEditar.Text = "Editar Animal";
            // 
            // pbCancelaEdit
            // 
            this.pbCancelaEdit.Image = global::Estrutura_Clinica.Properties.Resources.canceeel;
            this.pbCancelaEdit.Location = new System.Drawing.Point(177, 280);
            this.pbCancelaEdit.Name = "pbCancelaEdit";
            this.pbCancelaEdit.Size = new System.Drawing.Size(68, 58);
            this.pbCancelaEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCancelaEdit.TabIndex = 165;
            this.pbCancelaEdit.TabStop = false;
            this.pbCancelaEdit.Click += new System.EventHandler(this.PbCancelaEdit_Click);
            // 
            // pbGuardaEdit
            // 
            this.pbGuardaEdit.Image = global::Estrutura_Clinica.Properties.Resources.save;
            this.pbGuardaEdit.Location = new System.Drawing.Point(103, 280);
            this.pbGuardaEdit.Name = "pbGuardaEdit";
            this.pbGuardaEdit.Size = new System.Drawing.Size(68, 58);
            this.pbGuardaEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardaEdit.TabIndex = 164;
            this.pbGuardaEdit.TabStop = false;
            this.pbGuardaEdit.Click += new System.EventHandler(this.pbGuardaEdit_Click);
            // 
            // cbEsterilizaEdit
            // 
            this.cbEsterilizaEdit.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbEsterilizaEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsterilizaEdit.FormattingEnabled = true;
            this.cbEsterilizaEdit.Location = new System.Drawing.Point(126, 235);
            this.cbEsterilizaEdit.Name = "cbEsterilizaEdit";
            this.cbEsterilizaEdit.Size = new System.Drawing.Size(120, 23);
            this.cbEsterilizaEdit.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 162;
            this.label1.Text = "Esterilizado/a:";
            // 
            // tbPesoEdit
            // 
            this.tbPesoEdit.BackColor = System.Drawing.Color.Snow;
            this.tbPesoEdit.Location = new System.Drawing.Point(105, 209);
            this.tbPesoEdit.MaxLength = 9;
            this.tbPesoEdit.Name = "tbPesoEdit";
            this.tbPesoEdit.Size = new System.Drawing.Size(142, 21);
            this.tbPesoEdit.TabIndex = 161;
            this.tbPesoEdit.Tag = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 160;
            this.label5.Text = "Peso:";
            // 
            // cbGeneroEdit
            // 
            this.cbGeneroEdit.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbGeneroEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneroEdit.Enabled = false;
            this.cbGeneroEdit.FormattingEnabled = true;
            this.cbGeneroEdit.Location = new System.Drawing.Point(104, 177);
            this.cbGeneroEdit.Name = "cbGeneroEdit";
            this.cbGeneroEdit.Size = new System.Drawing.Size(142, 23);
            this.cbGeneroEdit.TabIndex = 159;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 158;
            this.label4.Text = "Género:";
            // 
            // dtConsultaEdit
            // 
            this.dtConsultaEdit.Enabled = false;
            this.dtConsultaEdit.Location = new System.Drawing.Point(144, 85);
            this.dtConsultaEdit.Name = "dtConsultaEdit";
            this.dtConsultaEdit.Size = new System.Drawing.Size(101, 21);
            this.dtConsultaEdit.TabIndex = 157;
            // 
            // tbRaceEdit
            // 
            this.tbRaceEdit.BackColor = System.Drawing.Color.Snow;
            this.tbRaceEdit.Enabled = false;
            this.tbRaceEdit.Location = new System.Drawing.Point(85, 147);
            this.tbRaceEdit.MaxLength = 9;
            this.tbRaceEdit.Name = "tbRaceEdit";
            this.tbRaceEdit.Size = new System.Drawing.Size(161, 21);
            this.tbRaceEdit.TabIndex = 156;
            this.tbRaceEdit.Tag = "6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 155;
            this.label3.Text = "Raça:";
            // 
            // tbEspecieEdit
            // 
            this.tbEspecieEdit.BackColor = System.Drawing.Color.Snow;
            this.tbEspecieEdit.Enabled = false;
            this.tbEspecieEdit.Location = new System.Drawing.Point(84, 117);
            this.tbEspecieEdit.MaxLength = 9;
            this.tbEspecieEdit.Name = "tbEspecieEdit";
            this.tbEspecieEdit.Size = new System.Drawing.Size(161, 21);
            this.tbEspecieEdit.TabIndex = 154;
            this.tbEspecieEdit.Tag = "6";
            // 
            // tbNomeEdit
            // 
            this.tbNomeEdit.BackColor = System.Drawing.Color.Snow;
            this.tbNomeEdit.Enabled = false;
            this.tbNomeEdit.Location = new System.Drawing.Point(85, 53);
            this.tbNomeEdit.MaxLength = 20;
            this.tbNomeEdit.Name = "tbNomeEdit";
            this.tbNomeEdit.Size = new System.Drawing.Size(160, 21);
            this.tbNomeEdit.TabIndex = 153;
            this.tbNomeEdit.Tag = "2";
            // 
            // tbIdEdita
            // 
            this.tbIdEdita.BackColor = System.Drawing.Color.Snow;
            this.tbIdEdita.Enabled = false;
            this.tbIdEdita.Location = new System.Drawing.Point(104, 21);
            this.tbIdEdita.MaxLength = 10;
            this.tbIdEdita.Name = "tbIdEdita";
            this.tbIdEdita.ReadOnly = true;
            this.tbIdEdita.Size = new System.Drawing.Size(141, 21);
            this.tbIdEdita.TabIndex = 152;
            this.tbIdEdita.Tag = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 151;
            this.label11.Text = "Espécie:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 15);
            this.label15.TabIndex = 150;
            this.label15.Text = "Data Nascimento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 15);
            this.label16.TabIndex = 149;
            this.label16.Text = "Id";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 15);
            this.label17.TabIndex = 148;
            this.label17.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(482, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 204;
            this.label2.Text = "Marcar Consulta";
            // 
            // pbMarcarConsulta
            // 
            this.pbMarcarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbMarcarConsulta.Image = global::Estrutura_Clinica.Properties.Resources.cons;
            this.pbMarcarConsulta.Location = new System.Drawing.Point(487, 361);
            this.pbMarcarConsulta.Name = "pbMarcarConsulta";
            this.pbMarcarConsulta.Size = new System.Drawing.Size(135, 126);
            this.pbMarcarConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMarcarConsulta.TabIndex = 150;
            this.pbMarcarConsulta.TabStop = false;
            this.pbMarcarConsulta.Click += new System.EventHandler(this.PbMarcarConsulta_Click_1);
            // 
            // pbLixo
            // 
            this.pbLixo.Image = global::Estrutura_Clinica.Properties.Resources.lixo;
            this.pbLixo.Location = new System.Drawing.Point(948, 388);
            this.pbLixo.Name = "pbLixo";
            this.pbLixo.Size = new System.Drawing.Size(69, 63);
            this.pbLixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLixo.TabIndex = 138;
            this.pbLixo.TabStop = false;
            this.pbLixo.Click += new System.EventHandler(this.PbLixo_Click);
            // 
            // GerirAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1047, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbMarcarConsulta);
            this.Controls.Add(this.tbIdEdit);
            this.Controls.Add(this.pbLixo);
            this.Controls.Add(this.listaAnimais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerir Animais";
            this.Load += new System.EventHandler(this.GerirAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaAnimais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.tbIdEdit.ResumeLayout(false);
            this.tabAdicionar.ResumeLayout(false);
            this.tabAdicionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.tabEditar.ResumeLayout(false);
            this.tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelaEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardaEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarcarConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listaAnimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.PictureBox pbLixo;
        private System.Windows.Forms.TabControl tbIdEdit;
        private System.Windows.Forms.TabPage tabAdicionar;
        private System.Windows.Forms.TabPage tabEditar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.ComboBox cbCastracao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnimal;
        private System.Windows.Forms.TextBox tbRace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEspecie;
        private System.Windows.Forms.TextBox tbNomeAnimal;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbCancelaEdit;
        private System.Windows.Forms.PictureBox pbGuardaEdit;
        private System.Windows.Forms.ComboBox cbEsterilizaEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesoEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGeneroEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtConsultaEdit;
        private System.Windows.Forms.TextBox tbRaceEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEspecieEdit;
        private System.Windows.Forms.TextBox tbNomeEdit;
        private System.Windows.Forms.TextBox tbIdEdita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pbMarcarConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Esterilizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
    }
}