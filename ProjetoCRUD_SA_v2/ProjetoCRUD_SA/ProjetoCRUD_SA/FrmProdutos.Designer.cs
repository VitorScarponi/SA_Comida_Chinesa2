namespace ProjetoCRUD_SA
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            this.pnlDados = new System.Windows.Forms.Panel();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.txtEmoji = new System.Windows.Forms.TextBox();
            this.lblEmoji = new System.Windows.Forms.Label();
            this.lblEmojiGrande = new System.Windows.Forms.Label();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.grpCategoria = new System.Windows.Forms.GroupBox();
            this.rdbCombo = new System.Windows.Forms.RadioButton();
            this.rdbPrato = new System.Windows.Forms.RadioButton();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.grpDisponibilidade = new System.Windows.Forms.GroupBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlID = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblPasta = new System.Windows.Forms.Label();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.btnPasta = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.grpCategoria.SuspendLayout();
            this.grpDisponibilidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            this.pnlID.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDados.Controls.Add(this.dtgProdutos);
            this.pnlDados.Controls.Add(this.txtEmoji);
            this.pnlDados.Controls.Add(this.lblEmoji);
            this.pnlDados.Controls.Add(this.lblEmojiGrande);
            this.pnlDados.Controls.Add(this.cmbTag);
            this.pnlDados.Controls.Add(this.lblTag);
            this.pnlDados.Controls.Add(this.grpCategoria);
            this.pnlDados.Controls.Add(this.grpDisponibilidade);
            this.pnlDados.Controls.Add(this.txtDescricao);
            this.pnlDados.Controls.Add(this.lblDescricao);
            this.pnlDados.Controls.Add(this.numPreco);
            this.pnlDados.Controls.Add(this.lblPreco);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.lblNome);
            this.pnlDados.Controls.Add(this.pnlID);
            this.pnlDados.Location = new System.Drawing.Point(12, 12);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(800, 575);
            this.pnlDados.TabIndex = 0;
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.AllowUserToAddRows = false;
            this.dtgProdutos.AllowUserToDeleteRows = false;
            this.dtgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Location = new System.Drawing.Point(180, 230);
            this.dtgProdutos.MultiSelect = false;
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.ReadOnly = true;
            this.dtgProdutos.RowHeadersWidth = 51;
            this.dtgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdutos.Size = new System.Drawing.Size(595, 325);
            this.dtgProdutos.TabIndex = 14;
            this.dtgProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellClick);
            // 
            // txtEmoji
            // 
            this.txtEmoji.Location = new System.Drawing.Point(12, 322);
            this.txtEmoji.MaxLength = 8;
            this.txtEmoji.Name = "txtEmoji";
            this.txtEmoji.Size = new System.Drawing.Size(150, 32);
            this.txtEmoji.TabIndex = 13;
            this.txtEmoji.TextChanged += new System.EventHandler(this.txtEmoji_TextChanged);
            // 
            // lblEmoji
            // 
            this.lblEmoji.AutoSize = true;
            this.lblEmoji.Location = new System.Drawing.Point(12, 295);
            this.lblEmoji.Name = "lblEmoji";
            this.lblEmoji.Size = new System.Drawing.Size(113, 25);
            this.lblEmoji.TabIndex = 12;
            this.lblEmoji.Text = "Emoji do prato:";
            // 
            // lblEmojiGrande
            // 
            this.lblEmojiGrande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(139)))), ((int)(((byte)(135)))));
            this.lblEmojiGrande.Font = new System.Drawing.Font("Segoe UI Emoji", 54F);
            this.lblEmojiGrande.ForeColor = System.Drawing.Color.White;
            this.lblEmojiGrande.Location = new System.Drawing.Point(12, 135);
            this.lblEmojiGrande.Name = "lblEmojiGrande";
            this.lblEmojiGrande.Size = new System.Drawing.Size(150, 150);
            this.lblEmojiGrande.TabIndex = 11;
            this.lblEmojiGrande.Text = "🍽️";
            this.lblEmojiGrande.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTag
            // 
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Items.AddRange(new object[] {
            "Mais pedido",
            "Favorito",
            "Para compartilhar",
            "Entrada",
            "Clássico",
            "Leve"});
            this.cmbTag.Location = new System.Drawing.Point(665, 186);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(110, 33);
            this.cmbTag.TabIndex = 10;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(665, 160);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(38, 25);
            this.lblTag.TabIndex = 9;
            this.lblTag.Text = "Tag:";
            // 
            // grpCategoria
            // 
            this.grpCategoria.Controls.Add(this.rdbCombo);
            this.grpCategoria.Controls.Add(this.rdbPrato);
            this.grpCategoria.Controls.Add(this.rdbEntrada);
            this.grpCategoria.Location = new System.Drawing.Point(390, 155);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Size = new System.Drawing.Size(260, 62);
            this.grpCategoria.TabIndex = 8;
            this.grpCategoria.TabStop = false;
            this.grpCategoria.Text = "Categoria";
            // 
            // rdbCombo
            // 
            this.rdbCombo.AutoSize = true;
            this.rdbCombo.Location = new System.Drawing.Point(175, 26);
            this.rdbCombo.Name = "rdbCombo";
            this.rdbCombo.Size = new System.Drawing.Size(77, 29);
            this.rdbCombo.TabIndex = 2;
            this.rdbCombo.Text = "Combo";
            this.rdbCombo.UseVisualStyleBackColor = true;
            // 
            // rdbPrato
            // 
            this.rdbPrato.AutoSize = true;
            this.rdbPrato.Location = new System.Drawing.Point(100, 26);
            this.rdbPrato.Name = "rdbPrato";
            this.rdbPrato.Size = new System.Drawing.Size(69, 29);
            this.rdbPrato.TabIndex = 1;
            this.rdbPrato.Text = "Prato";
            this.rdbPrato.UseVisualStyleBackColor = true;
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Location = new System.Drawing.Point(10, 26);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(84, 29);
            this.rdbEntrada.TabIndex = 0;
            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            // 
            // grpDisponibilidade
            // 
            this.grpDisponibilidade.Controls.Add(this.rdbInativo);
            this.grpDisponibilidade.Controls.Add(this.rdbAtivo);
            this.grpDisponibilidade.Location = new System.Drawing.Point(180, 155);
            this.grpDisponibilidade.Name = "grpDisponibilidade";
            this.grpDisponibilidade.Size = new System.Drawing.Size(195, 62);
            this.grpDisponibilidade.TabIndex = 7;
            this.grpDisponibilidade.TabStop = false;
            this.grpDisponibilidade.Text = "Disponibilidade";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(95, 26);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(80, 29);
            this.rdbInativo.TabIndex = 1;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Location = new System.Drawing.Point(10, 26);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(66, 29);
            this.rdbAtivo.TabIndex = 0;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(180, 92);
            this.txtDescricao.MaxLength = 255;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(595, 52);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(180, 66);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 25);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // numPreco
            // 
            this.numPreco.DecimalPlaces = 2;
            this.numPreco.Location = new System.Drawing.Point(625, 36);
            this.numPreco.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(150, 32);
            this.numPreco.TabIndex = 4;
            this.numPreco.ThousandsSeparator = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(625, 10);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(86, 25);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço (R$):";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(180, 36);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(420, 32);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(180, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 25);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do prato:";
            // 
            // pnlID
            // 
            this.pnlID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlID.Controls.Add(this.txtID);
            this.pnlID.Controls.Add(this.lblID);
            this.pnlID.Location = new System.Drawing.Point(12, 12);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(150, 110);
            this.pnlID.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(10, 62);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(128, 32);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(8, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Location = new System.Drawing.Point(825, 12);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(205, 575);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(139)))), ((int)(((byte)(135)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 18F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(10, 436);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(185, 58);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(139)))), ((int)(((byte)(135)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 18F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(10, 330);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(185, 58);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(139)))), ((int)(((byte)(135)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 18F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(10, 224);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(185, 58);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(139)))), ((int)(((byte)(135)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 18F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(10, 118);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(185, 58);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(139)))), ((int)(((byte)(135)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 18F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(10, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 58);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblPasta
            // 
            this.lblPasta.AutoSize = true;
            this.lblPasta.Location = new System.Drawing.Point(12, 603);
            this.lblPasta.Name = "lblPasta";
            this.lblPasta.Size = new System.Drawing.Size(105, 25);
            this.lblPasta.TabIndex = 2;
            this.lblPasta.Text = "Pasta do site:";
            // 
            // txtPasta
            // 
            this.txtPasta.Location = new System.Drawing.Point(135, 600);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.ReadOnly = true;
            this.txtPasta.Size = new System.Drawing.Size(560, 32);
            this.txtPasta.TabIndex = 3;
            // 
            // btnPasta
            // 
            this.btnPasta.Location = new System.Drawing.Point(705, 597);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(110, 32);
            this.btnPasta.TabIndex = 4;
            this.btnPasta.Text = "Procurar...";
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(825, 597);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(205, 32);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar JSON";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 655);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.lblPasta);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProdutos - SA COMIDA CHINESA";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            this.grpDisponibilidade.ResumeLayout(false);
            this.grpDisponibilidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblEmoji;
        private System.Windows.Forms.Label lblEmojiGrande;
        private System.Windows.Forms.Label lblPasta;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtEmoji;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.GroupBox grpDisponibilidade;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.RadioButton rdbPrato;
        private System.Windows.Forms.RadioButton rdbCombo;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.Button btnExportar;
    }
}
