namespace Hospedagem_em_C_.View.Gerenciar
{
    partial class GerenciarCliente
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            gpDadosPessoais = new GroupBox();
            txtTelefone = new MaskedTextBox();
            label1 = new Label();
            txtPlacaDoCarro = new TextBox();
            label2 = new Label();
            gpCliente = new GroupBox();
            txtCPF = new MaskedTextBox();
            lblCPF = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            gpDadosPessoais.SuspendLayout();
            gpCliente.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(577, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 300);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gpDadosPessoais
            // 
            gpDadosPessoais.Controls.Add(txtTelefone);
            gpDadosPessoais.Controls.Add(label1);
            gpDadosPessoais.Controls.Add(txtPlacaDoCarro);
            gpDadosPessoais.Controls.Add(label2);
            gpDadosPessoais.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpDadosPessoais.Location = new Point(12, 148);
            gpDadosPessoais.Name = "gpDadosPessoais";
            gpDadosPessoais.Size = new Size(640, 108);
            gpDadosPessoais.TabIndex = 8;
            gpDadosPessoais.TabStop = false;
            gpDadosPessoais.Text = "Dados pessoais";
            // 
            // txtTelefone
            // 
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
            gpCliente.TabIndex = 7;
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
            txtNome.KeyPress += txtNome_KeyPress;
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
            // GerenciarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 347);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(gpDadosPessoais);
            Controls.Add(gpCliente);
            MaximizeBox = false;
            MaximumSize = new Size(680, 386);
            MinimizeBox = false;
            MinimumSize = new Size(680, 386);
            Name = "GerenciarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar cliente";
            gpDadosPessoais.ResumeLayout(false);
            gpDadosPessoais.PerformLayout();
            gpCliente.ResumeLayout(false);
            gpCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox gpDadosPessoais;
        private MaskedTextBox txtTelefone;
        private Label label1;
        private TextBox txtPlacaDoCarro;
        private Label label2;
        private GroupBox gpCliente;
        private MaskedTextBox txtCPF;
        private Label lblCPF;
        private TextBox txtNome;
        private Label lblNome;
    }
}