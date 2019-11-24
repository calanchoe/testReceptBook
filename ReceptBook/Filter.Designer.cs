namespace ReceptBook
{
    partial class Filter
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
            this.comboBoxSelectCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxIngredientsOfCategory = new System.Windows.Forms.ListBox();
            this.listBoxReceptByIngredients = new System.Windows.Forms.ListBox();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.buttonDelIngredient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFindRecepts = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(69, 39);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectCategory.TabIndex = 0;
            this.comboBoxSelectCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // listBoxIngredientsOfCategory
            // 
            this.listBoxIngredientsOfCategory.FormattingEnabled = true;
            this.listBoxIngredientsOfCategory.Location = new System.Drawing.Point(16, 124);
            this.listBoxIngredientsOfCategory.Name = "listBoxIngredientsOfCategory";
            this.listBoxIngredientsOfCategory.Size = new System.Drawing.Size(120, 95);
            this.listBoxIngredientsOfCategory.TabIndex = 2;
            // 
            // listBoxReceptByIngredients
            // 
            this.listBoxReceptByIngredients.FormattingEnabled = true;
            this.listBoxReceptByIngredients.Location = new System.Drawing.Point(496, 124);
            this.listBoxReceptByIngredients.Name = "listBoxReceptByIngredients";
            this.listBoxReceptByIngredients.Size = new System.Drawing.Size(120, 95);
            this.listBoxReceptByIngredients.TabIndex = 3;
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(243, 143);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(172, 23);
            this.buttonAddIngredient.TabIndex = 4;
            this.buttonAddIngredient.Text = "Додати інгредієнт ->";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // buttonDelIngredient
            // 
            this.buttonDelIngredient.Location = new System.Drawing.Point(243, 172);
            this.buttonDelIngredient.Name = "buttonDelIngredient";
            this.buttonDelIngredient.Size = new System.Drawing.Size(172, 23);
            this.buttonDelIngredient.TabIndex = 5;
            this.buttonDelIngredient.Text = "Видалити інгредієнт зі списку";
            this.buttonDelIngredient.UseVisualStyleBackColor = true;
            this.buttonDelIngredient.Click += new System.EventHandler(this.buttonDelIngredient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // buttonFindRecepts
            // 
            this.buttonFindRecepts.Location = new System.Drawing.Point(496, 277);
            this.buttonFindRecepts.Name = "buttonFindRecepts";
            this.buttonFindRecepts.Size = new System.Drawing.Size(120, 23);
            this.buttonFindRecepts.TabIndex = 8;
            this.buttonFindRecepts.Text = "Знайти рецепти";
            this.buttonFindRecepts.UseVisualStyleBackColor = true;
            this.buttonFindRecepts.Click += new System.EventHandler(this.buttonFindRecepts_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 327);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(667, 178);
            this.dataGridView.TabIndex = 9;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 517);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonFindRecepts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelIngredient);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.listBoxReceptByIngredients);
            this.Controls.Add(this.listBoxIngredientsOfCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Filter";
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxIngredientsOfCategory;
        private System.Windows.Forms.ListBox listBoxReceptByIngredients;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.Button buttonDelIngredient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFindRecepts;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}