namespace LibrarySystem
{
    partial class frmReturned
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
            this.components = new System.ComponentModel.Container();
            this.check_due = new System.Windows.Forms.Timer(this.components);
            this.TabControl3 = new System.Windows.Forms.TabControl();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchPborrower = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.dtg_RlistReturn = new System.Windows.Forms.DataGridView();
            this.grp_Rgroup = new System.Windows.Forms.GroupBox();
            this.txtRname = new System.Windows.Forms.TextBox();
            this.cboRborrowerId = new System.Windows.Forms.TextBox();
            this.txtRbookTitle = new System.Windows.Forms.TextBox();
            this.txtRauthor = new System.Windows.Forms.TextBox();
            this.txtRdescription = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_accessionNo = new System.Windows.Forms.Label();
            this.lbl_transid = new System.Windows.Forms.Label();
            this.lbl_borrowerId = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_Rduedate = new System.Windows.Forms.Label();
            this.lbl_rpayments = new System.Windows.Forms.Label();
            this.lbl_Rchange = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txt_RtenAmount = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.txtRCopyBorrowed = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtRRqty = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btn_Rsave = new System.Windows.Forms.Button();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtrbooksSearch = new System.Windows.Forms.TextBox();
            this.dtgListreturned = new System.Windows.Forms.DataGridView();
            this.TabControl3.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RlistReturn)).BeginInit();
            this.grp_Rgroup.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListreturned)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl3
            // 
            this.TabControl3.Controls.Add(this.TabPage5);
            this.TabControl3.Controls.Add(this.TabPage6);
            this.TabControl3.Location = new System.Drawing.Point(16, 15);
            this.TabControl3.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl3.Name = "TabControl3";
            this.TabControl3.SelectedIndex = 0;
            this.TabControl3.Size = new System.Drawing.Size(1085, 592);
            this.TabControl3.TabIndex = 6;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.GroupBox3);
            this.TabPage5.Controls.Add(this.grp_Rgroup);
            this.TabPage5.Controls.Add(this.btnClose);
            this.TabPage5.Controls.Add(this.btnNew);
            this.TabPage5.Controls.Add(this.btn_Rsave);
            this.TabPage5.Location = new System.Drawing.Point(4, 25);
            this.TabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage5.Size = new System.Drawing.Size(1077, 563);
            this.TabPage5.TabIndex = 0;
            this.TabPage5.Text = "Unreturn Books";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtSearchPborrower);
            this.GroupBox3.Controls.Add(this.Label27);
            this.GroupBox3.Controls.Add(this.dtg_RlistReturn);
            this.GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(8, 7);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(515, 545);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Chưa trả sách";
            // 
            // txtSearchPborrower
            // 
            this.txtSearchPborrower.Location = new System.Drawing.Point(156, 30);
            this.txtSearchPborrower.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPborrower.Name = "txtSearchPborrower";
            this.txtSearchPborrower.Size = new System.Drawing.Size(349, 29);
            this.txtSearchPborrower.TabIndex = 0;
            this.txtSearchPborrower.TextChanged += new System.EventHandler(this.txtSearchPborrower_TextChanged);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(36, 33);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(97, 23);
            this.Label27.TabIndex = 24;
            this.Label27.Text = "ID độc giả :";
            // 
            // dtg_RlistReturn
            // 
            this.dtg_RlistReturn.AllowUserToAddRows = false;
            this.dtg_RlistReturn.AllowUserToDeleteRows = false;
            this.dtg_RlistReturn.AllowUserToResizeColumns = false;
            this.dtg_RlistReturn.AllowUserToResizeRows = false;
            this.dtg_RlistReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_RlistReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_RlistReturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_RlistReturn.Location = new System.Drawing.Point(8, 68);
            this.dtg_RlistReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_RlistReturn.MultiSelect = false;
            this.dtg_RlistReturn.Name = "dtg_RlistReturn";
            this.dtg_RlistReturn.RowHeadersVisible = false;
            this.dtg_RlistReturn.RowHeadersWidth = 51;
            this.dtg_RlistReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_RlistReturn.Size = new System.Drawing.Size(499, 470);
            this.dtg_RlistReturn.TabIndex = 0;
            this.dtg_RlistReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_RlistReturn_CellClick);
            // 
            // grp_Rgroup
            // 
            this.grp_Rgroup.Controls.Add(this.txtRname);
            this.grp_Rgroup.Controls.Add(this.cboRborrowerId);
            this.grp_Rgroup.Controls.Add(this.txtRbookTitle);
            this.grp_Rgroup.Controls.Add(this.txtRauthor);
            this.grp_Rgroup.Controls.Add(this.txtRdescription);
            this.grp_Rgroup.Controls.Add(this.GroupBox2);
            this.grp_Rgroup.Controls.Add(this.Label18);
            this.grp_Rgroup.Controls.Add(this.Label9);
            this.grp_Rgroup.Controls.Add(this.Label3);
            this.grp_Rgroup.Controls.Add(this.Label8);
            this.grp_Rgroup.Controls.Add(this.GroupBox5);
            this.grp_Rgroup.Controls.Add(this.txtRCopyBorrowed);
            this.grp_Rgroup.Controls.Add(this.Label14);
            this.grp_Rgroup.Controls.Add(this.Label11);
            this.grp_Rgroup.Controls.Add(this.txtRRqty);
            this.grp_Rgroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Rgroup.Location = new System.Drawing.Point(531, 21);
            this.grp_Rgroup.Margin = new System.Windows.Forms.Padding(4);
            this.grp_Rgroup.Name = "grp_Rgroup";
            this.grp_Rgroup.Padding = new System.Windows.Forms.Padding(4);
            this.grp_Rgroup.Size = new System.Drawing.Size(517, 423);
            this.grp_Rgroup.TabIndex = 2;
            this.grp_Rgroup.TabStop = false;
            this.grp_Rgroup.Text = "Trả";
            // 
            // txtRname
            // 
            this.txtRname.Enabled = false;
            this.txtRname.Location = new System.Drawing.Point(35, 80);
            this.txtRname.Margin = new System.Windows.Forms.Padding(4);
            this.txtRname.Name = "txtRname";
            this.txtRname.Size = new System.Drawing.Size(440, 29);
            this.txtRname.TabIndex = 2;
            // 
            // cboRborrowerId
            // 
            this.cboRborrowerId.Enabled = false;
            this.cboRborrowerId.Location = new System.Drawing.Point(138, 80);
            this.cboRborrowerId.Margin = new System.Windows.Forms.Padding(4);
            this.cboRborrowerId.Name = "cboRborrowerId";
            this.cboRborrowerId.Size = new System.Drawing.Size(335, 29);
            this.cboRborrowerId.TabIndex = 1;
            // 
            // txtRbookTitle
            // 
            this.txtRbookTitle.Enabled = false;
            this.txtRbookTitle.Location = new System.Drawing.Point(35, 139);
            this.txtRbookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtRbookTitle.Name = "txtRbookTitle";
            this.txtRbookTitle.Size = new System.Drawing.Size(440, 29);
            this.txtRbookTitle.TabIndex = 3;
            // 
            // txtRauthor
            // 
            this.txtRauthor.Enabled = false;
            this.txtRauthor.Location = new System.Drawing.Point(35, 197);
            this.txtRauthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtRauthor.Name = "txtRauthor";
            this.txtRauthor.Size = new System.Drawing.Size(440, 29);
            this.txtRauthor.TabIndex = 4;
            // 
            // txtRdescription
            // 
            this.txtRdescription.Enabled = false;
            this.txtRdescription.Location = new System.Drawing.Point(33, 256);
            this.txtRdescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtRdescription.Multiline = true;
            this.txtRdescription.Name = "txtRdescription";
            this.txtRdescription.Size = new System.Drawing.Size(440, 150);
            this.txtRdescription.TabIndex = 5;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lbl_accessionNo);
            this.GroupBox2.Controls.Add(this.lbl_transid);
            this.GroupBox2.Controls.Add(this.lbl_borrowerId);
            this.GroupBox2.Location = new System.Drawing.Point(687, 143);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(33, 12);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ID\'s Secret";
            // 
            // lbl_accessionNo
            // 
            this.lbl_accessionNo.AutoSize = true;
            this.lbl_accessionNo.Location = new System.Drawing.Point(75, 52);
            this.lbl_accessionNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accessionNo.Name = "lbl_accessionNo";
            this.lbl_accessionNo.Size = new System.Drawing.Size(113, 23);
            this.lbl_accessionNo.TabIndex = 5;
            this.lbl_accessionNo.Text = "Accession #  :";
            // 
            // lbl_transid
            // 
            this.lbl_transid.AutoSize = true;
            this.lbl_transid.Location = new System.Drawing.Point(79, 73);
            this.lbl_transid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_transid.Name = "lbl_transid";
            this.lbl_transid.Size = new System.Drawing.Size(62, 23);
            this.lbl_transid.TabIndex = 24;
            this.lbl_transid.Text = "transid";
            // 
            // lbl_borrowerId
            // 
            this.lbl_borrowerId.AutoSize = true;
            this.lbl_borrowerId.Location = new System.Drawing.Point(75, 31);
            this.lbl_borrowerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_borrowerId.Name = "lbl_borrowerId";
            this.lbl_borrowerId.Size = new System.Drawing.Size(98, 23);
            this.lbl_borrowerId.TabIndex = 21;
            this.lbl_borrowerId.Text = "borrower id";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(31, 54);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(106, 23);
            this.Label18.TabIndex = 19;
            this.Label18.Text = "Tên độc giả :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(31, 231);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(64, 23);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "Mô tả :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 172);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(101, 23);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Tên tác giả :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(31, 113);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(122, 23);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Tên tác phẩm :";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.lbl_Rduedate);
            this.GroupBox5.Controls.Add(this.lbl_rpayments);
            this.GroupBox5.Controls.Add(this.lbl_Rchange);
            this.GroupBox5.Controls.Add(this.Label24);
            this.GroupBox5.Controls.Add(this.Label23);
            this.GroupBox5.Controls.Add(this.txt_RtenAmount);
            this.GroupBox5.Controls.Add(this.Label22);
            this.GroupBox5.Controls.Add(this.Label21);
            this.GroupBox5.Location = new System.Drawing.Point(675, 177);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox5.Size = new System.Drawing.Size(60, 31);
            this.GroupBox5.TabIndex = 4;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "do not touch.Time and Days for the future used. ";
            // 
            // lbl_Rduedate
            // 
            this.lbl_Rduedate.AutoSize = true;
            this.lbl_Rduedate.Location = new System.Drawing.Point(95, 32);
            this.lbl_Rduedate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rduedate.Name = "lbl_Rduedate";
            this.lbl_Rduedate.Size = new System.Drawing.Size(68, 23);
            this.lbl_Rduedate.TabIndex = 7;
            this.lbl_Rduedate.Text = "Label25";
            // 
            // lbl_rpayments
            // 
            this.lbl_rpayments.AutoSize = true;
            this.lbl_rpayments.Location = new System.Drawing.Point(95, 64);
            this.lbl_rpayments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rpayments.Name = "lbl_rpayments";
            this.lbl_rpayments.Size = new System.Drawing.Size(68, 23);
            this.lbl_rpayments.TabIndex = 4;
            this.lbl_rpayments.Text = "Label25";
            // 
            // lbl_Rchange
            // 
            this.lbl_Rchange.AutoSize = true;
            this.lbl_Rchange.Location = new System.Drawing.Point(100, 150);
            this.lbl_Rchange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rchange.Name = "lbl_Rchange";
            this.lbl_Rchange.Size = new System.Drawing.Size(68, 23);
            this.lbl_Rchange.TabIndex = 6;
            this.lbl_Rchange.Text = "Label26";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(20, 150);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(78, 23);
            this.Label24.TabIndex = 5;
            this.Label24.Text = "Change :";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(8, 107);
            this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(156, 23);
            this.Label23.TabIndex = 3;
            this.Label23.Text = "Tendered Amount :";
            // 
            // txt_RtenAmount
            // 
            this.txt_RtenAmount.Location = new System.Drawing.Point(176, 103);
            this.txt_RtenAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RtenAmount.Name = "txt_RtenAmount";
            this.txt_RtenAmount.Size = new System.Drawing.Size(235, 29);
            this.txt_RtenAmount.TabIndex = 2;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(8, 64);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(92, 23);
            this.Label22.TabIndex = 1;
            this.Label22.Text = "Payments :";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(8, 32);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(91, 23);
            this.Label21.TabIndex = 0;
            this.Label21.Text = "Over Due :";
            // 
            // txtRCopyBorrowed
            // 
            this.txtRCopyBorrowed.Enabled = false;
            this.txtRCopyBorrowed.Location = new System.Drawing.Point(35, 313);
            this.txtRCopyBorrowed.Margin = new System.Windows.Forms.Padding(4);
            this.txtRCopyBorrowed.Name = "txtRCopyBorrowed";
            this.txtRCopyBorrowed.Size = new System.Drawing.Size(195, 29);
            this.txtRCopyBorrowed.TabIndex = 27;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(252, 260);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(102, 23);
            this.Label14.TabIndex = 11;
            this.Label14.Text = "Return Qty :";
            this.Label14.Visible = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(29, 292);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(200, 23);
            this.Label11.TabIndex = 10;
            this.Label11.Text = "No. of Copies Borrowed :";
            // 
            // txtRRqty
            // 
            this.txtRRqty.Location = new System.Drawing.Point(256, 284);
            this.txtRRqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtRRqty.Name = "txtRRqty";
            this.txtRRqty.Size = new System.Drawing.Size(149, 29);
            this.txtRRqty.TabIndex = 8;
            this.txtRRqty.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Info;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(868, 463);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Info;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(696, 463);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(164, 46);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn_Rsave
            // 
            this.btn_Rsave.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Rsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rsave.Location = new System.Drawing.Point(531, 463);
            this.btn_Rsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Rsave.Name = "btn_Rsave";
            this.btn_Rsave.Size = new System.Drawing.Size(157, 46);
            this.btn_Rsave.TabIndex = 6;
            this.btn_Rsave.Text = "Hoàn thành";
            this.btn_Rsave.UseVisualStyleBackColor = false;
            this.btn_Rsave.Click += new System.EventHandler(this.btn_Rsave_Click);
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.Label4);
            this.TabPage6.Controls.Add(this.txtrbooksSearch);
            this.TabPage6.Controls.Add(this.dtgListreturned);
            this.TabPage6.Location = new System.Drawing.Point(4, 25);
            this.TabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage6.Size = new System.Drawing.Size(1077, 563);
            this.TabPage6.TabIndex = 1;
            this.TabPage6.Text = "Returned Books";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label4.Location = new System.Drawing.Point(564, 526);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 23);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Tìm kiếm :";
            // 
            // txtrbooksSearch
            // 
            this.txtrbooksSearch.BackColor = System.Drawing.Color.White;
            this.txtrbooksSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrbooksSearch.Location = new System.Drawing.Point(673, 516);
            this.txtrbooksSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtrbooksSearch.Name = "txtrbooksSearch";
            this.txtrbooksSearch.Size = new System.Drawing.Size(392, 36);
            this.txtrbooksSearch.TabIndex = 1;
            this.txtrbooksSearch.TextChanged += new System.EventHandler(this.txtrbooksSearch_TextChanged);
            // 
            // dtgListreturned
            // 
            this.dtgListreturned.AllowUserToAddRows = false;
            this.dtgListreturned.AllowUserToDeleteRows = false;
            this.dtgListreturned.AllowUserToResizeColumns = false;
            this.dtgListreturned.AllowUserToResizeRows = false;
            this.dtgListreturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgListreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListreturned.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgListreturned.Location = new System.Drawing.Point(8, 7);
            this.dtgListreturned.Margin = new System.Windows.Forms.Padding(4);
            this.dtgListreturned.Name = "dtgListreturned";
            this.dtgListreturned.RowHeadersVisible = false;
            this.dtgListreturned.RowHeadersWidth = 51;
            this.dtgListreturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListreturned.Size = new System.Drawing.Size(1059, 501);
            this.dtgListreturned.TabIndex = 0;
            // 
            // frmReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1108, 622);
            this.Controls.Add(this.TabControl3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReturned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returned";
            this.Load += new System.EventHandler(this.frmReturned_Load);
            this.TabControl3.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RlistReturn)).EndInit();
            this.grp_Rgroup.ResumeLayout(false);
            this.grp_Rgroup.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListreturned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer check_due;
        internal System.Windows.Forms.TabControl TabControl3;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtSearchPborrower;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.DataGridView dtg_RlistReturn;
        internal System.Windows.Forms.GroupBox grp_Rgroup;
        internal System.Windows.Forms.TextBox txtRname;
        internal System.Windows.Forms.TextBox txtRbookTitle;
        internal System.Windows.Forms.TextBox txtRauthor;
        internal System.Windows.Forms.TextBox txtRdescription;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lbl_accessionNo;
        internal System.Windows.Forms.Label lbl_transid;
        internal System.Windows.Forms.Label lbl_borrowerId;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label lbl_Rduedate;
        internal System.Windows.Forms.Label lbl_rpayments;
        internal System.Windows.Forms.Label lbl_Rchange;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txt_RtenAmount;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox txtRCopyBorrowed;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtRRqty;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btn_Rsave;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtrbooksSearch;
        internal System.Windows.Forms.DataGridView dtgListreturned;
        internal System.Windows.Forms.TextBox cboRborrowerId;
    }
}