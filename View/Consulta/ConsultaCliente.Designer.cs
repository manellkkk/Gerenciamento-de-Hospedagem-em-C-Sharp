namespace Hospedagem_em_C_.View.Consulta
{
    partial class ConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCliente));
            lblSelecionar = new Label();
            cbSelecionar = new ComboBox();
            txtConsulta = new MaskedTextBox();
            btnConsultar = new Button();
            toolStrip1 = new ToolStrip();
            tpbNovo = new ToolStripButton();
            tpbEditar = new ToolStripButton();
            tpExcluir = new ToolStripButton();
            gvCliente = new DataGridView();
            btnSelecionar = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCliente).BeginInit();
            SuspendLayout();
            // 
            // lblSelecionar
            // 
            lblSelecionar.AutoSize = true;
            lblSelecionar.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelecionar.Location = new Point(12, 42);
            lblSelecionar.Name = "lblSelecionar";
            lblSelecionar.Size = new Size(121, 21);
            lblSelecionar.TabIndex = 1;
            lblSelecionar.Text = "Selecionar por:";
            // 
            // cbSelecionar
            // 
            cbSelecionar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelecionar.FormattingEnabled = true;
            cbSelecionar.Items.AddRange(new object[] { "Nome", "CPF" });
            cbSelecionar.Location = new Point(139, 43);
            cbSelecionar.Name = "cbSelecionar";
            cbSelecionar.Size = new Size(164, 23);
            cbSelecionar.TabIndex = 2;
            cbSelecionar.SelectedIndexChanged += cbSelecionar_SelectedIndexChanged;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(309, 42);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(398, 23);
            txtConsulta.TabIndex = 3;
            txtConsulta.KeyPress += txtConsulta_KeyPress;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(713, 42);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tpbNovo, tpbEditar, tpExcluir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 31);
            toolStrip1.TabIndex = 5;
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
            // gvCliente
            // 
            gvCliente.AllowUserToAddRows = false;
            gvCliente.AllowUserToDeleteRows = false;
            gvCliente.AllowUserToResizeRows = false;
            gvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCliente.Location = new Point(12, 85);
            gvCliente.MultiSelect = false;
            gvCliente.Name = "gvCliente";
            gvCliente.ReadOnly = true;
            gvCliente.RowHeadersVisible = false;
            gvCliente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvCliente.Size = new Size(776, 268);
            gvCliente.TabIndex = 6;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(713, 377);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(75, 23);
            btnSelecionar.TabIndex = 7;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnFechar_Click;
            // 
            // ConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(btnSelecionar);
            Controls.Add(gvCliente);
            Controls.Add(toolStrip1);
            Controls.Add(btnConsultar);
            Controls.Add(txtConsulta);
            Controls.Add(cbSelecionar);
            Controls.Add(lblSelecionar);
            MaximizeBox = false;
            MaximumSize = new Size(816, 464);
            MinimizeBox = false;
            MinimumSize = new Size(816, 464);
            Name = "ConsultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de cliente";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelecionar;
        private ComboBox cbSelecionar;
        private MaskedTextBox txtConsulta;
        private Button btnConsultar;
        private ToolStrip toolStrip1;
        private ToolStripButton tpbNovo;
        private ToolStripButton tpbEditar;
        private ToolStripButton tpExcluir;
        private DataGridView gvCliente;
        private Button btnSelecionar;
    }
}