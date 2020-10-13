namespace Estrutura_Clinica
{
    partial class MarcarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcarConsulta));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.tbOBS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMedicDisponivel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutraConsulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConsultas = new System.Windows.Forms.ComboBox();
            this.dTimePConsultas = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(297, 401);
            this.tabControl1.TabIndex = 195;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.cbHoras);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.pbCancelar);
            this.tabPage1.Controls.Add(this.pbGuardar);
            this.tabPage1.Controls.Add(this.tbOBS);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbID);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbMedicDisponivel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbOutraConsulta);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbConsultas);
            this.tabPage1.Controls.Add(this.dTimePConsultas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(289, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marcar Consulta";
            // 
            // cbHoras
            // 
            this.cbHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Location = new System.Drawing.Point(115, 61);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(159, 21);
            this.cbHoras.TabIndex = 206;
            this.cbHoras.SelectedIndexChanged += new System.EventHandler(this.CbHoras_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(6, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 205;
            this.label11.Text = "Horas:";
            // 
            // pbCancelar
            // 
            this.pbCancelar.Image = global::Estrutura_Clinica.Properties.Resources.canceeel;
            this.pbCancelar.Location = new System.Drawing.Point(206, 308);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(68, 58);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCancelar.TabIndex = 204;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.PbCancelar_Click_1);
            // 
            // pbGuardar
            // 
            this.pbGuardar.Image = global::Estrutura_Clinica.Properties.Resources.save;
            this.pbGuardar.Location = new System.Drawing.Point(125, 308);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(68, 58);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGuardar.TabIndex = 203;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click_1);
            // 
            // tbOBS
            // 
            this.tbOBS.Location = new System.Drawing.Point(6, 200);
            this.tbOBS.MaxLength = 200;
            this.tbOBS.Multiline = true;
            this.tbOBS.Name = "tbOBS";
            this.tbOBS.Size = new System.Drawing.Size(268, 91);
            this.tbOBS.TabIndex = 202;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(6, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 201;
            this.label7.Text = "Observações:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(115, 7);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(159, 20);
            this.tbID.TabIndex = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 199;
            this.label6.Text = "Id";
            // 
            // cbMedicDisponivel
            // 
            this.cbMedicDisponivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicDisponivel.FormattingEnabled = true;
            this.cbMedicDisponivel.Location = new System.Drawing.Point(114, 92);
            this.cbMedicDisponivel.Name = "cbMedicDisponivel";
            this.cbMedicDisponivel.Size = new System.Drawing.Size(160, 21);
            this.cbMedicDisponivel.TabIndex = 198;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 197;
            this.label4.Text = "Médico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 196;
            this.label3.Text = "Dia:";
            // 
            // tbOutraConsulta
            // 
            this.tbOutraConsulta.Location = new System.Drawing.Point(115, 153);
            this.tbOutraConsulta.Name = "tbOutraConsulta";
            this.tbOutraConsulta.Size = new System.Drawing.Size(159, 20);
            this.tbOutraConsulta.TabIndex = 195;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(3, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 194;
            this.label2.Text = "Outra Consulta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(3, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 193;
            this.label1.Text = "Consulta:";
            // 
            // cbConsultas
            // 
            this.cbConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultas.FormattingEnabled = true;
            this.cbConsultas.Location = new System.Drawing.Point(114, 122);
            this.cbConsultas.Name = "cbConsultas";
            this.cbConsultas.Size = new System.Drawing.Size(160, 21);
            this.cbConsultas.TabIndex = 192;
            // 
            // dTimePConsultas
            // 
            this.dTimePConsultas.CalendarMonthBackground = System.Drawing.Color.Coral;
            this.dTimePConsultas.CalendarTitleBackColor = System.Drawing.Color.DarkOliveGreen;
            this.dTimePConsultas.CustomFormat = "";
            this.dTimePConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTimePConsultas.Location = new System.Drawing.Point(114, 33);
            this.dTimePConsultas.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dTimePConsultas.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dTimePConsultas.Name = "dTimePConsultas";
            this.dTimePConsultas.Size = new System.Drawing.Size(160, 20);
            this.dTimePConsultas.TabIndex = 191;
            this.dTimePConsultas.Value = new System.DateTime(2020, 2, 21, 0, 0, 0, 0);
            // 
            // MarcarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(336, 444);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarcarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcar Consultas";
            this.Load += new System.EventHandler(this.MarcarConsulta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoSelecionadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsConsultasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.TextBox tbOBS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMedicDisponivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOutraConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConsultas;
        private System.Windows.Forms.DateTimePicker dTimePConsultas;
    }
}