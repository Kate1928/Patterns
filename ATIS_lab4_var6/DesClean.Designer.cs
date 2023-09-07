namespace ATIS_lab4_var6
{
    partial class DesClean
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
            this.allBoxDes = new System.Windows.Forms.CheckBox();
            this.OneBoxDes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBoxDes = new System.Windows.Forms.TextBox();
            this.buttonDes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дезинфекия/уборка";
            // 
            // allBoxDes
            // 
            this.allBoxDes.AutoSize = true;
            this.allBoxDes.Location = new System.Drawing.Point(46, 84);
            this.allBoxDes.Name = "allBoxDes";
            this.allBoxDes.Size = new System.Drawing.Size(124, 20);
            this.allBoxDes.TabIndex = 1;
            this.allBoxDes.Text = "всех вольеров";
            this.allBoxDes.UseVisualStyleBackColor = true;
            // 
            // OneBoxDes
            // 
            this.OneBoxDes.AutoSize = true;
            this.OneBoxDes.Location = new System.Drawing.Point(46, 147);
            this.OneBoxDes.Name = "OneBoxDes";
            this.OneBoxDes.Size = new System.Drawing.Size(176, 20);
            this.OneBoxDes.TabIndex = 2;
            this.OneBoxDes.Text = "определенный вольер";
            this.OneBoxDes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // IDBoxDes
            // 
            this.IDBoxDes.Location = new System.Drawing.Point(395, 145);
            this.IDBoxDes.Name = "IDBoxDes";
            this.IDBoxDes.Size = new System.Drawing.Size(100, 22);
            this.IDBoxDes.TabIndex = 4;
            // 
            // buttonDes
            // 
            this.buttonDes.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDes.Location = new System.Drawing.Point(211, 211);
            this.buttonDes.Name = "buttonDes";
            this.buttonDes.Size = new System.Drawing.Size(124, 23);
            this.buttonDes.TabIndex = 5;
            this.buttonDes.Text = "Далее";
            this.buttonDes.UseVisualStyleBackColor = false;
            this.buttonDes.Click += new System.EventHandler(this.buttonDes_Click);
            // 
            // DesClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(551, 270);
            this.Controls.Add(this.buttonDes);
            this.Controls.Add(this.IDBoxDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OneBoxDes);
            this.Controls.Add(this.allBoxDes);
            this.Controls.Add(this.label1);
            this.Name = "DesClean";
            this.Text = "DesClean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox allBoxDes;
        public System.Windows.Forms.CheckBox OneBoxDes;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox IDBoxDes;
        private System.Windows.Forms.Button buttonDes;
    }
}