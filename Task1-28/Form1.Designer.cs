﻿
namespace Task1_28
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matrixSizeInput = new System.Windows.Forms.TextBox();
            this.generateMatrix = new System.Windows.Forms.Button();
            this.colLabel = new System.Windows.Forms.Label();
            this.colLabelResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rowLabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(28, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 322);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите квадратную матрицу";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(156, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сформировать вектор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(28, 538);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(409, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(490, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размер кв.матрицы";
            // 
            // matrixSizeInput
            // 
            this.matrixSizeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrixSizeInput.Location = new System.Drawing.Point(653, 150);
            this.matrixSizeInput.Name = "matrixSizeInput";
            this.matrixSizeInput.Size = new System.Drawing.Size(54, 26);
            this.matrixSizeInput.TabIndex = 6;
            // 
            // generateMatrix
            // 
            this.generateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateMatrix.Location = new System.Drawing.Point(508, 196);
            this.generateMatrix.Name = "generateMatrix";
            this.generateMatrix.Size = new System.Drawing.Size(199, 58);
            this.generateMatrix.TabIndex = 7;
            this.generateMatrix.Text = "Сгенерировать рандомную матрицу";
            this.generateMatrix.UseVisualStyleBackColor = true;
            this.generateMatrix.Click += new System.EventHandler(this.GenerateMatrix_Click);
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLabel.Location = new System.Drawing.Point(443, 348);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(255, 20);
            this.colLabel.TabIndex = 9;
            this.colLabel.Text = "Столбец с макс.произведением:";
            // 
            // colLabelResult
            // 
            this.colLabelResult.AutoSize = true;
            this.colLabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLabelResult.Location = new System.Drawing.Point(707, 348);
            this.colLabelResult.Name = "colLabelResult";
            this.colLabelResult.Size = new System.Drawing.Size(0, 20);
            this.colLabelResult.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(443, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Строка с макс.произведением:";
            // 
            // rowLabelResult
            // 
            this.rowLabelResult.AutoSize = true;
            this.rowLabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowLabelResult.Location = new System.Drawing.Point(708, 318);
            this.rowLabelResult.Name = "rowLabelResult";
            this.rowLabelResult.Size = new System.Drawing.Size(0, 20);
            this.rowLabelResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(780, 643);
            this.Controls.Add(this.rowLabelResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colLabelResult);
            this.Controls.Add(this.colLabel);
            this.Controls.Add(this.generateMatrix);
            this.Controls.Add(this.matrixSizeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox matrixSizeInput;
        private System.Windows.Forms.Button generateMatrix;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label colLabelResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rowLabelResult;
    }
}

