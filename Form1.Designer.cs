namespace CALC_DROB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edPlus = new System.Windows.Forms.Button();
            this.edMinus = new System.Windows.Forms.Button();
            this.edMultiplication = new System.Windows.Forms.Button();
            this.edDivision = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edClear = new System.Windows.Forms.Button();
            this.edN1 = new System.Windows.Forms.NumericUpDown();
            this.edD1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edD2 = new System.Windows.Forms.NumericUpDown();
            this.edN2 = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.edD3 = new System.Windows.Forms.NumericUpDown();
            this.edN3 = new System.Windows.Forms.NumericUpDown();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edN3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДРОБЬ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ДРОБЬ 2";
            // 
            // edPlus
            // 
            this.edPlus.Location = new System.Drawing.Point(38, 265);
            this.edPlus.Name = "edPlus";
            this.edPlus.Size = new System.Drawing.Size(200, 60);
            this.edPlus.TabIndex = 2;
            this.edPlus.Text = "Сложение";
            this.edPlus.UseVisualStyleBackColor = true;
            this.edPlus.Click += new System.EventHandler(this.edPlus_Click);
            // 
            // edMinus
            // 
            this.edMinus.Location = new System.Drawing.Point(261, 265);
            this.edMinus.Name = "edMinus";
            this.edMinus.Size = new System.Drawing.Size(200, 60);
            this.edMinus.TabIndex = 3;
            this.edMinus.Text = "Вычитание";
            this.edMinus.UseVisualStyleBackColor = true;
            this.edMinus.Click += new System.EventHandler(this.edMinus_Click);
            // 
            // edMultiplication
            // 
            this.edMultiplication.Location = new System.Drawing.Point(38, 350);
            this.edMultiplication.Name = "edMultiplication";
            this.edMultiplication.Size = new System.Drawing.Size(200, 60);
            this.edMultiplication.TabIndex = 4;
            this.edMultiplication.Text = "Умножение";
            this.edMultiplication.UseVisualStyleBackColor = true;
            this.edMultiplication.Click += new System.EventHandler(this.edMultiplication_Click);
            // 
            // edDivision
            // 
            this.edDivision.Location = new System.Drawing.Point(261, 350);
            this.edDivision.Name = "edDivision";
            this.edDivision.Size = new System.Drawing.Size(200, 60);
            this.edDivision.TabIndex = 5;
            this.edDivision.Text = "Деление";
            this.edDivision.UseVisualStyleBackColor = true;
            this.edDivision.Click += new System.EventHandler(this.edDivision_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(555, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // edClear
            // 
            this.edClear.Location = new System.Drawing.Point(525, 350);
            this.edClear.Name = "edClear";
            this.edClear.Size = new System.Drawing.Size(200, 60);
            this.edClear.TabIndex = 17;
            this.edClear.Text = "Очистить";
            this.edClear.UseVisualStyleBackColor = true;
            this.edClear.Click += new System.EventHandler(this.edClear_Click);
            // 
            // edN1
            // 
            this.edN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edN1.Location = new System.Drawing.Point(91, 94);
            this.edN1.Name = "edN1";
            this.edN1.Size = new System.Drawing.Size(120, 38);
            this.edN1.TabIndex = 18;
            // 
            // edD1
            // 
            this.edD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edD1.Location = new System.Drawing.Point(91, 154);
            this.edD1.Name = "edD1";
            this.edD1.Size = new System.Drawing.Size(120, 38);
            this.edD1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(71, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 10);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(376, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 10);
            this.panel2.TabIndex = 23;
            // 
            // edD2
            // 
            this.edD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edD2.Location = new System.Drawing.Point(396, 154);
            this.edD2.Name = "edD2";
            this.edD2.Size = new System.Drawing.Size(120, 38);
            this.edD2.TabIndex = 22;
            // 
            // edN2
            // 
            this.edN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edN2.Location = new System.Drawing.Point(396, 94);
            this.edN2.Name = "edN2";
            this.edN2.Size = new System.Drawing.Size(120, 38);
            this.edN2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(603, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 10);
            this.panel3.TabIndex = 26;
            // 
            // edD3
            // 
            this.edD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edD3.Location = new System.Drawing.Point(623, 154);
            this.edD3.Name = "edD3";
            this.edD3.Size = new System.Drawing.Size(120, 38);
            this.edD3.TabIndex = 25;
            // 
            // edN3
            // 
            this.edN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edN3.Location = new System.Drawing.Point(623, 94);
            this.edN3.Name = "edN3";
            this.edN3.Size = new System.Drawing.Size(120, 38);
            this.edN3.TabIndex = 24;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl.Location = new System.Drawing.Point(268, 123);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(93, 32);
            this.lbl.TabIndex = 27;
            this.lbl.Text = "label4";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.edD3);
            this.Controls.Add(this.edN3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.edD2);
            this.Controls.Add(this.edN2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edD1);
            this.Controls.Add(this.edN1);
            this.Controls.Add(this.edClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edDivision);
            this.Controls.Add(this.edMultiplication);
            this.Controls.Add(this.edMinus);
            this.Controls.Add(this.edPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ё";
            ((System.ComponentModel.ISupportInitialize)(this.edN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edN3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edPlus;
        private System.Windows.Forms.Button edMinus;
        private System.Windows.Forms.Button edMultiplication;
        private System.Windows.Forms.Button edDivision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button edClear;
        private System.Windows.Forms.NumericUpDown edN1;
        private System.Windows.Forms.NumericUpDown edD1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown edD2;
        private System.Windows.Forms.NumericUpDown edN2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown edD3;
        private System.Windows.Forms.NumericUpDown edN3;
        private System.Windows.Forms.Label lbl;
    }
}

