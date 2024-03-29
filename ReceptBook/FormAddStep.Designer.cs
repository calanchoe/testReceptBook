﻿namespace ReceptBook
{
    partial class FormAddStep
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStepNum = new System.Windows.Forms.TextBox();
            this.textBoxDiscriptionStep = new System.Windows.Forms.TextBox();
            this.buttonNewStep = new System.Windows.Forms.Button();
            this.buttonNextAddIngr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Створення рецепту: крок 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Додати крок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "№";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Опис ";
            // 
            // textBoxStepNum
            // 
            this.textBoxStepNum.Location = new System.Drawing.Point(70, 56);
            this.textBoxStepNum.Name = "textBoxStepNum";
            this.textBoxStepNum.Size = new System.Drawing.Size(54, 20);
            this.textBoxStepNum.TabIndex = 4;
            // 
            // textBoxDiscriptionStep
            // 
            this.textBoxDiscriptionStep.Location = new System.Drawing.Point(70, 85);
            this.textBoxDiscriptionStep.Name = "textBoxDiscriptionStep";
            this.textBoxDiscriptionStep.Size = new System.Drawing.Size(200, 20);
            this.textBoxDiscriptionStep.TabIndex = 5;
            // 
            // buttonNewStep
            // 
            this.buttonNewStep.BackColor = System.Drawing.Color.Khaki;
            this.buttonNewStep.Location = new System.Drawing.Point(13, 124);
            this.buttonNewStep.Name = "buttonNewStep";
            this.buttonNewStep.Size = new System.Drawing.Size(75, 23);
            this.buttonNewStep.TabIndex = 6;
            this.buttonNewStep.Text = "Новий крок";
            this.buttonNewStep.UseVisualStyleBackColor = false;
            // 
            // buttonNextAddIngr
            // 
            this.buttonNextAddIngr.Location = new System.Drawing.Point(208, 124);
            this.buttonNextAddIngr.Name = "buttonNextAddIngr";
            this.buttonNextAddIngr.Size = new System.Drawing.Size(75, 23);
            this.buttonNextAddIngr.TabIndex = 7;
            this.buttonNextAddIngr.Text = "Next->";
            this.buttonNextAddIngr.UseVisualStyleBackColor = true;
            this.buttonNextAddIngr.Click += new System.EventHandler(this.buttonNextAddIngr_Click);
            // 
            // FormAddStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 159);
            this.Controls.Add(this.buttonNextAddIngr);
            this.Controls.Add(this.buttonNewStep);
            this.Controls.Add(this.textBoxDiscriptionStep);
            this.Controls.Add(this.textBoxStepNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddStep";
            this.Text = "FormAddStep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStepNum;
        private System.Windows.Forms.TextBox textBoxDiscriptionStep;
        private System.Windows.Forms.Button buttonNewStep;
        private System.Windows.Forms.Button buttonNextAddIngr;
    }
}