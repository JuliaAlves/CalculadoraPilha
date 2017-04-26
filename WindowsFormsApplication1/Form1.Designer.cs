namespace Calculadora
{
    partial class Calculadora
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
            this.btnElevar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnFechaParenteses = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAbreParenteses = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.edVisor = new System.Windows.Forms.TextBox();
            this.edResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPosfixa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInfixa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnElevar
            // 
            this.btnElevar.Location = new System.Drawing.Point(16, 106);
            this.btnElevar.Name = "btnElevar";
            this.btnElevar.Size = new System.Drawing.Size(73, 33);
            this.btnElevar.TabIndex = 0;
            this.btnElevar.Text = "^";
            this.btnElevar.UseVisualStyleBackColor = true;
            this.btnElevar.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(97, 106);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(73, 33);
            this.btnDividir.TabIndex = 1;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(178, 106);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(73, 33);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(259, 106);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(73, 33);
            this.btnSubtrair.TabIndex = 3;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(259, 146);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(73, 33);
            this.btnSomar.TabIndex = 7;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(178, 146);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(73, 33);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(97, 146);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(73, 33);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(16, 146);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(73, 33);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(259, 188);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(73, 33);
            this.btnPonto.TabIndex = 11;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(178, 188);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(73, 33);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(97, 188);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(73, 33);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(16, 188);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(73, 33);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnFechaParenteses
            // 
            this.btnFechaParenteses.Location = new System.Drawing.Point(259, 228);
            this.btnFechaParenteses.Name = "btnFechaParenteses";
            this.btnFechaParenteses.Size = new System.Drawing.Size(73, 33);
            this.btnFechaParenteses.TabIndex = 15;
            this.btnFechaParenteses.Text = ")";
            this.btnFechaParenteses.UseVisualStyleBackColor = true;
            this.btnFechaParenteses.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(178, 228);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(73, 33);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(97, 228);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(73, 33);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(16, 228);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 33);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnAbreParenteses
            // 
            this.btnAbreParenteses.Location = new System.Drawing.Point(259, 269);
            this.btnAbreParenteses.Name = "btnAbreParenteses";
            this.btnAbreParenteses.Size = new System.Drawing.Size(73, 33);
            this.btnAbreParenteses.TabIndex = 19;
            this.btnAbreParenteses.Text = "(";
            this.btnAbreParenteses.UseVisualStyleBackColor = true;
            this.btnAbreParenteses.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(178, 269);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(73, 33);
            this.btnC.TabIndex = 18;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(97, 269);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(73, 33);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.tratarBotao);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(16, 269);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(73, 33);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.tratarBotao);
            // 
            // edVisor
            // 
            this.edVisor.Enabled = false;
            this.edVisor.Location = new System.Drawing.Point(16, 15);
            this.edVisor.Name = "edVisor";
            this.edVisor.Size = new System.Drawing.Size(316, 22);
            this.edVisor.TabIndex = 20;
            // 
            // edResultado
            // 
            this.edResultado.Enabled = false;
            this.edResultado.Location = new System.Drawing.Point(16, 41);
            this.edResultado.Name = "edResultado";
            this.edResultado.Size = new System.Drawing.Size(316, 22);
            this.edResultado.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pósfixa:";
            // 
            // lbPosfixa
            // 
            this.lbPosfixa.AutoSize = true;
            this.lbPosfixa.Location = new System.Drawing.Point(191, 75);
            this.lbPosfixa.Name = "lbPosfixa";
            this.lbPosfixa.Size = new System.Drawing.Size(45, 16);
            this.lbPosfixa.TabIndex = 23;
            this.lbPosfixa.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Infixa:";
            // 
            // lbInfixa
            // 
            this.lbInfixa.AutoSize = true;
            this.lbInfixa.Location = new System.Drawing.Point(66, 75);
            this.lbInfixa.Name = "lbInfixa";
            this.lbInfixa.Size = new System.Drawing.Size(45, 16);
            this.lbInfixa.TabIndex = 25;
            this.lbInfixa.Text = "label3";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 320);
            this.Controls.Add(this.lbInfixa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPosfixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edResultado);
            this.Controls.Add(this.edVisor);
            this.Controls.Add(this.btnAbreParenteses);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnFechaParenteses);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnElevar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElevar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnFechaParenteses;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAbreParenteses;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox edVisor;
        private System.Windows.Forms.TextBox edResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPosfixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInfixa;
    }
}

