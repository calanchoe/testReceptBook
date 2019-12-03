namespace ReceptBook
{
    partial class FormReceptIngr
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
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddRecIngr = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxMeasure = new System.Windows.Forms.TextBox();
            this.comboBoxIngrs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Створення рецепту: крок 4 (останній)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Інгредієнти для рецепту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Обрати інгредієнт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Міра";
            // 
            // buttonAddRecIngr
            // 
            this.buttonAddRecIngr.BackColor = System.Drawing.Color.Khaki;
            this.buttonAddRecIngr.Location = new System.Drawing.Point(12, 263);
            this.buttonAddRecIngr.Name = "buttonAddRecIngr";
            this.buttonAddRecIngr.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRecIngr.TabIndex = 5;
            this.buttonAddRecIngr.Text = "Додати";
            this.buttonAddRecIngr.UseVisualStyleBackColor = false;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(333, 263);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 6;
            this.buttonFinish.Text = "Готово";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(150, 142);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(121, 20);
            this.textBoxCount.TabIndex = 7;
            // 
            // textBoxMeasure
            // 
            this.textBoxMeasure.Location = new System.Drawing.Point(150, 194);
            this.textBoxMeasure.Name = "textBoxMeasure";
            this.textBoxMeasure.Size = new System.Drawing.Size(121, 20);
            this.textBoxMeasure.TabIndex = 8;
            // 
            // comboBoxIngrs
            // 
            this.comboBoxIngrs.FormattingEnabled = true;
            this.comboBoxIngrs.Location = new System.Drawing.Point(150, 88);
            this.comboBoxIngrs.Name = "comboBoxIngrs";
            this.comboBoxIngrs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIngrs.TabIndex = 9;
            // 
            // FormReceptIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 298);
            this.Controls.Add(this.comboBoxIngrs);
            this.Controls.Add(this.textBoxMeasure);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonAddRecIngr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReceptIngr";
            this.Text = "FormReceptIngr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddRecIngr;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxMeasure;
        private System.Windows.Forms.ComboBox comboBoxIngrs;
    }
}