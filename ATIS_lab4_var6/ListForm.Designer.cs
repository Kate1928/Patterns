﻿namespace ATIS_lab4_var6
{
    partial class ListForm
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
            this.listManager = new System.Windows.Forms.ListView();
            this.IDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConditionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AviaryCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DietCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TherapyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonManagerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listManager
            // 
            this.listManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCol,
            this.ConditionCol,
            this.TypeCol,
            this.AviaryCol,
            this.DietCol,
            this.TherapyCol});
            this.listManager.HideSelection = false;
            this.listManager.Location = new System.Drawing.Point(0, 0);
            this.listManager.Name = "listManager";
            this.listManager.Size = new System.Drawing.Size(1002, 378);
            this.listManager.TabIndex = 2;
            this.listManager.UseCompatibleStateImageBehavior = false;
            this.listManager.View = System.Windows.Forms.View.Details;
            // 
            // IDCol
            // 
            this.IDCol.Text = "ID";
            this.IDCol.Width = 150;
            // 
            // ConditionCol
            // 
            this.ConditionCol.Text = "Состояние";
            this.ConditionCol.Width = 150;
            // 
            // TypeCol
            // 
            this.TypeCol.Text = "Тип";
            this.TypeCol.Width = 150;
            // 
            // AviaryCol
            // 
            this.AviaryCol.Text = "Вольер";
            // 
            // DietCol
            // 
            this.DietCol.Text = "Накормлено";
            this.DietCol.Width = 150;
            // 
            // TherapyCol
            // 
            this.TherapyCol.Text = "Лечение";
            this.TherapyCol.Width = 150;
            // 
            // buttonManagerForm
            // 
            this.buttonManagerForm.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonManagerForm.Location = new System.Drawing.Point(410, 397);
            this.buttonManagerForm.Name = "buttonManagerForm";
            this.buttonManagerForm.Size = new System.Drawing.Size(168, 38);
            this.buttonManagerForm.TabIndex = 8;
            this.buttonManagerForm.Text = "Обновить";
            this.buttonManagerForm.UseVisualStyleBackColor = false;
            this.buttonManagerForm.Click += new System.EventHandler(this.buttonManagerForm_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1000, 447);
            this.Controls.Add(this.buttonManagerForm);
            this.Controls.Add(this.listManager);
            this.Name = "ListForm";
            this.Text = "Животные";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listManager;
        private System.Windows.Forms.ColumnHeader ConditionCol;
        private System.Windows.Forms.ColumnHeader TypeCol;
        private System.Windows.Forms.ColumnHeader AviaryCol;
        private System.Windows.Forms.ColumnHeader DietCol;
        private System.Windows.Forms.ColumnHeader TherapyCol;
        internal System.Windows.Forms.ColumnHeader IDCol;
        private System.Windows.Forms.Button buttonManagerForm;
    }
}