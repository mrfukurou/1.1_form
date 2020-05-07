namespace WindowsFormsApp3
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
            this.a = new System.Windows.Forms.TextBox();
            this.Rez = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторона треугольника а:";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(265, 42);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(238, 22);
            this.a.TabIndex = 1;
            // 
            // Rez
            // 
            this.Rez.Location = new System.Drawing.Point(265, 76);
            this.Rez.Name = "Rez";
            this.Rez.Size = new System.Drawing.Size(238, 22);
            this.Rez.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Радиус вписанной окружности:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rez);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox Rez;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

