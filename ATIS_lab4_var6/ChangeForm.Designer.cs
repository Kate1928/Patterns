namespace ATIS_lab4_var6
{
    partial class ChangeForm
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
            this.butCoolHeat = new System.Windows.Forms.Button();
            this.IDBoxChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stateBoxChange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCoolHeat
            // 
            this.butCoolHeat.BackColor = System.Drawing.Color.DarkOrange;
            this.butCoolHeat.Location = new System.Drawing.Point(133, 200);
            this.butCoolHeat.Name = "butCoolHeat";
            this.butCoolHeat.Size = new System.Drawing.Size(124, 36);
            this.butCoolHeat.TabIndex = 12;
            this.butCoolHeat.Text = "Далее";
            this.butCoolHeat.UseVisualStyleBackColor = false;
            this.butCoolHeat.Click += new System.EventHandler(this.butCoolHeat_Click);
            // 
            // IDBoxChange
            // 
            this.IDBoxChange.Location = new System.Drawing.Point(157, 66);
            this.IDBoxChange.Name = "IDBoxChange";
            this.IDBoxChange.Size = new System.Drawing.Size(100, 22);
            this.IDBoxChange.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID животного";
            // 
            // stateBoxChange
            // 
            this.stateBoxChange.FormattingEnabled = true;
            this.stateBoxChange.Items.AddRange(new object[] {
            "здорово",
            "больное",
            "умерло"});
            this.stateBoxChange.Location = new System.Drawing.Point(220, 135);
            this.stateBoxChange.Name = "stateBoxChange";
            this.stateBoxChange.Size = new System.Drawing.Size(142, 24);
            this.stateBoxChange.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Состояние животного";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(431, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateBoxChange);
            this.Controls.Add(this.butCoolHeat);
            this.Controls.Add(this.IDBoxChange);
            this.Controls.Add(this.label2);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCoolHeat;
        public System.Windows.Forms.TextBox IDBoxChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox stateBoxChange;
    }
}