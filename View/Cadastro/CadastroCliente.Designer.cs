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
            groupBox1 = new GroupBox();
            txtCPF = new MaskedTextBox();
            lblCPF = new Label();
            txtNome = new TextBox();
            gpDadosPessoais = new GroupBox();
            txtTelefone = new MaskedTextBox();
            label1 = new Label();
            txtPlacaDoCarro = new TextBox();
            label2 = new Label();
            rdSim = new RadioButton();
            rdNao = new RadioButton();
            btnSalvar = new Button();
            btnSelecionar = new Button();
            gpCliente.SuspendLayout();
            groupBox1.SuspendLayout();
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
            gpCliente.Controls.Add(groupBox1);
            gpCliente.Controls.Add(txtCPF);
            gpCliente.Controls.Add(lblCPF);
            gpCliente.Controls.Add(txtNome);
            gpCliente.Controls.Add(lblNome);
            gpCliente.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpCliente.Location = new Point(12, 12);
            gpCliente.Name = "gpCliente";
            gpCliente.Size = new Size(640, 168);
            gpCliente.TabIndex = 1;
            gpCliente.TabStop = false;
            gpCliente.Text = "Informações do cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdNao);
            groupBox1.Controls.Add(rdSim);
            groupBox1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 50);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deseja compartilhar dados pessoais?";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(357, 49);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(254, 33);
            txtCPF.TabIndex = 3;
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
            gpDadosPessoais.Controls.Add(txtTelefone);
            gpDadosPessoais.Controls.Add(label1);
            gpDadosPessoais.Controls.Add(txtPlacaDoCarro);
            gpDadosPessoais.Controls.Add(label2);
            gpDadosPessoais.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpDadosPessoais.Location = new Point(12, 197);
            gpDadosPessoais.Name = "gpDadosPessoais";
            gpDadosPessoais.Size = new Size(640, 131);
            gpDadosPessoais.TabIndex = 4;
            gpDadosPessoais.TabStop = false;
            gpDadosPessoais.Text = "Dados pessoais";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(21, 49);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(254, 33);
            txtTelefone.TabIndex = 3;
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
            txtPlacaDoCarro.Location = new Point(357, 49);
            txtPlacaDoCarro.Name = "txtPlacaDoCarro";
            txtPlacaDoCarro.Size = new Size(254, 33);
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
            // rdSim
            // 
            rdSim.AutoSize = true;
            rdSim.Font = new Font("Yu Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdSim.Location = new Point(41, 22);
            rdSim.Name = "rdSim";
            rdSim.Size = new Size(44, 18);
            rdSim.TabIndex = 0;
            rdSim.TabStop = true;
            rdSim.Text = "Sim";
            rdSim.UseVisualStyleBackColor = true;
            // 
            // rdNao
            // 
            rdNao.AutoSize = true;
            rdNao.Font = new Font("Yu Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdNao.Location = new Point(130, 22);
            rdNao.Name = "rdNao";
            rdNao.Size = new Size(45, 18);
            rdNao.TabIndex = 1;
            rdNao.TabStop = true;
            rdNao.Text = "Não";
            rdNao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 373);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(577, 373);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(75, 23);
            btnSelecionar.TabIndex = 6;
            btnSelecionar.Text = "Fechar";
            btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 423);
            Controls.Add(btnSelecionar);
            Controls.Add(btnSalvar);
            Controls.Add(gpDadosPessoais);
            Controls.Add(gpCliente);
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de cliente";
            WindowState = FormWindowState.Minimized;
            gpCliente.ResumeLayout(false);
            gpCliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton rdSim;
        private RadioButton rdNao;
        private Button btnSalvar;
        private Button btnSelecionar;
    }
}