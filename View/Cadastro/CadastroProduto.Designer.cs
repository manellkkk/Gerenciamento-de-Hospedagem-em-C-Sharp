namespace Hospedagem_em_C_.View.Cadastro
{
    partial class CadastroProduto
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
            gpProduto = new GroupBox();
            txtValor = new TextBox();
            lblValor = new Label();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            btnSalvar = new Button();
            btnFechar = new Button();
            gpProduto.SuspendLayout();
            SuspendLayout();
            // 
            // gpProduto
            // 
            gpProduto.Controls.Add(txtValor);
            gpProduto.Controls.Add(lblValor);
            gpProduto.Controls.Add(txtQuantidade);
            gpProduto.Controls.Add(lblQuantidade);
            gpProduto.Controls.Add(txtNome);
            gpProduto.Controls.Add(lblNome);
            gpProduto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpProduto.Location = new Point(12, 12);
            gpProduto.Name = "gpProduto";
            gpProduto.Size = new Size(640, 167);
            gpProduto.TabIndex = 2;
            gpProduto.TabStop = false;
            gpProduto.Text = "Informações do produto";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(21, 116);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(254, 28);
            txtValor.TabIndex = 5;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(21, 96);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(93, 17);
            lblValor.TabIndex = 4;
            lblValor.Text = "Preco unitario";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(357, 49);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(254, 28);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(357, 29);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 17);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(21, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 28);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(21, 29);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 17);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 202);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(577, 202);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 247);
            Controls.Add(btnFechar);
            Controls.Add(btnSalvar);
            Controls.Add(gpProduto);
            MaximizeBox = false;
            MaximumSize = new Size(680, 286);
            MinimizeBox = false;
            MinimumSize = new Size(680, 286);
            Name = "CadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de produto";
            TopMost = true;
            gpProduto.ResumeLayout(false);
            gpProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpProduto;
        private GroupBox gpPergunta;
        private RadioButton rdNao;
        private RadioButton rdSim;
        private Label lblQuantidade;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtQuantidade;
        private Button btnSalvar;
        private Button btnFechar;
        private TextBox txtValor;
        private Label lblValor;
    }
}