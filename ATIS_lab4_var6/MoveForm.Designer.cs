namespace ATIS_lab4_var6
{
    partial class MoveForm
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
            this.IDBoxAnimal = new System.Windows.Forms.TextBox();
            this.IDBoxAviary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID животного";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID вольера";
            // 
            // IDBoxAnimal
            // 
            this.IDBoxAnimal.Location = new System.Drawing.Point(183, 39);
            this.IDBoxAnimal.Name = "IDBoxAnimal";
            this.IDBoxAnimal.Size = new System.Drawing.Size(100, 22);
            this.IDBoxAnimal.TabIndex = 9;
            // 
            // IDBoxAviary
            // 
            this.IDBoxAviary.Location = new System.Drawing.Point(183, 101);
            this.IDBoxAviary.Name = "IDBoxAviary";
            this.IDBoxAviary.Size = new System.Drawing.Size(100, 22);
            this.IDBoxAviary.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(94, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(322, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDBoxAviary);
            this.Controls.Add(this.IDBoxAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MoveForm";
            this.Text = "MoveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox IDBoxAnimal;
        public System.Windows.Forms.TextBox IDBoxAviary;
        private System.Windows.Forms.Button button1;
    }
}