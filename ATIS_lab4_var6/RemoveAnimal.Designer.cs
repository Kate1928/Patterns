namespace ATIS_lab4_var6
{
    partial class RemoveForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.IDtextManager = new System.Windows.Forms.TextBox();
            this.buttonManagerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID удаляемого животного";
            // 
            // IDtextManager
            // 
            this.IDtextManager.Location = new System.Drawing.Point(111, 74);
            this.IDtextManager.Name = "IDtextManager";
            this.IDtextManager.Size = new System.Drawing.Size(168, 22);
            this.IDtextManager.TabIndex = 6;
            // 
            // buttonManagerForm
            // 
            this.buttonManagerForm.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonManagerForm.Location = new System.Drawing.Point(111, 126);
            this.buttonManagerForm.Name = "buttonManagerForm";
            this.buttonManagerForm.Size = new System.Drawing.Size(168, 38);
            this.buttonManagerForm.TabIndex = 7;
            this.buttonManagerForm.Text = "Далее";
            this.buttonManagerForm.UseVisualStyleBackColor = false;
            this.buttonManagerForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(395, 190);
            this.Controls.Add(this.buttonManagerForm);
            this.Controls.Add(this.IDtextManager);
            this.Controls.Add(this.label3);
            this.Name = "RemoveForm";
            this.Text = "Удалить животное";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonManagerForm;
        public System.Windows.Forms.TextBox IDtextManager;
    }
}