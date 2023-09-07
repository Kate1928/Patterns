namespace ATIS_lab4_var6
{
    partial class FeedForm
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
            this.allBoxFeed = new System.Windows.Forms.CheckBox();
            this.oneBoxFeed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBoxFeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allBoxFeed
            // 
            this.allBoxFeed.AutoSize = true;
            this.allBoxFeed.Location = new System.Drawing.Point(68, 112);
            this.allBoxFeed.Name = "allBoxFeed";
            this.allBoxFeed.Size = new System.Drawing.Size(124, 20);
            this.allBoxFeed.TabIndex = 0;
            this.allBoxFeed.Text = "всех животных";
            this.allBoxFeed.UseVisualStyleBackColor = true;
            // 
            // oneBoxFeed
            // 
            this.oneBoxFeed.AutoSize = true;
            this.oneBoxFeed.Location = new System.Drawing.Point(68, 183);
            this.oneBoxFeed.Name = "oneBoxFeed";
            this.oneBoxFeed.Size = new System.Drawing.Size(192, 20);
            this.oneBoxFeed.TabIndex = 1;
            this.oneBoxFeed.Text = "определенное животное";
            this.oneBoxFeed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Накормить";
            // 
            // IDBoxFeed
            // 
            this.IDBoxFeed.Location = new System.Drawing.Point(455, 181);
            this.IDBoxFeed.Name = "IDBoxFeed";
            this.IDBoxFeed.Size = new System.Drawing.Size(100, 22);
            this.IDBoxFeed.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // butFeed
            // 
            this.butFeed.BackColor = System.Drawing.Color.DarkOrange;
            this.butFeed.Location = new System.Drawing.Point(264, 256);
            this.butFeed.Name = "butFeed";
            this.butFeed.Size = new System.Drawing.Size(121, 36);
            this.butFeed.TabIndex = 5;
            this.butFeed.Text = "Далее";
            this.butFeed.UseVisualStyleBackColor = false;
            this.butFeed.Click += new System.EventHandler(this.butFeed_Click);
            // 
            // FeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(627, 323);
            this.Controls.Add(this.butFeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDBoxFeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oneBoxFeed);
            this.Controls.Add(this.allBoxFeed);
            this.Name = "FeedForm";
            this.Text = "FeedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox allBoxFeed;
        public System.Windows.Forms.CheckBox oneBoxFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button butFeed;
        public System.Windows.Forms.TextBox IDBoxFeed;
    }
}