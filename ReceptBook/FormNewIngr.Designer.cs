namespace ReceptBook
{
    partial class FormNewIngr
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
            this.dataGridViewAllIngr = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameIngr = new System.Windows.Forms.TextBox();
            this.buttonNewIngr = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxIngrCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllIngr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список існуючих інгредієнтів";
            // 
            // dataGridViewAllIngr
            // 
            this.dataGridViewAllIngr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllIngr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllIngr.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewAllIngr.Name = "dataGridViewAllIngr";
            this.dataGridViewAllIngr.Size = new System.Drawing.Size(288, 175);
            this.dataGridViewAllIngr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сворення інгредієнту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Назва інгредієнту";
            // 
            // textBoxNameIngr
            // 
            this.textBoxNameIngr.Location = new System.Drawing.Point(30, 312);
            this.textBoxNameIngr.Name = "textBoxNameIngr";
            this.textBoxNameIngr.Size = new System.Drawing.Size(244, 20);
            this.textBoxNameIngr.TabIndex = 4;
            // 
            // buttonNewIngr
            // 
            this.buttonNewIngr.BackColor = System.Drawing.Color.Khaki;
            this.buttonNewIngr.Location = new System.Drawing.Point(33, 408);
            this.buttonNewIngr.Name = "buttonNewIngr";
            this.buttonNewIngr.Size = new System.Drawing.Size(117, 23);
            this.buttonNewIngr.TabIndex = 5;
            this.buttonNewIngr.Text = "Створити";
            this.buttonNewIngr.UseVisualStyleBackColor = false;
            this.buttonNewIngr.Click += new System.EventHandler(this.buttonNewIngr_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Next->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(33, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Створення рецепту: крок 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Категорія інгредіенту:";
            // 
            // comboBoxIngrCategory
            // 
            this.comboBoxIngrCategory.FormattingEnabled = true;
            this.comboBoxIngrCategory.Location = new System.Drawing.Point(30, 363);
            this.comboBoxIngrCategory.Name = "comboBoxIngrCategory";
            this.comboBoxIngrCategory.Size = new System.Drawing.Size(244, 21);
            this.comboBoxIngrCategory.TabIndex = 9;
            // 
            // FormNewIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.comboBoxIngrCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNewIngr);
            this.Controls.Add(this.textBoxNameIngr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAllIngr);
            this.Controls.Add(this.label1);
            this.Name = "FormNewIngr";
            this.Text = "Інгредієнти";
            this.Load += new System.EventHandler(this.FormNewIngr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllIngr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAllIngr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameIngr;
        private System.Windows.Forms.Button buttonNewIngr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxIngrCategory;
    }
}