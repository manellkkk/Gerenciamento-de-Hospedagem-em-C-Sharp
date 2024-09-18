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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            txtCPF = new MaskedTextBox();
            lblNome = new Label();
            button1 = new Button();
            btnCancelar = new Button();
            gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gpCliente
            // 
            gpCliente.Controls.Add(dataGridView1);
            gpCliente.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpCliente.Location = new Point(12, 12);
            gpCliente.Name = "gpCliente";
            gpCliente.Size = new Size(640, 107);
            gpCliente.TabIndex = 9;
            gpCliente.TabStop = false;
            gpCliente.Text = "Informações do cliente";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(628, 53);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 200);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações da hospedagem";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(17, 125);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(254, 33);
            maskedTextBox2.TabIndex = 8;
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(356, 49);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(254, 33);
            maskedTextBox1.TabIndex = 6;
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
            // txtCPF
            // 
            txtCPF.Location = new Point(17, 49);
            txtCPF.Mask = "00/00/0000";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(254, 33);
            txtCPF.TabIndex = 4;
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
            // button1
            // 
            button1.Location = new Point(12, 382);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
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
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(gpCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroHospedagem";
            Text = "Cadastro de hospedagem";
            gpCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpCliente;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label lblNome;
        private MaskedTextBox txtCPF;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private Label label2;
        private Button button1;
        private Button btnCancelar;
    }
}