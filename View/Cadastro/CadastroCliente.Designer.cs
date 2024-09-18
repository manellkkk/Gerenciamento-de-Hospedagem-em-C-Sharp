namespace Hospedagem_em_C_.View.Cadastro
{
    partial class CadastroCliente
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
            lblNome = new Label();
            gpCliente = new GroupBox();
            txtCPF = new MaskedTextBox();
            lblCPF = new Label();
            txtNome = new TextBox();
            gpDadosPessoais = new GroupBox();
            chkPlacaDoCarro = new CheckBox();
            chkTelefone = new CheckBox();
            txtTelefone = new MaskedTextBox();
            label1 = new Label();
            txtPlacaDoCarro = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            btnFechar = new Button();
            gpCliente.SuspendLayout();
            gpDadosPessoais.SuspendLayout();
            SuspendLayout();
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
            // gpCliente
            // 
            gpCliente.Controls.Add(txtCPF);
            gpCliente.Controls.Add(lblCPF);
            gpCliente.Controls.Add(txtNome);
            gpCliente.Controls.Add(lblNome);
            gpCliente.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpCliente.Location = new Point(12, 12);
            gpCliente.Name = "gpCliente";
            gpCliente.Size = new Size(640, 107);
            gpCliente.TabIndex = 1;
            gpCliente.TabStop = false;
            gpCliente.Text = "Informações do cliente";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(357, 49);
            txtCPF.Mask = "000\\.000\\.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(254, 33);
            txtCPF.TabIndex = 3;
            txtCPF.KeyPress += txtCPF_KeyPress;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCPF.Location = new Point(357, 29);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(34, 17);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 33);
            txtNome.TabIndex = 1;
            // 
            // gpDadosPessoais
            // 
            gpDadosPessoais.Controls.Add(chkPlacaDoCarro);
            gpDadosPessoais.Controls.Add(chkTelefone);
            gpDadosPessoais.Controls.Add(txtTelefone);
            gpDadosPessoais.Controls.Add(label1);
            gpDadosPessoais.Controls.Add(txtPlacaDoCarro);
            gpDadosPessoais.Controls.Add(label2);
            gpDadosPessoais.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpDadosPessoais.Location = new Point(12, 148);
            gpDadosPessoais.Name = "gpDadosPessoais";
            gpDadosPessoais.Size = new Size(640, 131);
            gpDadosPessoais.TabIndex = 4;
            gpDadosPessoais.TabStop = false;
            gpDadosPessoais.Text = "Dados pessoais";
            // 
            // chkPlacaDoCarro
            // 
            chkPlacaDoCarro.AutoSize = true;
            chkPlacaDoCarro.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPlacaDoCarro.Location = new Point(357, 88);
            chkPlacaDoCarro.Name = "chkPlacaDoCarro";
            chkPlacaDoCarro.Size = new Size(63, 20);
            chkPlacaDoCarro.TabIndex = 5;
            chkPlacaDoCarro.Text = "Possui";
            chkPlacaDoCarro.UseVisualStyleBackColor = true;
            chkPlacaDoCarro.CheckedChanged += chkPlacaDoCarro_CheckedChanged;
            // 
            // chkTelefone
            // 
            chkTelefone.AutoSize = true;
            chkTelefone.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTelefone.Location = new Point(21, 88);
            chkTelefone.Name = "chkTelefone";
            chkTelefone.Size = new Size(63, 20);
            chkTelefone.TabIndex = 4;
            chkTelefone.Text = "Possui";
            chkTelefone.UseVisualStyleBackColor = true;
            chkTelefone.CheckedChanged += chkTelefone_CheckedChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Enabled = false;
            txtTelefone.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(21, 49);
            txtTelefone.Mask = "(00) 000000000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(254, 28);
            txtTelefone.TabIndex = 3;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 29);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 2;
            label1.Text = "Placa do carro";
            // 
            // txtPlacaDoCarro
            // 
            txtPlacaDoCarro.Enabled = false;
            txtPlacaDoCarro.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlacaDoCarro.Location = new Point(357, 49);
            txtPlacaDoCarro.Name = "txtPlacaDoCarro";
            txtPlacaDoCarro.Size = new Size(254, 28);
            txtPlacaDoCarro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 29);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 0;
            label2.Text = "Telefone";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 300);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(577, 300);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnSelecionar_Click;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 347);
            Controls.Add(btnFechar);
            Controls.Add(btnSalvar);
            Controls.Add(gpDadosPessoais);
            Controls.Add(gpCliente);
            MaximizeBox = false;
            MaximumSize = new Size(680, 386);
            MinimizeBox = false;
            MinimumSize = new Size(680, 386);
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de cliente";
            TopMost = true;
            gpCliente.ResumeLayout(false);
            gpCliente.PerformLayout();
            gpDadosPessoais.ResumeLayout(false);
            gpDadosPessoais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private GroupBox gpCliente;
        private TextBox txtNome;
        private Label lblCPF;
        private MaskedTextBox txtCPF;
        private GroupBox gpDadosPessoais;
        private MaskedTextBox txtTelefone;
        private Label label1;
        private TextBox txtPlacaDoCarro;
        private Label label2;
        private Button btnSalvar;
        private Button btnFechar;
        private CheckBox chkPlacaDoCarro;
        private CheckBox chkTelefone;
    }
}