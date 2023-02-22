﻿namespace LibrarySystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_books = new System.Windows.Forms.ToolStripButton();
            this.ts_transaction = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_BorrowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_returnItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_borrower = new System.Windows.Forms.ToolStripButton();
            this.ts_categories = new System.Windows.Forms.ToolStripButton();
            this.ts_users = new System.Windows.Forms.ToolStripButton();
            this.ts_login = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_books,
            this.ts_transaction,
            this.ts_borrower,
            this.ts_categories,
            this.ts_users,
            this.ts_login});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1219, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_books
            // 
            this.ts_books.AutoSize = false;
            this.ts_books.Image = ((System.Drawing.Image)(resources.GetObject("ts_books.Image")));
            this.ts_books.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_books.Name = "ts_books";
            this.ts_books.Size = new System.Drawing.Size(70, 70);
            this.ts_books.Text = "Sách";
            this.ts_books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_books.Click += new System.EventHandler(this.ts_books_Click);
            // 
            // ts_transaction
            // 
            this.ts_transaction.AutoSize = false;
            this.ts_transaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_BorrowItem,
            this.ts_returnItem});
            this.ts_transaction.Image = ((System.Drawing.Image)(resources.GetObject("ts_transaction.Image")));
            this.ts_transaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_transaction.Name = "ts_transaction";
            this.ts_transaction.Size = new System.Drawing.Size(80, 70);
            this.ts_transaction.Text = "Thống kê";
            this.ts_transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ts_BorrowItem
            // 
            this.ts_BorrowItem.Name = "ts_BorrowItem";
            this.ts_BorrowItem.Size = new System.Drawing.Size(224, 26);
            this.ts_BorrowItem.Text = "DS mượn";
            this.ts_BorrowItem.Click += new System.EventHandler(this.ts_BorrowItem_Click);
            // 
            // ts_returnItem
            // 
            this.ts_returnItem.Name = "ts_returnItem";
            this.ts_returnItem.Size = new System.Drawing.Size(224, 26);
            this.ts_returnItem.Text = "DS trả";
            this.ts_returnItem.Click += new System.EventHandler(this.ts_returnItem_Click);
            // 
            // ts_borrower
            // 
            this.ts_borrower.AutoSize = false;
            this.ts_borrower.Image = ((System.Drawing.Image)(resources.GetObject("ts_borrower.Image")));
            this.ts_borrower.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_borrower.Name = "ts_borrower";
            this.ts_borrower.Size = new System.Drawing.Size(70, 70);
            this.ts_borrower.Text = "Độc giả";
            this.ts_borrower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_borrower.Click += new System.EventHandler(this.ts_borrower_Click);
            // 
            // ts_categories
            // 
            this.ts_categories.AutoSize = false;
            this.ts_categories.Image = ((System.Drawing.Image)(resources.GetObject("ts_categories.Image")));
            this.ts_categories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_categories.Name = "ts_categories";
            this.ts_categories.Size = new System.Drawing.Size(70, 70);
            this.ts_categories.Text = "Thể loại";
            this.ts_categories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_categories.Click += new System.EventHandler(this.ts_categories_Click);
            // 
            // ts_users
            // 
            this.ts_users.Image = ((System.Drawing.Image)(resources.GetObject("ts_users.Image")));
            this.ts_users.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_users.Name = "ts_users";
            this.ts_users.Size = new System.Drawing.Size(115, 74);
            this.ts_users.Text = "Quản lí nhân sự";
            this.ts_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_users.Click += new System.EventHandler(this.ts_users_Click);
            // 
            // ts_login
            // 
            this.ts_login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ts_login.AutoSize = false;
            this.ts_login.Image = global::LibrarySystem.Properties.Resources.log_open;
            this.ts_login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_login.Name = "ts_login";
            this.ts_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ts_login.Size = new System.Drawing.Size(80, 70);
            this.ts_login.Text = "Đăng nhập";
            this.ts_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_login.Click += new System.EventHandler(this.ts_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1219, 846);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 846);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_books;
        private System.Windows.Forms.ToolStripDropDownButton ts_transaction;
        private System.Windows.Forms.ToolStripMenuItem ts_BorrowItem;
        private System.Windows.Forms.ToolStripMenuItem ts_returnItem;
        private System.Windows.Forms.ToolStripButton ts_borrower;
        private System.Windows.Forms.ToolStripButton ts_categories;
        private System.Windows.Forms.ToolStripButton ts_users;
        private System.Windows.Forms.ToolStripButton ts_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

