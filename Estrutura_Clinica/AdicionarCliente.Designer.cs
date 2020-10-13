namespace Estrutura_Clinica
{
    partial class AdicionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCliente));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.tbTelemovel = new System.Windows.Forms.TextBox();
            this.textBox1Nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.BackgroundImage = global::Estrutura_Clinica.Properties.Resources.no;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(184, 236);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 60);
            this.btnCancelar.TabIndex = 103;
            this.btnCancelar.Tag = "11";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbEmail.Location = new System.Drawing.Point(102, 174);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(149, 21);
            this.tbEmail.TabIndex = 101;
            this.tbEmail.Tag = "7";
            // 
            // tbNIF
            // 
            this.tbNIF.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbNIF.Location = new System.Drawing.Point(102, 102);
            this.tbNIF.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNIF.MaxLength = 9;
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(149, 21);
            this.tbNIF.TabIndex = 100;
            this.tbNIF.Tag = "5";
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbTelemovel.Location = new System.Drawing.Point(102, 140);
            this.tbTelemovel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbTelemovel.MaxLength = 9;
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(149, 21);
            this.tbTelemovel.TabIndex = 99;
            this.tbTelemovel.Tag = "6";
            // 
            // textBox1Nome
            // 
            this.textBox1Nome.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1Nome.Location = new System.Drawing.Point(102, 58);
            this.textBox1Nome.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox1Nome.MaxLength = 20;
            this.textBox1Nome.Name = "textBox1Nome";
            this.textBox1Nome.Size = new System.Drawing.Size(149, 21);
            this.textBox1Nome.TabIndex = 98;
            this.textBox1Nome.Tag = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 97;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 96;
            this.label7.Text = "Telemóvel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 95;
            this.label6.Text = "NIF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nome: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.BackgroundImage = global::Estrutura_Clinica.Properties.Resources.iconfinder_save_floppy_disk_3380379;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Pink;
            this.btnGuardar.Location = new System.Drawing.Point(86, 236);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 60);
            this.btnGuardar.TabIndex = 102;
            this.btnGuardar.Tag = "10";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(102, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(149, 21);
            this.textBox1.TabIndex = 126;
            this.textBox1.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 125;
            this.label1.Text = "Id:";
            // 
            // AdicionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(271, 307);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNIF);
            this.Controls.Add(this.tbTelemovel);
            this.Controls.Add(this.textBox1Nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "AdicionarCliente";
            this.Text = "Adicionar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNIF;
        private System.Windows.Forms.TextBox tbTelemovel;
        private System.Windows.Forms.TextBox textBox1Nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}