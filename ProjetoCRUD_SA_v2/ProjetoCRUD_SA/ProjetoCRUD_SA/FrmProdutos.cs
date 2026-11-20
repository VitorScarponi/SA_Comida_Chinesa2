using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoCRUD_SA
{
    public partial class FrmProdutos : Form
    {
        // Instanciar a classe Produto:
        private readonly Produto objProduto = new Produto();
        private readonly AppConfig config = AppConfig.Load();

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            txtPasta.Text = config.PastaSite;
            MostrarDadosProdutos();
            LimparDados();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!DadosValidos()) return;

            try
            {
                //Armazenar nos atributos da classe Produto usando métodos SET:
                LerCamposNoObjeto();
                //Executar o método de INSERIR dados de produtos:
                objProduto.InserirProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dados do prato foram CADASTRADOS com sucesso.");
            MostrarDadosProdutos();
            ExportarJson(true);
            LimparDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0) { Aviso("Clique em um prato da lista para alterar."); return; }
            if (!DadosValidos()) return;

            try
            {
                LerCamposNoObjeto();
                objProduto.SetId(int.Parse(txtID.Text));
                //Executar o método de ALTERAR dados de produtos:
                objProduto.AlterarProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dados do prato foram ALTERADOS com sucesso.");
            MostrarDadosProdutos();
            ExportarJson(true);
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Para excluir basta o valor do id do produto:
            if (txtID.Text.Length == 0) { Aviso("Clique em um prato da lista para excluir."); return; }

            var resp = MessageBox.Show($"Excluir \"{txtNome.Text}\" definitivamente?", "Confirmar exclusão",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            try
            {
                int idProduto = int.Parse(txtID.Text);
                objProduto.SetId(idProduto);
                objProduto.ExcluirProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dados do prato EXCLUÍDOS da base de dados.");
            MostrarDadosProdutos();
            ExportarJson(true);
            LimparDados();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            EscolherPasta();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarJson(false);
        }

        private void txtEmoji_TextChanged(object sender, EventArgs e)
        {
            lblEmojiGrande.Text = txtEmoji.Text;
        }

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow linha = dtgProdutos.Rows[e.RowIndex];

            txtID.Text = linha.Cells["id"].Value.ToString();
            txtNome.Text = linha.Cells["nome"].Value.ToString();
            txtDescricao.Text = linha.Cells["descricao"].Value.ToString();
            numPreco.Value = Math.Min(Convert.ToDecimal(linha.Cells["preco"].Value), numPreco.Maximum);
            txtEmoji.Text = linha.Cells["emoji"].Value.ToString();
            cmbTag.Text = linha.Cells["tag"].Value.ToString();

            string categoria = linha.Cells["categoria"].Value.ToString();
            rdbEntrada.Checked = (categoria == "Entrada");
            rdbPrato.Checked = (categoria == "Prato");
            rdbCombo.Checked = (categoria == "Combo");

            bool ativo = Convert.ToBoolean(linha.Cells["ativo"].Value);
            rdbAtivo.Checked = ativo;
            rdbInativo.Checked = !ativo;
        }

        // ------------------------------------------------------------ métodos
        private void MostrarDadosProdutos()
        {
            try
            {
                dtgProdutos.DataSource = objProduto.ListarTodosProdutos();
                if (dtgProdutos.Columns["preco"] != null)
                    dtgProdutos.Columns["preco"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao ler o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LerCamposNoObjeto()
        {
            objProduto.SetNome(txtNome.Text.Trim());
            objProduto.SetDescricao(txtDescricao.Text.Trim());
            objProduto.SetPreco(numPreco.Value);
            objProduto.SetEmoji(txtEmoji.Text.Trim().Length == 0 ? "🍽️" : txtEmoji.Text.Trim());
            objProduto.SetCategoria(rdbEntrada.Checked ? "Entrada" : rdbCombo.Checked ? "Combo" : "Prato");
            objProduto.SetTag(cmbTag.Text.Trim());
            objProduto.SetAtivo(rdbAtivo.Checked);
        }

        private bool DadosValidos()
        {
            if (txtNome.Text.Trim().Length == 0) { Aviso("Informe o nome do prato."); txtNome.Focus(); return false; }
            if (txtDescricao.Text.Trim().Length == 0) { Aviso("Informe a descrição."); txtDescricao.Focus(); return false; }
            if (numPreco.Value <= 0) { Aviso("O preço precisa ser maior que zero."); numPreco.Focus(); return false; }
            if (!(rdbEntrada.Checked || rdbPrato.Checked || rdbCombo.Checked)) { Aviso("Escolha a categoria."); return false; }
            if (!(rdbAtivo.Checked || rdbInativo.Checked)) { Aviso("Escolha a disponibilidade."); return false; }
            return true;
        }

        private void LimparDados()
        {
            txtID.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            numPreco.Value = 0;
            txtEmoji.Text = "🍽️";
            rdbEntrada.Checked = false;
            rdbPrato.Checked = false;
            rdbCombo.Checked = false;
            rdbAtivo.Checked = true;
            cmbTag.SelectedIndex = -1;
            cmbTag.Text = "";
            dtgProdutos.ClearSelection();
            txtNome.Focus();
        }

        private static void Aviso(string texto)
        {
            MessageBox.Show(texto, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ------------------------------------------------------------ JSON do site
        private bool EscolherPasta()
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Escolha a pasta do site (onde fica o index.html)";
                dlg.UseDescriptionForTitle = true;
                dlg.SelectedPath = config.PastaSite;
                if (dlg.ShowDialog(this) != DialogResult.OK) return false;

                config.PastaSite = dlg.SelectedPath;
                config.Save();
                txtPasta.Text = config.PastaSite;
                return true;
            }
        }

        private void ExportarJson(bool silencioso)
        {
            if (string.IsNullOrWhiteSpace(config.PastaSite) || !System.IO.Directory.Exists(config.PastaSite))
            {
                // Depois de cadastrar/alterar/excluir não incomoda: só exporta se a pasta já foi escolhida.
                if (silencioso) return;
                if (!EscolherPasta()) return;
            }

            try
            {
                string caminho = JsonExporter.Exportar(objProduto.ListarTodosProdutos(), config.PastaSite);
                if (!silencioso)
                    MessageBox.Show("Arquivo gerado:\n" + caminho, "Exportação concluída",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gerar o produtos.json", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
