namespace WinFormsMathHelper
{
    partial class Math
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
            this.bFactorial = new System.Windows.Forms.Button();
            this.bQuadraticEquation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bFactorial
            // 
            this.bFactorial.Location = new System.Drawing.Point(12, 12);
            this.bFactorial.Name = "bFactorial";
            this.bFactorial.Size = new System.Drawing.Size(260, 110);
            this.bFactorial.TabIndex = 0;
            this.bFactorial.Text = "ФАКТОРИАЛ ЧИСЛА";
            this.bFactorial.UseVisualStyleBackColor = true;
            this.bFactorial.Click += new System.EventHandler(this.bFactorial_Click);
            // 
            // bQuadraticEquation
            // 
            this.bQuadraticEquation.Location = new System.Drawing.Point(12, 128);
            this.bQuadraticEquation.Name = "bQuadraticEquation";
            this.bQuadraticEquation.Size = new System.Drawing.Size(260, 110);
            this.bQuadraticEquation.TabIndex = 1;
            this.bQuadraticEquation.Text = "КВАДРАТНОЕ УРАВНЕНИЕ";
            this.bQuadraticEquation.UseVisualStyleBackColor = true;
            this.bQuadraticEquation.Click += new System.EventHandler(this.bQuadraticEquation_Click);
            // 
            // Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.bQuadraticEquation);
            this.Controls.Add(this.bFactorial);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Math";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bFactorial;
        private System.Windows.Forms.Button bQuadraticEquation;
    }
}

