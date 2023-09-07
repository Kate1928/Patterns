namespace ATIS_lab4_var6
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
            this.postLabel1 = new System.Windows.Forms.Label();
            this.continueButton1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // postLabel1
            // 
            this.postLabel1.AutoSize = true;
            this.postLabel1.Location = new System.Drawing.Point(46, 42);
            this.postLabel1.Name = "postLabel1";
            this.postLabel1.Size = new System.Drawing.Size(81, 16);
            this.postLabel1.TabIndex = 0;
            this.postLabel1.Text = "Должность:";
            // 
            // continueButton1
            // 
            this.continueButton1.BackColor = System.Drawing.Color.Orange;
            this.continueButton1.Location = new System.Drawing.Point(175, 193);
            this.continueButton1.Name = "continueButton1";
            this.continueButton1.Size = new System.Drawing.Size(177, 27);
            this.continueButton1.TabIndex = 10;
            this.continueButton1.Text = "Далее";
            this.continueButton1.UseVisualStyleBackColor = false;
            this.continueButton1.Click += new System.EventHandler(this.continueButton1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Менеджер",
            "Уборщик",
            "Ветеринарный врач",
            "Работник"});
            this.comboBox1.Location = new System.Drawing.Point(259, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 22);
            this.textBox1.TabIndex = 13;
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(520, 249);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.continueButton1);
            this.Controls.Add(this.postLabel1);
            this.Name = "Form1";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label postLabel1;
        private System.Windows.Forms.Button continueButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

