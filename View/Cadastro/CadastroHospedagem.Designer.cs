namespace Hospedagem_em_C_.View.Cadastro
{
    partial class CadastroHospedagem
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
            gpCliente = new GroupBox();
            gvCliente = new DataGridView();
            gpHospedagem = new GroupBox();
            txtValor = new TextBox();
            txtQuarto = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            txtDataEntrada = new MaskedTextBox();
            lblNome = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCliente).BeginInit();
            gpHospedagem.SuspendLayout();
            SuspendLayout();
            // 
            // gpCliente
            // 
            gpCliente.Controls.Add(gvCliente);
            gpCliente.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpCliente.Location = new Point(12, 12);
            gpCliente.Name = "gpCliente";
            gpCliente.Size = new Size(640, 107);
            gpCliente.TabIndex = 9;
            gpCliente.TabStop = false;
            gpCliente.Text = "Informações do cliente";
            // 
            // gvCliente
            // 
            gvCliente.AllowUserToAddRows = false;
            gvCliente.AllowUserToDeleteRows = false;
            gvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCliente.Location = new Point(17, 32);
            gvCliente.MultiSelect = false;
            gvCliente.Name = "gvCliente";
            gvCliente.ReadOnly = true;
            gvCliente.RowHeadersVisible = false;
            gvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvCliente.Size = new Size(593, 56);
            gvCliente.TabIndex = 0;
            // 
            // gpHospedagem
            // 
            gpHospedagem.Controls.Add(txtValor);
            gpHospedagem.Controls.Add(txtQuarto);
            gpHospedagem.Controls.Add(label2);
            gpHospedagem.Controls.Add(label1);
            gpHospedagem.Controls.Add(txtDataEntrada);
            gpHospedagem.Controls.Add(lblNome);
            gpHospedagem.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpHospedagem.Location = new Point(12, 152);
            gpHospedagem.Name = "gpHospedagem";
            gpHospedagem.Size = new Size(640, 200);
            gpHospedagem.TabIndex = 10;
            gpHospedagem.TabStop = false;
            gpHospedagem.Text = "Informações da hospedagem";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(356, 49);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(254, 33);
            txtValor.TabIndex = 9;
            txtValor.KeyPress += txtDataEntrada_KeyPress;
            // 
            // txtQuarto
            // 
            txtQuarto.Location = new Point(17, 125);
            txtQuarto.Name = "txtQuarto";
            txtQuarto.Size = new Size(254, 33);
            txtQuarto.TabIndex = 8;
            txtQuarto.KeyPress += txtQuarto_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 105);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 7;
            label2.Text = "Quarto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 5;
            label1.Text = "Diária";
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.Location = new Point(17, 49);
            txtDataEntrada.Mask = "00/00/0000";
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(254, 33);
            txtDataEntrada.TabIndex = 4;
            txtDataEntrada.KeyPress += txtDataEntrada_KeyPress;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(17, 29);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(88, 17);
            lblNome.TabIndex = 2;
            lblNome.Text = "Data entrada";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 382);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(577, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CadastroHospedagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 427);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(gpHospedagem);
            Controls.Add(gpCliente);
            MaximizeBox = false;
            MaximumSize = new Size(680, 466);
            MinimizeBox = false;
            MinimumSize = new Size(680, 466);
            Name = "CadastroHospedagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de hospedagem";
            gpCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvCliente).EndInit();
            gpHospedagem.ResumeLayout(false);
            gpHospedagem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpCliente;
        private DataGridView gvCliente;
        private GroupBox gpHospedagem;
        private Label lblNome;
        private MaskedTextBox txtDataEntrada;
        private Label label1;
        private MaskedTextBox txtQuarto;
        private Label label2;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtValor;
    }
}