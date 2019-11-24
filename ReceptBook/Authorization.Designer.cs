﻿namespace ReceptBook
{
    partial class Authorization
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.singinTabPage = new System.Windows.Forms.TabPage();
            this.errMessageLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.loginTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.loginTabPage);
            this.tabControl1.Controls.Add(this.singinTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // loginTabPage
            // 
            this.loginTabPage.Controls.Add(this.errMessageLabel);
            this.loginTabPage.Controls.Add(this.closeButton);
            this.loginTabPage.Controls.Add(this.loginButton);
            this.loginTabPage.Controls.Add(this.passwordTextBox);
            this.loginTabPage.Controls.Add(this.loginTextBox);
            this.loginTabPage.Controls.Add(this.label2);
            this.loginTabPage.Controls.Add(this.label1);
            this.loginTabPage.Location = new System.Drawing.Point(4, 22);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(448, 239);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Авторізація";
            this.loginTabPage.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(322, 166);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закрити";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(211, 166);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Увійти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(115, 106);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(282, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(115, 41);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(282, 20);
            this.loginTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін";
            // 
            // singinTabPage
            // 
            this.singinTabPage.Location = new System.Drawing.Point(4, 22);
            this.singinTabPage.Name = "singinTabPage";
            this.singinTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.singinTabPage.Size = new System.Drawing.Size(448, 239);
            this.singinTabPage.TabIndex = 1;
            this.singinTabPage.Text = "Реєстрація";
            this.singinTabPage.UseVisualStyleBackColor = true;
            // 
            // errMessageLabel
            // 
            this.errMessageLabel.AutoSize = true;
            this.errMessageLabel.Location = new System.Drawing.Point(112, 142);
            this.errMessageLabel.Name = "errMessageLabel";
            this.errMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.errMessageLabel.TabIndex = 6;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 265);
            this.Controls.Add(this.tabControl1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.tabControl1.ResumeLayout(false);
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loginTabPage;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage singinTabPage;
        private System.Windows.Forms.Label errMessageLabel;
    }
}