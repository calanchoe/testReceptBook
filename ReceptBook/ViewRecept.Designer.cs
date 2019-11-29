namespace ReceptBook
{
    partial class ViewRecept
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
            this.labelNameRecept = new System.Windows.Forms.Label();
            this.pictureBoxReceptMain = new System.Windows.Forms.PictureBox();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.dataGridViewStepsOfRecept = new System.Windows.Forms.DataGridView();
            this.buttonLike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewIngredientsForRecept = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCateg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceptMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStepsOfRecept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredientsForRecept)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameRecept
            // 
            this.labelNameRecept.AutoSize = true;
            this.labelNameRecept.Location = new System.Drawing.Point(322, 27);
            this.labelNameRecept.Name = "labelNameRecept";
            this.labelNameRecept.Size = new System.Drawing.Size(57, 13);
            this.labelNameRecept.TabIndex = 0;
            this.labelNameRecept.Text = "labelName";
            // 
            // pictureBoxReceptMain
            // 
            this.pictureBoxReceptMain.Location = new System.Drawing.Point(27, 54);
            this.pictureBoxReceptMain.Name = "pictureBoxReceptMain";
            this.pictureBoxReceptMain.Size = new System.Drawing.Size(100, 87);
            this.pictureBoxReceptMain.TabIndex = 1;
            this.pictureBoxReceptMain.TabStop = false;
            // 
            // labelDiscription
            // 
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Location = new System.Drawing.Point(162, 54);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(78, 13);
            this.labelDiscription.TabIndex = 2;
            this.labelDiscription.Text = "labelDiscription";
            // 
            // dataGridViewStepsOfRecept
            // 
            this.dataGridViewStepsOfRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStepsOfRecept.Location = new System.Drawing.Point(27, 366);
            this.dataGridViewStepsOfRecept.Name = "dataGridViewStepsOfRecept";
            this.dataGridViewStepsOfRecept.Size = new System.Drawing.Size(749, 217);
            this.dataGridViewStepsOfRecept.TabIndex = 3;
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(27, 589);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(166, 23);
            this.buttonLike.TabIndex = 4;
            this.buttonLike.Text = "Додати до обраного <3";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Інгредієнти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кроки";
            // 
            // dataGridViewIngredientsForRecept
            // 
            this.dataGridViewIngredientsForRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredientsForRecept.Location = new System.Drawing.Point(27, 174);
            this.dataGridViewIngredientsForRecept.Name = "dataGridViewIngredientsForRecept";
            this.dataGridViewIngredientsForRecept.Size = new System.Drawing.Size(412, 170);
            this.dataGridViewIngredientsForRecept.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Рівень важкості";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата створення";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(599, 196);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(55, 13);
            this.labelLevel.TabIndex = 10;
            this.labelLevel.Text = "labelLevel";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(585, 311);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 13);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "labelDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Час приготування";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(599, 252);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 13);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "labelTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Категорія:";
            // 
            // labelCateg
            // 
            this.labelCateg.AutoSize = true;
            this.labelCateg.Location = new System.Drawing.Point(684, 54);
            this.labelCateg.Name = "labelCateg";
            this.labelCateg.Size = new System.Drawing.Size(57, 13);
            this.labelCateg.TabIndex = 15;
            this.labelCateg.Text = "labelCateg";
            // 
            // ViewRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.labelCateg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewIngredientsForRecept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.dataGridViewStepsOfRecept);
            this.Controls.Add(this.labelDiscription);
            this.Controls.Add(this.pictureBoxReceptMain);
            this.Controls.Add(this.labelNameRecept);
            this.Name = "ViewRecept";
            this.Text = "Рецепт";
            this.Load += new System.EventHandler(this.ViewRecept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceptMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStepsOfRecept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredientsForRecept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameRecept;
        private System.Windows.Forms.PictureBox pictureBoxReceptMain;
        private System.Windows.Forms.Label labelDiscription;
        private System.Windows.Forms.DataGridView dataGridViewStepsOfRecept;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewIngredientsForRecept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCateg;
    }
}