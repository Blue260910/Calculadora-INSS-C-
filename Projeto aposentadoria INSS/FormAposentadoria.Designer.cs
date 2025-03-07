namespace Projeto_aposentadoria_INSS
{
    partial class FormAposentadoria
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
            panel1 = new Panel();
            tempTrab = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            lblResultado = new Label();
            txtIdade = new TextBox();
            cmbSexo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tempTrab);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(lblResultado);
            panel1.Controls.Add(txtIdade);
            panel1.Controls.Add(cmbSexo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(59, 53);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 467);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tempTrab
            // 
            tempTrab.Location = new Point(217, 162);
            tempTrab.Name = "tempTrab";
            tempTrab.Size = new Size(125, 27);
            tempTrab.TabIndex = 11;
            tempTrab.TextChanged += tempTrab_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(14, 162);
            label3.Name = "label3";
            label3.Size = new Size(197, 28);
            label3.TabIndex = 10;
            label3.Text = "Tempo de Trabalho:";
            label3.Click += label3_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalcular.Location = new Point(248, 216);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 37);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResultado.Location = new Point(30, 420);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 28);
            lblResultado.TabIndex = 8;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 12F);
            txtIdade.Location = new Point(100, 95);
            txtIdade.Margin = new Padding(3, 4, 3, 4);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(242, 34);
            txtIdade.TabIndex = 3;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.Font = new Font("Segoe UI", 12F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbSexo.Location = new Point(100, 33);
            cmbSexo.Margin = new Padding(3, 4, 3, 4);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(242, 36);
            cmbSexo.TabIndex = 2;
            cmbSexo.SelectedIndexChanged += cmbSexo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 101);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 1;
            label2.Text = "Idade:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 0;
            label1.Text = "Sexo:";
            // 
            // FormAposentadoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAposentadoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo aposentadoria INSS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtIdade;
        private ComboBox cmbSexo;
        private Button btnCalcular;
        private Label lblResultado;
        private Label label3;
        private TextBox tempTrab;
    }
}