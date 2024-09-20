namespace Hospedagem_em_C_.View.Consulta
{
    partial class ConsultaHospedagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaHospedagem));
            tpHospedagem = new ToolStrip();
            tpbEditar = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            btnFechar = new Button();
            gvHospedagem = new DataGridView();
            btnConsultar = new Button();
            txtConsulta = new MaskedTextBox();
            cbSelecionar = new ComboBox();
            lblSelecionar = new Label();
            lblFiltrar = new Label();
            rdTodos = new RadioButton();
            rdAberto = new RadioButton();
            label1 = new Label();
            tpHospedagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvHospedagem).BeginInit();
            SuspendLayout();
            // 
            // tpHospedagem
            // 
            tpHospedagem.Items.AddRange(new ToolStripItem[] { tpbEditar, toolStripButton1 });
            tpHospedagem.Location = new Point(0, 0);
            tpHospedagem.Name = "tpHospedagem";
            tpHospedagem.Size = new Size(800, 25);
            tpHospedagem.TabIndex = 6;
            tpHospedagem.Text = "tpCliente";
            // 
            // tpbEditar
            // 
            tpbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tpbEditar.Image = (Image)resources.GetObject("tpbEditar.Image");
            tpbEditar.ImageTransparentColor = Color.Magenta;
            tpbEditar.Name = "tpbEditar";
            tpbEditar.Size = new Size(23, 22);
            tpbEditar.Text = "Editar";
            tpbEditar.Click += tpbEditar_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Excluir";
            toolStripButton1.Click += tpExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(713, 381);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 13;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // gvHospedagem
            // 
            gvHospedagem.AllowUserToAddRows = false;
            gvHospedagem.AllowUserToDeleteRows = false;
            gvHospedagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvHospedagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHospedagem.Location = new Point(12, 89);
            gvHospedagem.MultiSelect = false;
            gvHospedagem.Name = "gvHospedagem";
            gvHospedagem.ReadOnly = true;
            gvHospedagem.RowHeadersVisible = false;
            gvHospedagem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHospedagem.Size = new Size(776, 268);
            gvHospedagem.TabIndex = 12;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(713, 46);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(309, 46);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(398, 23);
            txtConsulta.TabIndex = 10;
            txtConsulta.KeyPress += txtConsulta_KeyPress;
            // 
            // cbSelecionar
            // 
            cbSelecionar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelecionar.FormattingEnabled = true;
            cbSelecionar.Items.AddRange(new object[] { "Nome", "Quarto" });
            cbSelecionar.Location = new Point(139, 47);
            cbSelecionar.Name = "cbSelecionar";
            cbSelecionar.Size = new Size(164, 23);
            cbSelecionar.TabIndex = 9;
            // 
            // lblSelecionar
            // 
            lblSelecionar.AutoSize = true;
            lblSelecionar.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelecionar.Location = new Point(12, 46);
            lblSelecionar.Name = "lblSelecionar";
            lblSelecionar.Size = new Size(121, 21);
            lblSelecionar.TabIndex = 8;
            lblSelecionar.Text = "Selecionar por:";
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiltrar.Location = new Point(12, 363);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(89, 21);
            lblFiltrar.TabIndex = 14;
            lblFiltrar.Text = "Filtrar por:";
            // 
            // rdTodos
            // 
            rdTodos.AutoSize = true;
            rdTodos.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdTodos.Location = new Point(107, 365);
            rdTodos.Name = "rdTodos";
            rdTodos.Size = new Size(59, 20);
            rdTodos.TabIndex = 15;
            rdTodos.TabStop = true;
            rdTodos.Text = "Todos";
            rdTodos.UseVisualStyleBackColor = true;
            rdTodos.CheckedChanged += rdTodos_CheckedChanged;
            // 
            // rdAberto
            // 
            rdAberto.AutoSize = true;
            rdAberto.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdAberto.Location = new Point(172, 365);
            rdAberto.Name = "rdAberto";
            rdAberto.Size = new Size(81, 20);
            rdAberto.TabIndex = 16;
            rdAberto.TabStop = true;
            rdAberto.Text = "Em aberto";
            rdAberto.UseVisualStyleBackColor = true;
            rdAberto.CheckedChanged += rdAberto_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 388);
            label1.Name = "label1";
            label1.Size = new Size(161, 13);
            label1.TabIndex = 17;
            label1.Text = "(Desabilitado ao consultar)";
            // 
            // ConsultaHospedagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(label1);
            Controls.Add(rdAberto);
            Controls.Add(rdTodos);
            Controls.Add(lblFiltrar);
            Controls.Add(btnFechar);
            Controls.Add(gvHospedagem);
            Controls.Add(btnConsultar);
            Controls.Add(txtConsulta);
            Controls.Add(cbSelecionar);
            Controls.Add(lblSelecionar);
            Controls.Add(tpHospedagem);
            MaximizeBox = false;
            MaximumSize = new Size(816, 464);
            MinimizeBox = false;
            MinimumSize = new Size(816, 464);
            Name = "ConsultaHospedagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de hospedagem";
            tpHospedagem.ResumeLayout(false);
            tpHospedagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvHospedagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tpHospedagem;
        private ToolStripButton tpbEditar;
        private ToolStripButton toolStripButton1;
        private Button btnFechar;
        private DataGridView gvHospedagem;
        private Button btnConsultar;
        private MaskedTextBox txtConsulta;
        private ComboBox cbSelecionar;
        private Label lblSelecionar;
        private Label lblFiltrar;
        private RadioButton rdTodos;
        private RadioButton rdAberto;
        private Label label1;
    }
}