namespace WinFormsApp1
{
    partial class senhatexto
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
            button1 = new Button();
            label1 = new Label();
            TextCripto = new TextBox();
            Resposta = new TextBox();
            label3 = new Label();
            label4 = new Label();
            chavedetexto = new TextBox();
            Palavradescripto = new TextBox();
            Palavra = new Label();
            Descripto = new TextBox();
            Chavetextodois = new TextBox();
            Descriptografar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 163, 255);
            button1.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(95, 168);
            button1.Name = "button1";
            button1.Size = new Size(133, 33);
            button1.TabIndex = 0;
            button1.Text = "Criptografar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 41);
            label1.Name = "label1";
            label1.Size = new Size(206, 39);
            label1.TabIndex = 1;
            label1.Text = "gotoDecrypter";
            label1.Click += label1_Click;
            // 
            // TextCripto
            // 
            TextCripto.BackColor = Color.FromArgb(74, 74, 74);
            TextCripto.BorderStyle = BorderStyle.None;
            TextCripto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextCripto.ForeColor = Color.White;
            TextCripto.Location = new Point(12, 130);
            TextCripto.Name = "TextCripto";
            TextCripto.Size = new Size(295, 18);
            TextCripto.TabIndex = 2;
            TextCripto.Text = "Insira o conteúdo que deseja criptografar";
            TextCripto.TextAlign = HorizontalAlignment.Center;
            // 
            // Resposta
            // 
            Resposta.BackColor = Color.FromArgb(74, 74, 74);
            Resposta.BorderStyle = BorderStyle.None;
            Resposta.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Resposta.ForeColor = Color.White;
            Resposta.Location = new Point(12, 313);
            Resposta.Name = "Resposta";
            Resposta.Size = new Size(295, 18);
            Resposta.TabIndex = 3;
            Resposta.TextAlign = HorizontalAlignment.Center;
            Resposta.TextChanged += Resposta_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(109, 290);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 5;
            label3.Text = "Sua senha é:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(109, 352);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 6;
            label4.Text = "Sua chave é:";
            label4.Click += label4_Click;
            // 
            // chavedetexto
            // 
            chavedetexto.BackColor = Color.FromArgb(74, 74, 74);
            chavedetexto.BorderStyle = BorderStyle.None;
            chavedetexto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chavedetexto.ForeColor = Color.White;
            chavedetexto.Location = new Point(12, 375);
            chavedetexto.Name = "chavedetexto";
            chavedetexto.Size = new Size(295, 18);
            chavedetexto.TabIndex = 7;
            chavedetexto.TextAlign = HorizontalAlignment.Center;
            // 
            // Palavradescripto
            // 
            Palavradescripto.BackColor = Color.FromArgb(74, 74, 74);
            Palavradescripto.BorderStyle = BorderStyle.None;
            Palavradescripto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Palavradescripto.ForeColor = Color.White;
            Palavradescripto.Location = new Point(359, 375);
            Palavradescripto.Name = "Palavradescripto";
            Palavradescripto.Size = new Size(295, 18);
            Palavradescripto.TabIndex = 8;
            Palavradescripto.TextAlign = HorizontalAlignment.Center;
            Palavradescripto.TextChanged += textBox1_TextChanged;
            // 
            // Palavra
            // 
            Palavra.AutoSize = true;
            Palavra.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Palavra.ForeColor = Color.White;
            Palavra.Location = new Point(422, 352);
            Palavra.Name = "Palavra";
            Palavra.Size = new Size(168, 20);
            Palavra.TabIndex = 9;
            Palavra.Text = "Conteúdo Criptografado:";
            Palavra.Click += Palavra_Click;
            // 
            // Descripto
            // 
            Descripto.BackColor = Color.FromArgb(74, 74, 74);
            Descripto.BorderStyle = BorderStyle.None;
            Descripto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Descripto.ForeColor = Color.White;
            Descripto.Location = new Point(359, 130);
            Descripto.Name = "Descripto";
            Descripto.Size = new Size(295, 18);
            Descripto.TabIndex = 10;
            Descripto.Text = "Insira a senha";
            Descripto.TextAlign = HorizontalAlignment.Center;
            Descripto.TextChanged += Descripto_TextChanged;
            // 
            // Chavetextodois
            // 
            Chavetextodois.BackColor = Color.FromArgb(74, 74, 74);
            Chavetextodois.BorderStyle = BorderStyle.None;
            Chavetextodois.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Chavetextodois.ForeColor = Color.White;
            Chavetextodois.Location = new Point(359, 183);
            Chavetextodois.Name = "Chavetextodois";
            Chavetextodois.Size = new Size(295, 18);
            Chavetextodois.TabIndex = 11;
            Chavetextodois.Text = "Insira a chave";
            Chavetextodois.TextAlign = HorizontalAlignment.Center;
            Chavetextodois.TextChanged += textBox2_TextChanged;
            // 
            // Descriptografar
            // 
            Descriptografar.BackColor = Color.FromArgb(0, 163, 255);
            Descriptografar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            Descriptografar.FlatStyle = FlatStyle.Flat;
            Descriptografar.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Descriptografar.ForeColor = Color.White;
            Descriptografar.Location = new Point(440, 227);
            Descriptografar.Name = "Descriptografar";
            Descriptografar.Size = new Size(133, 33);
            Descriptografar.TabIndex = 12;
            Descriptografar.Text = "Descriptografar";
            Descriptografar.UseVisualStyleBackColor = false;
            Descriptografar.Click += Descriptografar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(48, 48, 48);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(74, 74, 74);
            textBox1.Location = new Point(12, 447);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 14);
            textBox1.TabIndex = 13;
            textBox1.Text = "*Este programa não suporta letras com acento e aspas";
            // 
            // senhatexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(666, 503);
            Controls.Add(textBox1);
            Controls.Add(Descriptografar);
            Controls.Add(Chavetextodois);
            Controls.Add(Descripto);
            Controls.Add(Palavra);
            Controls.Add(Palavradescripto);
            Controls.Add(chavedetexto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Resposta);
            Controls.Add(TextCripto);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "senhatexto";
            RightToLeftLayout = true;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox TextCripto;
        private TextBox Resposta;
        private Label label3;
        private Label label4;
        private TextBox chavedetexto;
        private TextBox Palavradescripto;
        private Label Palavra;
        private TextBox Descripto;
        private TextBox Chavetextodois;
        private Button Descriptografar;
        private TextBox textBox1;
    }
}