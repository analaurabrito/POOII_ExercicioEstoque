namespace AgendaTel003
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProdutos = new DataGridView();
            label1 = new Label();
            btnLogin = new Button();
            btnAdicionar = new Button();
            btnRemover = new Button();
            labelADM = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(144, 168);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(801, 330);
            dgvProdutos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 105);
            label1.Name = "label1";
            label1.Size = new Size(288, 38);
            label1.TabIndex = 1;
            label1.Text = "Estoque de Produtos";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(829, 38);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Enabled = false;
            btnAdicionar.Location = new Point(144, 520);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(116, 44);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Enabled = false;
            btnRemover.Location = new Point(282, 520);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(116, 44);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // labelADM
            // 
            labelADM.AutoSize = true;
            labelADM.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelADM.Location = new Point(144, 43);
            labelADM.Name = "labelADM";
            labelADM.Size = new Size(370, 28);
            labelADM.TabIndex = 5;
            labelADM.Text = "Entre no sistema para realizar ações...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 641);
            Controls.Add(labelADM);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(dgvProdutos);
            Name = "Form1";
            Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvProdutos;
        private Label label1;
        private Button btnLogin;
        public Button btnAdicionar;
        public Button btnRemover;
        public Label labelADM;
    }
}
