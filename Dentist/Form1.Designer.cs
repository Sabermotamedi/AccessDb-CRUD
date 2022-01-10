namespace Dentist
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDropBoxBackup = new System.Windows.Forms.Button();
            this.BackUpBtn = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خذفپروندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.شروعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeXSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پذیرشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتپروندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفپروندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAvailableNumbers = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.cntxMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDropBoxBackup);
            this.panel1.Controls.Add(this.BackUpBtn);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnDropBoxBackup
            // 
            this.btnDropBoxBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropBoxBackup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDropBoxBackup.FlatAppearance.BorderSize = 2;
            this.btnDropBoxBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDropBoxBackup.Location = new System.Drawing.Point(126, 9);
            this.btnDropBoxBackup.Name = "btnDropBoxBackup";
            this.btnDropBoxBackup.Size = new System.Drawing.Size(122, 33);
            this.btnDropBoxBackup.TabIndex = 5;
            this.btnDropBoxBackup.Text = "تهیه فایل پشتیبان امن";
            this.btnDropBoxBackup.UseVisualStyleBackColor = true;
            this.btnDropBoxBackup.Click += new System.EventHandler(this.btnDropBoxBackup_Click);
            // 
            // BackUpBtn
            // 
            this.BackUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BackUpBtn.FlatAppearance.BorderSize = 2;
            this.BackUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BackUpBtn.Location = new System.Drawing.Point(12, 9);
            this.BackUpBtn.Name = "BackUpBtn";
            this.BackUpBtn.Size = new System.Drawing.Size(108, 33);
            this.BackUpBtn.TabIndex = 4;
            this.BackUpBtn.Text = "تهیه فایل پشتیبان";
            this.BackUpBtn.UseVisualStyleBackColor = true;
            this.BackUpBtn.Click += new System.EventHandler(this.BackUpBtn_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear.FlatAppearance.BorderSize = 2;
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(653, 9);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(108, 33);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "بازگشت";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(767, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(881, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1089, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.cntxMenu;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv.Location = new System.Drawing.Point(0, 78);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1143, 523);
            this.dgv.TabIndex = 2;
            this.dgv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            // 
            // cntxMenu
            // 
            this.cntxMenu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeToolStripMenuItem,
            this.خذفپروندهToolStripMenuItem});
            this.cntxMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.cntxMenu.Name = "cntxMenu";
            this.cntxMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cntxMenu.Size = new System.Drawing.Size(136, 48);
            // 
            // editeToolStripMenuItem
            // 
            this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            this.editeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editeToolStripMenuItem.Text = "اصلاح پرونده";
            this.editeToolStripMenuItem.Click += new System.EventHandler(this.editeToolStripMenuItem_Click);
            // 
            // خذفپروندهToolStripMenuItem
            // 
            this.خذفپروندهToolStripMenuItem.Name = "خذفپروندهToolStripMenuItem";
            this.خذفپروندهToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.خذفپروندهToolStripMenuItem.Text = "خذف پرونده";
            this.خذفپروندهToolStripMenuItem.Click += new System.EventHandler(this.خذفپروندهToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.شروعToolStripMenuItem,
            this.پذیرشToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // شروعToolStripMenuItem
            // 
            this.شروعToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem,
            this.makeXSDToolStripMenuItem});
            this.شروعToolStripMenuItem.Name = "شروعToolStripMenuItem";
            this.شروعToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.شروعToolStripMenuItem.Text = "سامانه";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // makeXSDToolStripMenuItem
            // 
            this.makeXSDToolStripMenuItem.Name = "makeXSDToolStripMenuItem";
            this.makeXSDToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.makeXSDToolStripMenuItem.Text = "ارتباط با پشتیبانی";
            this.makeXSDToolStripMenuItem.Click += new System.EventHandler(this.makeXSDToolStripMenuItem_Click);
            // 
            // پذیرشToolStripMenuItem
            // 
            this.پذیرشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتپروندهToolStripMenuItem,
            this.حذفپروندهToolStripMenuItem});
            this.پذیرشToolStripMenuItem.Name = "پذیرشToolStripMenuItem";
            this.پذیرشToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.پذیرشToolStripMenuItem.Text = "پرونده";
            // 
            // ثبتپروندهToolStripMenuItem
            // 
            this.ثبتپروندهToolStripMenuItem.Name = "ثبتپروندهToolStripMenuItem";
            this.ثبتپروندهToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ثبتپروندهToolStripMenuItem.Text = "ثبت پرونده...";
            this.ثبتپروندهToolStripMenuItem.Click += new System.EventHandler(this.ثبتپروندهToolStripMenuItem_Click);
            // 
            // حذفپروندهToolStripMenuItem
            // 
            this.حذفپروندهToolStripMenuItem.Name = "حذفپروندهToolStripMenuItem";
            this.حذفپروندهToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.حذفپروندهToolStripMenuItem.Text = "حذف پرونده";
            this.حذفپروندهToolStripMenuItem.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAvailableNumbers,
            this.toolStripStatusLabel3,
            this.lblClock,
            this.toolStripStatusLabel1,
            this.lblUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1143, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblAvailableNumbers
            // 
            this.lblAvailableNumbers.ForeColor = System.Drawing.Color.DimGray;
            this.lblAvailableNumbers.Name = "lblAvailableNumbers";
            this.lblAvailableNumbers.Size = new System.Drawing.Size(112, 17);
            this.lblAvailableNumbers.Text = "lblAvailableNumbers";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // lblClock
            // 
            this.lblClock.ForeColor = System.Drawing.Color.DimGray;
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(42, 17);
            this.lblClock.Text = "lbltime";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.Text = "lblUser";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 623);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سامانه مدیریت مراجعین دکتر قائمی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.cntxMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip cntxMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem شروعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblAvailableNumbers;
        private System.Windows.Forms.ToolStripMenuItem makeXSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripMenuItem پذیرشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتپروندهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفپروندهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button BackUpBtn;
        private System.Windows.Forms.ToolStripStatusLabel lblClock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnDropBoxBackup;
        private System.Windows.Forms.ToolStripMenuItem خذفپروندهToolStripMenuItem;
    }
}

