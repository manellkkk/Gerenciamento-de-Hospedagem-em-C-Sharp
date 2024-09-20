namespace Hospedagem_em_C_.View.Consulta
{
    partial class ConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProduto));
            toolStrip1 = new ToolStrip();
            tpbNovo = new ToolStripButton();
            tpbEditar = new ToolStripButton();
            tpExcluir = new ToolStripButton();
            btnFechar = new Button();
            gvProduto = new DataGridView();
            btnConsultar = new Button();
            txtConsulta = new MaskedTextBox();
            cbSelecionar = new ComboBox();
            lblSelecionar = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvProduto).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tpbNovo, tpbEditar, tpExcluir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 31);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "tpCliente";
            // 
            // tpbNovo
            // 
            tpbNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tpbNovo.Image = (Image)resources.GetObject("tpbNovo.Image");
            tpbNovo.ImageScaling = ToolStripItemImageScaling.None;
            tpbNovo.ImageTransparentColor = Color.Magenta;
            tpbNovo.Name = "tpbNovo";
            tpbNovo.Size = new Size(28, 28);
            tpbNovo.Text = "Novo";
            tpbNovo.Click += tpbNovo_Click;
            // 
            // tpbEditar
            // 
            tpbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tpbEditar.Image = (Image)resources.GetObject("tpbEditar.Image");
            tpbEditar.ImageTransparentColor = Color.Magenta;
            tpbEditar.Name = "tpbEditar";
            tpbEditar.Size = new Size(23, 28);
            tpbEditar.Text = "Editar";
            tpbEditar.Click += tpbEditar_Click;
            // 
            // tpExcluir
            // 
            tpExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tpExcluir.Image = (Image)resources.GetObject("tpExcluir.Image");
            tpExcluir.ImageTransparentColor = Color.Magenta;
            tpExcluir.Name = "tpExcluir";
            tpExcluir.Size = new Size(23, 28);
            tpExcluir.Text = "Excluir";
            tpExcluir.Click += tpExcluir_Click;
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
            // gvProduto
            // 
            gvProduto.AllowUserToAddRows = false;
            gvProduto.AllowUserToDeleteRows = false;
            gvProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvProduto.Location = new Point(12, 89);
            gvProduto.MultiSelect = false;
            gvProduto.Name = "gvProduto";
            gvProduto.ReadOnly = true;
            gvProduto.RowHeadersVisible = false;
            gvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvProduto.Size = new Size(776, 268);
            gvProduto.TabIndex = 12;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(713, 46);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
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
            cbSelecionar.Items.AddRange(new object[] { "Nome", "ID" });
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
            // ConsultaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(btnFechar);
            Controls.Add(gvProduto);
            Controls.Add(btnConsultar);
            Controls.Add(txtConsulta);
            Controls.Add(cbSelecionar);
            Controls.Add(lblSelecionar);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 464);
            MinimizeBox = false;
            MinimumSize = new Size(816, 464);
            Name = "ConsultaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de produto";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tpbNovo;
        private ToolStripButton tpbEditar;
        private ToolStripButton tpExcluir;
        private Button btnFechar;
        private DataGridView gvProduto;
        private Button btnConsultar;
        private MaskedTextBox txtConsulta;
        private ComboBox cbSelecionar;
        private Label lblSelecionar;
    }
}