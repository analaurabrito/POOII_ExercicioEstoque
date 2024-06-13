namespace AgendaTel003
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            txbUsuario = new TextBox();
            txbSenha = new TextBox();
            label3 = new Label();
            cbxCiente = new CheckBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 48);
            label1.Name = "label1";
            label1.Size = new Size(90, 38);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 126);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuário:";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(153, 123);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(300, 27);
            txbUsuario.TabIndex = 4;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(153, 184);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(300, 27);
            txbSenha.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 187);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Senha:";
            // 
            // cbxCiente
            // 
            cbxCiente.AutoSize = true;
            cbxCiente.Location = new Point(162, 256);
            cbxCiente.Name = "cbxCiente";
            cbxCiente.Size = new Size(237, 24);
            cbxCiente.TabIndex = 7;
            cbxCiente.Text = "Estou ciente e desejo continuar";
            cbxCiente.UseVisualStyleBackColor = true;
            cbxCiente.CheckedChanged += cbxCiente_CheckedChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.Enabled = false;
            btnEntrar.Location = new Point(225, 318);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(116, 44);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 428);
            Controls.Add(btnEntrar);
            Controls.Add(cbxCiente);
            Controls.Add(txbSenha);
            Controls.Add(label3);
            Controls.Add(txbUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbUsuario;
        private TextBox txbSenha;
        private Label label3;
        private CheckBox cbxCiente;
        private Button btnEntrar;
    }
}