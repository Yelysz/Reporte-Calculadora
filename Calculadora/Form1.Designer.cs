
namespace Calculadora
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
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonBorrarM = new System.Windows.Forms.Button();
            this.buttonPorcentaje = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonRaiz = new System.Windows.Forms.Button();
            this.buttonCuadrado = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonPN = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPunto = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultados.Location = new System.Drawing.Point(16, 13);
            this.txtResultados.MaxLength = 11;
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(289, 62);
            this.txtResultados.TabIndex = 0;
            this.txtResultados.Text = "0";
            this.txtResultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(18, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(73, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(128, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(128, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(73, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(18, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 4;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(128, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(73, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(18, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 7;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonQuitar.Location = new System.Drawing.Point(255, 90);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(50, 50);
            this.buttonQuitar.TabIndex = 12;
            this.buttonQuitar.Text = "←";
            this.buttonQuitar.UseVisualStyleBackColor = false;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // buttonBorrarM
            // 
            this.buttonBorrarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBorrarM.Location = new System.Drawing.Point(128, 90);
            this.buttonBorrarM.Name = "buttonBorrarM";
            this.buttonBorrarM.Size = new System.Drawing.Size(50, 50);
            this.buttonBorrarM.TabIndex = 11;
            this.buttonBorrarM.Text = "CE";
            this.buttonBorrarM.UseVisualStyleBackColor = false;
            this.buttonBorrarM.Click += new System.EventHandler(this.buttonBorrarM_Click);
            // 
            // buttonPorcentaje
            // 
            this.buttonPorcentaje.Location = new System.Drawing.Point(18, 90);
            this.buttonPorcentaje.Name = "buttonPorcentaje";
            this.buttonPorcentaje.Size = new System.Drawing.Size(50, 50);
            this.buttonPorcentaje.TabIndex = 10;
            this.buttonPorcentaje.Tag = "%";
            this.buttonPorcentaje.Text = "%";
            this.buttonPorcentaje.UseVisualStyleBackColor = true;
            this.buttonPorcentaje.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(255, 202);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(50, 50);
            this.buttonMulti.TabIndex = 20;
            this.buttonMulti.Tag = "*";
            this.buttonMulti.Text = "×";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonDividir
            // 
            this.buttonDividir.Location = new System.Drawing.Point(200, 202);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(50, 50);
            this.buttonDividir.TabIndex = 19;
            this.buttonDividir.Tag = "÷";
            this.buttonDividir.Text = "÷";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonRaiz
            // 
            this.buttonRaiz.Location = new System.Drawing.Point(255, 146);
            this.buttonRaiz.Name = "buttonRaiz";
            this.buttonRaiz.Size = new System.Drawing.Size(50, 50);
            this.buttonRaiz.TabIndex = 18;
            this.buttonRaiz.Tag = "√";
            this.buttonRaiz.Text = "√";
            this.buttonRaiz.UseVisualStyleBackColor = true;
            this.buttonRaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonCuadrado
            // 
            this.buttonCuadrado.Location = new System.Drawing.Point(200, 146);
            this.buttonCuadrado.Name = "buttonCuadrado";
            this.buttonCuadrado.Size = new System.Drawing.Size(50, 50);
            this.buttonCuadrado.TabIndex = 17;
            this.buttonCuadrado.Tag = "²";
            this.buttonCuadrado.Text = "x²";
            this.buttonCuadrado.UseVisualStyleBackColor = true;
            this.buttonCuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonResta
            // 
            this.buttonResta.Location = new System.Drawing.Point(255, 258);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(50, 50);
            this.buttonResta.TabIndex = 16;
            this.buttonResta.Tag = "‒";
            this.buttonResta.Text = "‒";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonSuma
            // 
            this.buttonSuma.Location = new System.Drawing.Point(200, 258);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(50, 50);
            this.buttonSuma.TabIndex = 15;
            this.buttonSuma.Tag = "+";
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // buttonIgual
            // 
            this.buttonIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonIgual.Location = new System.Drawing.Point(200, 314);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(105, 50);
            this.buttonIgual.TabIndex = 14;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonPN
            // 
            this.buttonPN.Location = new System.Drawing.Point(74, 90);
            this.buttonPN.Name = "buttonPN";
            this.buttonPN.Size = new System.Drawing.Size(50, 50);
            this.buttonPN.TabIndex = 13;
            this.buttonPN.Text = "±";
            this.buttonPN.UseVisualStyleBackColor = true;
            this.buttonPN.Click += new System.EventHandler(this.buttonPN_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.Location = new System.Drawing.Point(16, 314);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(107, 50);
            this.button0.TabIndex = 21;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonPunto
            // 
            this.buttonPunto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPunto.Location = new System.Drawing.Point(129, 314);
            this.buttonPunto.Name = "buttonPunto";
            this.buttonPunto.Size = new System.Drawing.Size(50, 50);
            this.buttonPunto.TabIndex = 22;
            this.buttonPunto.Text = ".";
            this.buttonPunto.UseVisualStyleBackColor = false;
            this.buttonPunto.Click += new System.EventHandler(this.buttonPunto_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBorrar.Location = new System.Drawing.Point(200, 90);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(50, 50);
            this.buttonBorrar.TabIndex = 23;
            this.buttonBorrar.Text = "C";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 382);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonPunto);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonRaiz);
            this.Controls.Add(this.buttonCuadrado);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonPN);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.buttonBorrarM);
            this.Controls.Add(this.buttonPorcentaje);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultados);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonBorrarM;
        private System.Windows.Forms.Button buttonPorcentaje;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button buttonRaiz;
        private System.Windows.Forms.Button buttonCuadrado;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonPN;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPunto;
        private System.Windows.Forms.Button buttonBorrar;
    }
}

