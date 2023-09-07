namespace ATIS_lab4_var6
{
    partial class TreatmentForm
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
            this.therapyBox = new System.Windows.Forms.CheckBox();
            this.noTherapyBox = new System.Windows.Forms.CheckBox();
            this.treatmentBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBoxThreatment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // therapyBox
            // 
            this.therapyBox.AutoSize = true;
            this.therapyBox.Location = new System.Drawing.Point(83, 120);
            this.therapyBox.Name = "therapyBox";
            this.therapyBox.Size = new System.Drawing.Size(160, 20);
            this.therapyBox.TabIndex = 1;
            this.therapyBox.Text = "Назначить лечение";
            this.therapyBox.UseVisualStyleBackColor = true;
            // 
            // noTherapyBox
            // 
            this.noTherapyBox.AutoSize = true;
            this.noTherapyBox.Location = new System.Drawing.Point(83, 210);
            this.noTherapyBox.Name = "noTherapyBox";
            this.noTherapyBox.Size = new System.Drawing.Size(134, 20);
            this.noTherapyBox.TabIndex = 2;
            this.noTherapyBox.Text = "Никаго лечения";
            this.noTherapyBox.UseVisualStyleBackColor = true;
            // 
            // treatmentBox
            // 
            this.treatmentBox.FormattingEnabled = true;
            this.treatmentBox.Items.AddRange(new object[] {
            "охлаждение",
            "подогрев",
            "особое питание",
            "дезинфекция"});
            this.treatmentBox.Location = new System.Drawing.Point(198, 162);
            this.treatmentBox.Name = "treatmentBox";
            this.treatmentBox.Size = new System.Drawing.Size(121, 24);
            this.treatmentBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вид лечения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID животного";
            // 
            // IDBoxThreatment
            // 
            this.IDBoxThreatment.Location = new System.Drawing.Point(198, 68);
            this.IDBoxThreatment.Name = "IDBoxThreatment";
            this.IDBoxThreatment.Size = new System.Drawing.Size(100, 22);
            this.IDBoxThreatment.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(124, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(396, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDBoxThreatment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treatmentBox);
            this.Controls.Add(this.noTherapyBox);
            this.Controls.Add(this.therapyBox);
            this.Name = "TreatmentForm";
            this.Text = "TreatmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox therapyBox;
        public System.Windows.Forms.CheckBox noTherapyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox IDBoxThreatment;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox treatmentBox;
    }
}