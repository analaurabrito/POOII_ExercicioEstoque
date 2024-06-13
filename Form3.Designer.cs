namespace AgendaTel003
{
    partial class Form3
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
            btnAdicionar = new Button();
            txbMarca = new TextBox();
            label3 = new Label();
            txbNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txbQuantidade = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(232, 328);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(149, 44);
            btnAdicionar.TabIndex = 15;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txbMarca
            // 
            txbMarca.Location = new Point(172, 183);
            txbMarca.Name = "txbMarca";
            txbMarca.Size = new Size(327, 27);
            txbMarca.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 186);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 12;
            label3.Text = "Marca:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(172, 122);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(327, 27);
            txbNome.TabIndex = 11;
            txbNome.TextChanged += txbNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 125);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 10;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 48);
            label1.Name = "label1";
            label1.Size = new Size(258, 38);
            label1.TabIndex = 9;
            label1.Text = "Adicionar produto";
            // 
            // txbQuantidade
            // 
            txbQuantidade.Location = new Point(172, 250);
            txbQuantidade.Name = "txbQuantidade";
            txbQuantidade.Size = new Size(327, 27);
            txbQuantidade.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 253);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 16;
            label4.Text = "Quantidade:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 437);
            Controls.Add(txbQuantidade);
            Controls.Add(label4);
            Controls.Add(btnAdicionar);
            Controls.Add(txbMarca);
            Controls.Add(label3);
            Controls.Add(txbNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private TextBox txbMarca;
        private Label label3;
        private TextBox txbNome;
        private Label label2;
        private Label label1;
        private TextBox txbQuantidade;
        private Label label4;
    }
}