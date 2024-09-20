namespace Hospedagem_em_C_.View.Gerenciar
{
    partial class GerenciarConsumo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gpCliente = new GroupBox();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            gpProduto = new GroupBox();
            gvProduto = new DataGridView();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            gpCliente.SuspendLayout();
            gpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvProduto).BeginInit();
            SuspendLayout();
            // 
            // gpCliente
            // 
            gpCliente.Controls.Add(txtQuantidade);
            gpCliente.Controls.Add(lblQuantidade);
            gpCliente.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpCliente.Location = new Point(12, 144);
            gpCliente.Name = "gpCliente";
            gpCliente.Size = new Size(640, 107);
            gpCliente.TabIndex = 2;
            gpCliente.TabStop = false;
            gpCliente.Text = "Informações do consumo";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(21, 49);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(254, 33);
            txtQuantidade.TabIndex = 1;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(21, 29);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 17);
            lblQuantidade.TabIndex = 0;
            lblQuantidade.Text = "Quantidade";
            // 
            // gpProduto
            // 
            gpProduto.Controls.Add(gvProduto);
            gpProduto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpProduto.Location = new Point(12, 12);
            gpProduto.Name = "gpProduto";
            gpProduto.Size = new Size(651, 105);
            gpProduto.TabIndex = 10;
            gpProduto.TabStop = false;
            gpProduto.Text = "Informacoes do produto";
            // 
            // gvProduto
            // 
            gvProduto.AllowUserToAddRows = false;
            gvProduto.AllowUserToDeleteRows = false;
            gvProduto.AllowUserToResizeRows = false;
            gvProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvProduto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvProduto.Location = new Point(6, 32);
            gvProduto.MultiSelect = false;
            gvProduto.Name = "gvProduto";
            gvProduto.ReadOnly = true;
            gvProduto.RowHeadersVisible = false;
            gvProduto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvProduto.Size = new Size(639, 48);
            gvProduto.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(18, 303);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(577, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // GerenciarConsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 347);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(gpProduto);
            Controls.Add(gpCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GerenciarConsumo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar consumo";
            gpCliente.ResumeLayout(false);
            gpCliente.PerformLayout();
            gpProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpCliente;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private GroupBox gpProduto;
        private DataGridView gvProduto;
        private Button btnAdicionar;
        private Button btnCancelar;
    }
}