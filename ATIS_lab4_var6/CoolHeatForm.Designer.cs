namespace ATIS_lab4_var6
{
    partial class CoolHeatForm
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
            this.IDBoxCoolHeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butCoolHeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDBoxCoolHeat
            // 
            this.IDBoxCoolHeat.Location = new System.Drawing.Point(161, 46);
            this.IDBoxCoolHeat.Name = "IDBoxCoolHeat";
            this.IDBoxCoolHeat.Size = new System.Drawing.Size(100, 22);
            this.IDBoxCoolHeat.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID вольера";
            // 
            // butCoolHeat
            // 
            this.butCoolHeat.BackColor = System.Drawing.Color.DarkOrange;
            this.butCoolHeat.Location = new System.Drawing.Point(89, 124);
            this.butCoolHeat.Name = "butCoolHeat";
            this.butCoolHeat.Size = new System.Drawing.Size(124, 36);
            this.butCoolHeat.TabIndex = 9;
            this.butCoolHeat.Text = "Далее";
            this.butCoolHeat.UseVisualStyleBackColor = false;
            this.butCoolHeat.Click += new System.EventHandler(this.butCoolHeat_Click);
            // 
            // CoolHeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(314, 191);
            this.Controls.Add(this.butCoolHeat);
            this.Controls.Add(this.IDBoxCoolHeat);
            this.Controls.Add(this.label2);
            this.Name = "CoolHeatForm";
            this.Text = "CoolHeatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox IDBoxCoolHeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butCoolHeat;
    }
}