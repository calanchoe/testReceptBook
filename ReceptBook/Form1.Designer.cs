namespace ReceptBook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogyByReceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.dataGridViewAllRecepts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.forAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllRecepts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.myCabinetToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.CatalogyByReceptToolStripMenuItem,
            this.forAdminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.loginToolStripMenuItem.Text = "Увійти";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // myCabinetToolStripMenuItem
            // 
            this.myCabinetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoritesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.myCabinetToolStripMenuItem.Name = "myCabinetToolStripMenuItem";
            this.myCabinetToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.myCabinetToolStripMenuItem.Text = "Мій кабінет";
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.favoritesToolStripMenuItem.Text = "Обране";
            this.favoritesToolStripMenuItem.Click += new System.EventHandler(this.favoritesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Вийти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.filterToolStripMenuItem.Text = "Мій холодильник";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // CatalogyByReceptToolStripMenuItem
            // 
            this.CatalogyByReceptToolStripMenuItem.Name = "CatalogyByReceptToolStripMenuItem";
            this.CatalogyByReceptToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.CatalogyByReceptToolStripMenuItem.Text = "Категорії рецептів";
            this.CatalogyByReceptToolStripMenuItem.Click += new System.EventHandler(this.CatalogyByReceptToolStripMenuItem_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(13, 28);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(35, 13);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "label1";
            this.userNameLabel.Visible = false;
            // 
            // dataGridViewAllRecepts
            // 
            this.dataGridViewAllRecepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewAllRecepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllRecepts.Location = new System.Drawing.Point(16, 220);
            this.dataGridViewAllRecepts.Name = "dataGridViewAllRecepts";
            this.dataGridViewAllRecepts.Size = new System.Drawing.Size(772, 201);
            this.dataGridViewAllRecepts.TabIndex = 3;
            this.dataGridViewAllRecepts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllRecepts_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наші рецепти";
            // 
            // forAdminToolStripMenuItem
            // 
            this.forAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receptsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.forAdminToolStripMenuItem.Name = "forAdminToolStripMenuItem";
            this.forAdminToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.forAdminToolStripMenuItem.Text = "ForAdmin";
            // 
            // receptsToolStripMenuItem
            // 
            this.receptsToolStripMenuItem.Name = "receptsToolStripMenuItem";
            this.receptsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.receptsToolStripMenuItem.Text = "Recepts";
            this.receptsToolStripMenuItem.Click += new System.EventHandler(this.receptsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAllRecepts);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Кулінарна книга";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllRecepts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ToolStripMenuItem myCabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAllRecepts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem CatalogyByReceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}

