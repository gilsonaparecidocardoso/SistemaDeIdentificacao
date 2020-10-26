namespace SistemaDeIdentificacao
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pctLogotipo = new System.Windows.Forms.PictureBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.cmbLogradouro = new System.Windows.Forms.ComboBox();
            this.btnNovoLogradouro = new System.Windows.Forms.Button();
            this.btnLogotipo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluirLogradouro = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(180, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(409, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(406, 8);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // pctLogotipo
            // 
            this.pctLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctLogotipo.Location = new System.Drawing.Point(12, 12);
            this.pctLogotipo.Name = "pctLogotipo";
            this.pctLogotipo.Size = new System.Drawing.Size(123, 123);
            this.pctLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogotipo.TabIndex = 4;
            this.pctLogotipo.TabStop = false;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(180, 50);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 5;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // cmbLogradouro
            // 
            this.cmbLogradouro.FormattingEnabled = true;
            this.cmbLogradouro.Items.AddRange(new object[] {
            "Aurora, 56",
            "Gertrudes, 661"});
            this.cmbLogradouro.Location = new System.Drawing.Point(183, 66);
            this.cmbLogradouro.Name = "cmbLogradouro";
            this.cmbLogradouro.Size = new System.Drawing.Size(220, 21);
            this.cmbLogradouro.TabIndex = 6;
            // 
            // btnNovoLogradouro
            // 
            this.btnNovoLogradouro.Location = new System.Drawing.Point(409, 66);
            this.btnNovoLogradouro.Name = "btnNovoLogradouro";
            this.btnNovoLogradouro.Size = new System.Drawing.Size(21, 21);
            this.btnNovoLogradouro.TabIndex = 7;
            this.btnNovoLogradouro.Text = "+";
            this.btnNovoLogradouro.UseVisualStyleBackColor = true;
            this.btnNovoLogradouro.Click += new System.EventHandler(this.btnNovoLogradouro_Click);
            // 
            // btnLogotipo
            // 
            this.btnLogotipo.Location = new System.Drawing.Point(141, 114);
            this.btnLogotipo.Name = "btnLogotipo";
            this.btnLogotipo.Size = new System.Drawing.Size(21, 21);
            this.btnLogotipo.TabIndex = 8;
            this.btnLogotipo.Text = "+";
            this.btnLogotipo.UseVisualStyleBackColor = true;
            this.btnLogotipo.Click += new System.EventHandler(this.btnLogotipo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 236);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(183, 112);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(264, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluirLogradouro
            // 
            this.btnExcluirLogradouro.Location = new System.Drawing.Point(436, 66);
            this.btnExcluirLogradouro.Name = "btnExcluirLogradouro";
            this.btnExcluirLogradouro.Size = new System.Drawing.Size(21, 21);
            this.btnExcluirLogradouro.TabIndex = 12;
            this.btnExcluirLogradouro.Text = "-";
            this.btnExcluirLogradouro.UseVisualStyleBackColor = true;
            this.btnExcluirLogradouro.Click += new System.EventHandler(this.btnExcluirLogradouro_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 406);
            this.Controls.Add(this.btnExcluirLogradouro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogotipo);
            this.Controls.Add(this.btnNovoLogradouro);
            this.Controls.Add(this.cmbLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.pctLogotipo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastro";
            this.Text = "Sistema de Identificação";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pctLogotipo;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.ComboBox cmbLogradouro;
        private System.Windows.Forms.Button btnNovoLogradouro;
        private System.Windows.Forms.Button btnLogotipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluirLogradouro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

