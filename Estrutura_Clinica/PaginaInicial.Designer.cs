namespace Estrutura_Clinica
{
    partial class PaginaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicial));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbNotificar = new System.Windows.Forms.PictureBox();
            this.pbMedicos = new System.Windows.Forms.PictureBox();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerirClientes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGerirMedicos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInfo.Location = new System.Drawing.Point(13, 20);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(79, 24);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "Horário";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbData.Location = new System.Drawing.Point(734, 9);
            this.lbData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(49, 24);
            this.lbData.TabIndex = 9;
            this.lbData.Text = "data";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVersao.Location = new System.Drawing.Point(815, 322);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(51, 15);
            this.lblVersao.TabIndex = 14;
            this.lblVersao.Text = "Versão";
            // 
            // slidePanel
            // 
            this.slidePanel.Location = new System.Drawing.Point(0, 0);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(200, 100);
            this.slidePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(70, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 202;
            this.label1.Text = "Gerir Médicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(607, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 203;
            this.label2.Text = "Gerir Clientes/Animais";
            // 
            // pbNotificar
            // 
            this.pbNotificar.Image = global::Estrutura_Clinica.Properties.Resources.consulta1;
            this.pbNotificar.Location = new System.Drawing.Point(325, 190);
            this.pbNotificar.Name = "pbNotificar";
            this.pbNotificar.Size = new System.Drawing.Size(203, 132);
            this.pbNotificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNotificar.TabIndex = 197;
            this.pbNotificar.TabStop = false;
            this.pbNotificar.Click += new System.EventHandler(this.PbNotificar_Click);
            // 
            // pbMedicos
            // 
            this.pbMedicos.Image = global::Estrutura_Clinica.Properties.Resources.medicos2;
            this.pbMedicos.Location = new System.Drawing.Point(74, 157);
            this.pbMedicos.Name = "pbMedicos";
            this.pbMedicos.Size = new System.Drawing.Size(155, 156);
            this.pbMedicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMedicos.TabIndex = 25;
            this.pbMedicos.TabStop = false;
            this.pbMedicos.Click += new System.EventHandler(this.PbMedicos_Click);
            // 
            // pbClientes
            // 
            this.pbClientes.Image = global::Estrutura_Clinica.Properties.Resources.clientes;
            this.pbClientes.Location = new System.Drawing.Point(611, 157);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(160, 156);
            this.pbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClientes.TabIndex = 24;
            this.pbClientes.TabStop = false;
            this.pbClientes.Click += new System.EventHandler(this.PbClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estrutura_Clinica.Properties.Resources.iconfinder_key_c_643801;
            this.pictureBox1.Location = new System.Drawing.Point(900, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerirClientes
            // 
            this.btnGerirClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerirClientes.FlatAppearance.BorderSize = 0;
            this.btnGerirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerirClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerirClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerirClientes.Image = global::Estrutura_Clinica.Properties.Resources.clt;
            this.btnGerirClientes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGerirClientes.Location = new System.Drawing.Point(3, 216);
            this.btnGerirClientes.Name = "btnGerirClientes";
            this.btnGerirClientes.Size = new System.Drawing.Size(204, 76);
            this.btnGerirClientes.TabIndex = 26;
            this.btnGerirClientes.Text = "Gerir        Clientes\r\n";
            this.btnGerirClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerirClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerirClientes.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Estrutura_Clinica.Properties.Resources.consulta1;
            this.button2.Location = new System.Drawing.Point(0, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 72);
            this.button2.TabIndex = 25;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGerirMedicos
            // 
            this.btnGerirMedicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerirMedicos.FlatAppearance.BorderSize = 0;
            this.btnGerirMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerirMedicos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerirMedicos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerirMedicos.Image = global::Estrutura_Clinica.Properties.Resources.medico_consultaa;
            this.btnGerirMedicos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGerirMedicos.Location = new System.Drawing.Point(6, 77);
            this.btnGerirMedicos.Name = "btnGerirMedicos";
            this.btnGerirMedicos.Size = new System.Drawing.Size(201, 71);
            this.btnGerirMedicos.TabIndex = 24;
            this.btnGerirMedicos.Text = "Gerir         Médicos";
            this.btnGerirMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerirMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerirMedicos.UseVisualStyleBackColor = true;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1016, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbNotificar);
            this.Controls.Add(this.pbMedicos);
            this.Controls.Add(this.pbClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lbData);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pbNotificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGerirMedicos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGerirClientes;
        private System.Windows.Forms.Panel slidePanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.PictureBox pbMedicos;
        private System.Windows.Forms.PictureBox pbNotificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

