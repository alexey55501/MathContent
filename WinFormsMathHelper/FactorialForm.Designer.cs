namespace WinFormsMathHelper
{
    partial class FactorialForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.bCountFactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Результат вычислений";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(205, 66);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 2;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRes
            // 
            this.tbRes.Enabled = false;
            this.tbRes.Location = new System.Drawing.Point(205, 120);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(100, 20);
            this.tbRes.TabIndex = 3;
            this.tbRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCountFactorial
            // 
            this.bCountFactorial.Location = new System.Drawing.Point(217, 91);
            this.bCountFactorial.Name = "bCountFactorial";
            this.bCountFactorial.Size = new System.Drawing.Size(75, 23);
            this.bCountFactorial.TabIndex = 4;
            this.bCountFactorial.Tag = "\\/";
            this.bCountFactorial.Text = "\\/";
            this.bCountFactorial.UseVisualStyleBackColor = true;
            this.bCountFactorial.Click += new System.EventHandler(this.bCountFactorial_Click);
            // 
            // FactorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 206);
            this.Controls.Add(this.bCountFactorial);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FactorialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.Button bCountFactorial;
    }
}