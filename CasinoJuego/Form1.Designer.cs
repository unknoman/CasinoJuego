namespace CasinoJuego
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saldoj = new System.Windows.Forms.Label();
            this.saldoC = new System.Windows.Forms.Label();
            this.apostarBtn = new System.Windows.Forms.Button();
            this.valorApuesta = new System.Windows.Forms.TextBox();
            this.multiplicadorX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Apostado = new System.Windows.Forms.Label();
            this.multiplicadorAnterior = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo casino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo ";
            // 
            // saldoj
            // 
            this.saldoj.AutoSize = true;
            this.saldoj.Location = new System.Drawing.Point(51, 9);
            this.saldoj.Name = "saldoj";
            this.saldoj.Size = new System.Drawing.Size(13, 15);
            this.saldoj.TabIndex = 2;
            this.saldoj.Text = "0";
            // 
            // saldoC
            // 
            this.saldoC.AutoSize = true;
            this.saldoC.Location = new System.Drawing.Point(514, 9);
            this.saldoC.Name = "saldoC";
            this.saldoC.Size = new System.Drawing.Size(13, 15);
            this.saldoC.TabIndex = 3;
            this.saldoC.Text = "0";
            // 
            // apostarBtn
            // 
            this.apostarBtn.Location = new System.Drawing.Point(165, 207);
            this.apostarBtn.Name = "apostarBtn";
            this.apostarBtn.Size = new System.Drawing.Size(88, 42);
            this.apostarBtn.TabIndex = 4;
            this.apostarBtn.Text = "Apostar";
            this.apostarBtn.UseVisualStyleBackColor = true;
            this.apostarBtn.Click += new System.EventHandler(this.apostarBtn_Click);
            // 
            // valorApuesta
            // 
            this.valorApuesta.Location = new System.Drawing.Point(227, 178);
            this.valorApuesta.Name = "valorApuesta";
            this.valorApuesta.Size = new System.Drawing.Size(88, 23);
            this.valorApuesta.TabIndex = 5;
            // 
            // multiplicadorX
            // 
            this.multiplicadorX.AutoSize = true;
            this.multiplicadorX.Location = new System.Drawing.Point(251, 120);
            this.multiplicadorX.Name = "multiplicadorX";
            this.multiplicadorX.Size = new System.Drawing.Size(22, 15);
            this.multiplicadorX.TabIndex = 6;
            this.multiplicadorX.Text = "1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Detener";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Apostado
            // 
            this.Apostado.AutoSize = true;
            this.Apostado.BackColor = System.Drawing.Color.Lime;
            this.Apostado.Location = new System.Drawing.Point(240, 9);
            this.Apostado.Name = "Apostado";
            this.Apostado.Size = new System.Drawing.Size(58, 15);
            this.Apostado.TabIndex = 9;
            this.Apostado.Text = "Apostado";
            // 
            // multiplicadorAnterior
            // 
            this.multiplicadorAnterior.AutoSize = true;
            this.multiplicadorAnterior.BackColor = System.Drawing.Color.Yellow;
            this.multiplicadorAnterior.Location = new System.Drawing.Point(353, 120);
            this.multiplicadorAnterior.Name = "multiplicadorAnterior";
            this.multiplicadorAnterior.Size = new System.Drawing.Size(22, 15);
            this.multiplicadorAnterior.TabIndex = 10;
            this.multiplicadorAnterior.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Anterior";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.BackColor = System.Drawing.Color.Orange;
            this.estado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.estado.Location = new System.Drawing.Point(337, 9);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(42, 15);
            this.estado.TabIndex = 13;
            this.estado.Text = "estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 290);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.multiplicadorAnterior);
            this.Controls.Add(this.Apostado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.multiplicadorX);
            this.Controls.Add(this.valorApuesta);
            this.Controls.Add(this.apostarBtn);
            this.Controls.Add(this.saldoC);
            this.Controls.Add(this.saldoj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private Label label2;
        private Label saldoj;
        private Label saldoC;
        private Button apostarBtn;
        private TextBox valorApuesta;
        private Label multiplicadorX;
        private Label label4;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label Apostado;
        private Label multiplicadorAnterior;
        private Label label3;
        private Label label5;
        private Label estado;
    }
}