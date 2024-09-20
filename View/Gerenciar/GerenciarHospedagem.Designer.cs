namespace Hospedagem_em_C_.View.Gerenciar
{
    partial class GerenciarHospedagem
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gpCliente = new GroupBox();
            gvHospedagem = new DataGridView();
            groupBox1 = new GroupBox();
            gvConsumo = new DataGridView();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnFechar = new Button();
            btnFinalizar = new Button();
            gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvHospedagem).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvConsumo).BeginInit();
            SuspendLayout();
            // 
            // gpCliente
            // 
            gpCliente.Controls.Add(gvHospedagem);
            gpCliente.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpCliente.Location = new Point(12, 12);
            gpCliente.Name = "gpCliente";
            gpCliente.Size = new Size(848, 105);
            gpCliente.TabIndex = 8;
            gpCliente.TabStop = false;
            gpCliente.Text = "Informações da hospedagem";
            // 
            // gvHospedagem
            // 
            gvHospedagem.AllowUserToAddRows = false;
            gvHospedagem.AllowUserToDeleteRows = false;
            gvHospedagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvHospedagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvHospedagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHospedagem.Location = new Point(6, 32);
            gvHospedagem.MultiSelect = false;
            gvHospedagem.Name = "gvHospedagem";
            gvHospedagem.ReadOnly = true;
            gvHospedagem.RowHeadersVisible = false;
            gvHospedagem.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gvHospedagem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHospedagem.Size = new Size(836, 48);
            gvHospedagem.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gvConsumo);
            groupBox1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 198);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consumo";
            // 
            // gvConsumo
            // 
            gvConsumo.AllowUserToAddRows = false;
            gvConsumo.AllowUserToDeleteRows = false;
            gvConsumo.AllowUserToResizeRows = false;
            gvConsumo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gvConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gvConsumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvConsumo.Location = new Point(6, 32);
            gvConsumo.Name = "gvConsumo";
            gvConsumo.RowHeadersVisible = false;
            gvConsumo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gvConsumo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvConsumo.Size = new Size(836, 153);
            gvConsumo.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 349);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(93, 349);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(779, 411);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(12, 411);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 13;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // GerenciarHospedagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 464);
            Controls.Add(btnFinalizar);
            Controls.Add(btnFechar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(groupBox1);
            Controls.Add(gpCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GerenciarHospedagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar hospedagem";
            gpCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvHospedagem).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvConsumo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpCliente;
        private DataGridView gvHospedagem;
        private GroupBox groupBox1;
        private DataGridView gvConsumo;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnFechar;
        private Button btnFinalizar;
    }
}