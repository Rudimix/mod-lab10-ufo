
namespace UfoProj
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
            this.startButton = new System.Windows.Forms.Button();
            this.xLast = new System.Windows.Forms.TextBox();
            this.yLast = new System.Windows.Forms.TextBox();
            this.CountOf = new System.Windows.Forms.TextBox();
            this.Precision = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(29, 130);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // xLast
            // 
            this.xLast.Location = new System.Drawing.Point(29, 26);
            this.xLast.Name = "xLast";
            this.xLast.Size = new System.Drawing.Size(100, 20);
            this.xLast.TabIndex = 2;
            // 
            // yLast
            // 
            this.yLast.Location = new System.Drawing.Point(29, 52);
            this.yLast.Name = "yLast";
            this.yLast.Size = new System.Drawing.Size(100, 20);
            this.yLast.TabIndex = 3;
            // 
            // CountOf
            // 
            this.CountOf.Location = new System.Drawing.Point(29, 78);
            this.CountOf.Name = "CountOf";
            this.CountOf.Size = new System.Drawing.Size(100, 20);
            this.CountOf.TabIndex = 4;
            // 
            // Precision
            // 
            this.Precision.Location = new System.Drawing.Point(29, 104);
            this.Precision.Name = "Precision";
            this.Precision.Size = new System.Drawing.Size(100, 20);
            this.Precision.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Precision);
            this.Controls.Add(this.CountOf);
            this.Controls.Add(this.yLast);
            this.Controls.Add(this.xLast);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox xLast;
        private System.Windows.Forms.TextBox yLast;
        private System.Windows.Forms.TextBox CountOf;
        private System.Windows.Forms.TextBox Precision;
    }
}