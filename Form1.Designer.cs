﻿namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawEllipse = new System.Windows.Forms.Button();
            this.DrawRectangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawEllipse
            // 
            this.DrawEllipse.Location = new System.Drawing.Point(717, 527);
            this.DrawEllipse.Name = "DrawEllipse";
            this.DrawEllipse.Size = new System.Drawing.Size(55, 23);
            this.DrawEllipse.TabIndex = 0;
            this.DrawEllipse.Text = "Эллипс";
            this.DrawEllipse.UseVisualStyleBackColor = true;
            this.DrawEllipse.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawRectangle
            // 
            this.DrawRectangle.Location = new System.Drawing.Point(616, 527);
            this.DrawRectangle.Name = "DrawRectangle";
            this.DrawRectangle.Size = new System.Drawing.Size(95, 23);
            this.DrawRectangle.TabIndex = 1;
            this.DrawRectangle.Text = "Прямоугольник";
            this.DrawRectangle.UseVisualStyleBackColor = true;
            this.DrawRectangle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.DrawRectangle);
            this.Controls.Add(this.DrawEllipse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawEllipse;
        private System.Windows.Forms.Button DrawRectangle;

    }
}

