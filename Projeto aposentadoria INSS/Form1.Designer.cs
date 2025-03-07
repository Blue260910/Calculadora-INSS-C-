namespace Projeto_aposentadoria_INSS
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
            label1 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(109, 78);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            label1.Click += label1_Click_2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(109, 110);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 34);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(109, 198);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(323, 34);
            txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(109, 166);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(109, 258);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(323, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSenha);
            panel1.Location = new Point(153, 113);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 333);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(36, 17);
            label3.Name = "label3";
            label3.Size = new Size(485, 35);
            label3.TabIndex = 5;
            label3.Text = "Calculadora de Tempo de aposentadoria";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(983, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label2;
        private Button btnLogin;
        private Panel panel1;
        private Label label3;
    }
}
