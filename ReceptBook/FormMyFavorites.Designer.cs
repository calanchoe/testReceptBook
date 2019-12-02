namespace ReceptBook
{
    partial class FormMyFavorites
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
            this.dataGridViewFavRecept = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavRecept)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список рецептів, що вам сподобалися";
            // 
            // dataGridViewFavRecept
            // 
            this.dataGridViewFavRecept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewFavRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavRecept.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewFavRecept.Name = "dataGridViewFavRecept";
            this.dataGridViewFavRecept.Size = new System.Drawing.Size(599, 373);
            this.dataGridViewFavRecept.TabIndex = 1;
            this.dataGridViewFavRecept.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFavRecept_CellDoubleClick);
            // 
            // FormMyFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.dataGridViewFavRecept);
            this.Controls.Add(this.label1);
            this.Name = "FormMyFavorites";
            this.Text = "FormMyFavorites";
            this.Load += new System.EventHandler(this.FormMyFavorites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavRecept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFavRecept;
    }
}