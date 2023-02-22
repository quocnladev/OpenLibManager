namespace LibrarySystem
{
    partial class frmBorrower
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
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtg_ABorrowLists = new System.Windows.Forms.DataGridView();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.rdio_female = new System.Windows.Forms.RadioButton();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.rch_address = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.rdio_male = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ABorrowLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Info;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(991, 296);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.SystemColors.Info;
            this.btn_last.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Location = new System.Drawing.Point(646, 349);
            this.btn_last.Margin = new System.Windows.Forms.Padding(4);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(68, 30);
            this.btn_last.TabIndex = 60;
            this.btn_last.Text = ">>|";
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.Info;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(570, 349);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(68, 30);
            this.btn_next.TabIndex = 59;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.SystemColors.Info;
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(892, 296);
            this.btn_New.Margin = new System.Windows.Forms.Padding(4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(90, 32);
            this.btn_New.TabIndex = 57;
            this.btn_New.Text = "Mới";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.SystemColors.Info;
            this.btn_first.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Location = new System.Drawing.Point(418, 349);
            this.btn_first.Margin = new System.Windows.Forms.Padding(4);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(68, 30);
            this.btn_first.TabIndex = 61;
            this.btn_first.Text = "|<<";
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Info;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(991, 254);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 32);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Info;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(893, 256);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 32);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.SystemColors.Info;
            this.btn_prev.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Location = new System.Drawing.Point(494, 349);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(68, 30);
            this.btn_prev.TabIndex = 58;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(151, 298);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(461, 29);
            this.txtContact.TabIndex = 51;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(23, 298);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(120, 23);
            this.Label7.TabIndex = 52;
            this.Label7.Text = "Số điện thoại :";
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(461, 31);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(151, 29);
            this.txtCourse.TabIndex = 50;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(361, 31);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(92, 23);
            this.Label6.TabIndex = 53;
            this.Label6.Text = "Năm sinh :";
            // 
            // dtg_ABorrowLists
            // 
            this.dtg_ABorrowLists.AllowUserToAddRows = false;
            this.dtg_ABorrowLists.AllowUserToDeleteRows = false;
            this.dtg_ABorrowLists.AllowUserToResizeColumns = false;
            this.dtg_ABorrowLists.AllowUserToResizeRows = false;
            this.dtg_ABorrowLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_ABorrowLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_ABorrowLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ABorrowLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_ABorrowLists.Location = new System.Drawing.Point(5, 387);
            this.dtg_ABorrowLists.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_ABorrowLists.Name = "dtg_ABorrowLists";
            this.dtg_ABorrowLists.RowHeadersVisible = false;
            this.dtg_ABorrowLists.RowHeadersWidth = 51;
            this.dtg_ABorrowLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ABorrowLists.Size = new System.Drawing.Size(1120, 268);
            this.dtg_ABorrowLists.TabIndex = 49;
            this.dtg_ABorrowLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ABorrowLists_CellClick);
            // 
            // txt_bid
            // 
            this.txt_bid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bid.Location = new System.Drawing.Point(151, 30);
            this.txt_bid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.Size = new System.Drawing.Size(177, 29);
            this.txt_bid.TabIndex = 35;
            this.txt_bid.TextChanged += new System.EventHandler(this.txt_bid_TextChanged);
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(151, 143);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(461, 29);
            this.txt_fname.TabIndex = 36;
            // 
            // rdio_female
            // 
            this.rdio_female.AutoSize = true;
            this.rdio_female.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdio_female.Location = new System.Drawing.Point(249, 256);
            this.rdio_female.Margin = new System.Windows.Forms.Padding(4);
            this.rdio_female.Name = "rdio_female";
            this.rdio_female.Size = new System.Drawing.Size(54, 27);
            this.rdio_female.TabIndex = 47;
            this.rdio_female.TabStop = true;
            this.rdio_female.Text = "Nữ";
            this.rdio_female.UseVisualStyleBackColor = true;
            // 
            // txt_mname
            // 
            this.txt_mname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mname.Location = new System.Drawing.Point(151, 106);
            this.txt_mname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(461, 29);
            this.txt_mname.TabIndex = 38;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(46, 33);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(97, 23);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "ID độc giả :";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(151, 71);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(461, 29);
            this.txt_lname.TabIndex = 37;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(98, 143);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 23);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Tên :";
            // 
            // rch_address
            // 
            this.rch_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_address.Location = new System.Drawing.Point(151, 176);
            this.rch_address.Margin = new System.Windows.Forms.Padding(4);
            this.rch_address.Name = "rch_address";
            this.rch_address.Size = new System.Drawing.Size(461, 70);
            this.rch_address.TabIndex = 43;
            this.rch_address.Text = "";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(102, 74);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 23);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "Họ :";
            // 
            // rdio_male
            // 
            this.rdio_male.AutoSize = true;
            this.rdio_male.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdio_male.Location = new System.Drawing.Point(151, 256);
            this.rdio_male.Margin = new System.Windows.Forms.Padding(4);
            this.rdio_male.Name = "rdio_male";
            this.rdio_male.Size = new System.Drawing.Size(68, 27);
            this.rdio_male.TabIndex = 46;
            this.rdio_male.TabStop = true;
            this.rdio_male.Text = "Nam";
            this.rdio_male.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(59, 106);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(84, 23);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Tên đệm :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(77, 179);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 23);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "Địa chỉ:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(59, 256);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(84, 23);
            this.Label9.TabIndex = 39;
            this.Label9.Text = "Giới tính :";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Location = new System.Drawing.Point(725, 13);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(391, 233);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 48;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(796, 105);
            this.txtPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(277, 22);
            this.txtPhoto.TabIndex = 63;
            // 
            // frmBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1129, 657);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtg_ABorrowLists);
            this.Controls.Add(this.txt_bid);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.rdio_female);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.rch_address);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.rdio_male);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtPhoto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBorrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowers";
            this.Load += new System.EventHandler(this.frmBorrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ABorrowLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btn_last;
        internal System.Windows.Forms.Button btn_next;
        internal System.Windows.Forms.Button btn_New;
        internal System.Windows.Forms.Button btn_first;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.Button btn_prev;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtCourse;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView dtg_ABorrowLists;
        internal System.Windows.Forms.TextBox txt_bid;
        internal System.Windows.Forms.TextBox txt_fname;
        internal System.Windows.Forms.RadioButton rdio_female;
        internal System.Windows.Forms.TextBox txt_mname;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_lname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.RichTextBox rch_address;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RadioButton rdio_male;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtPhoto;
    }
}