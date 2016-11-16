namespace CopyAviziaUsers
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
            this.btnGetMisingGroups = new System.Windows.Forms.Button();
            this.btnLoadMissingUsers = new System.Windows.Forms.Button();
            this.gvMissingUsers = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalUsersTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDbTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDbFromCon = new System.Windows.Forms.TextBox();
            this.txtTotalUsersFrom = new System.Windows.Forms.TextBox();
            this.txtTotalGroupsFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalGroupsTo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gvMissingGroups = new System.Windows.Forms.DataGridView();
            this.btnCopyGroup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalMissingGroups = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMissingUsersCount = new System.Windows.Forms.Label();
            this.btnCopyUsers = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMissingUsers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMissingGroups)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetMisingGroups
            // 
            this.btnGetMisingGroups.Location = new System.Drawing.Point(3, 3);
            this.btnGetMisingGroups.Name = "btnGetMisingGroups";
            this.btnGetMisingGroups.Size = new System.Drawing.Size(229, 24);
            this.btnGetMisingGroups.TabIndex = 0;
            this.btnGetMisingGroups.Text = "Load Missing Groups from (TO) database";
            this.btnGetMisingGroups.UseVisualStyleBackColor = true;
            this.btnGetMisingGroups.Click += new System.EventHandler(this.btnGetMisingGroups_Click);
            // 
            // btnLoadMissingUsers
            // 
            this.btnLoadMissingUsers.Location = new System.Drawing.Point(3, 3);
            this.btnLoadMissingUsers.Name = "btnLoadMissingUsers";
            this.btnLoadMissingUsers.Size = new System.Drawing.Size(229, 24);
            this.btnLoadMissingUsers.TabIndex = 2;
            this.btnLoadMissingUsers.Text = "Load Missing Users from (TO) database";
            this.btnLoadMissingUsers.UseVisualStyleBackColor = true;
            this.btnLoadMissingUsers.Click += new System.EventHandler(this.btnLoadMissingUsers_Click);
            // 
            // gvMissingUsers
            // 
            this.gvMissingUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMissingUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnCopyUsers});
            this.gvMissingUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMissingUsers.Location = new System.Drawing.Point(3, 354);
            this.gvMissingUsers.Name = "gvMissingUsers";
            this.gvMissingUsers.Size = new System.Drawing.Size(1290, 229);
            this.gvMissingUsers.TabIndex = 3;
            this.gvMissingUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMissingUsers_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.txtTotalUsersTo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDbTo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDbFromCon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalUsersFrom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalGroupsFrom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalGroupsTo, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 93);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtTotalUsersTo
            // 
            this.txtTotalUsersTo.BackColor = System.Drawing.Color.White;
            this.txtTotalUsersTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalUsersTo.Location = new System.Drawing.Point(779, 58);
            this.txtTotalUsersTo.Name = "txtTotalUsersTo";
            this.txtTotalUsersTo.ReadOnly = true;
            this.txtTotalUsersTo.Size = new System.Drawing.Size(514, 20);
            this.txtTotalUsersTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(650, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Staff Users";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Staff Users";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDbTo
            // 
            this.txtDbTo.BackColor = System.Drawing.Color.White;
            this.txtDbTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDbTo.Location = new System.Drawing.Point(779, 3);
            this.txtDbTo.Multiline = true;
            this.txtDbTo.Name = "txtDbTo";
            this.txtDbTo.ReadOnly = true;
            this.txtDbTo.Size = new System.Drawing.Size(514, 49);
            this.txtDbTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(650, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Db To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Groups";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Db From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDbFromCon
            // 
            this.txtDbFromCon.BackColor = System.Drawing.Color.White;
            this.txtDbFromCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDbFromCon.Location = new System.Drawing.Point(132, 3);
            this.txtDbFromCon.Multiline = true;
            this.txtDbFromCon.Name = "txtDbFromCon";
            this.txtDbFromCon.ReadOnly = true;
            this.txtDbFromCon.Size = new System.Drawing.Size(512, 49);
            this.txtDbFromCon.TabIndex = 1;
            // 
            // txtTotalUsersFrom
            // 
            this.txtTotalUsersFrom.BackColor = System.Drawing.Color.White;
            this.txtTotalUsersFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalUsersFrom.Location = new System.Drawing.Point(132, 58);
            this.txtTotalUsersFrom.Name = "txtTotalUsersFrom";
            this.txtTotalUsersFrom.ReadOnly = true;
            this.txtTotalUsersFrom.Size = new System.Drawing.Size(512, 20);
            this.txtTotalUsersFrom.TabIndex = 5;
            // 
            // txtTotalGroupsFrom
            // 
            this.txtTotalGroupsFrom.BackColor = System.Drawing.Color.White;
            this.txtTotalGroupsFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalGroupsFrom.Location = new System.Drawing.Point(132, 76);
            this.txtTotalGroupsFrom.Name = "txtTotalGroupsFrom";
            this.txtTotalGroupsFrom.ReadOnly = true;
            this.txtTotalGroupsFrom.Size = new System.Drawing.Size(512, 20);
            this.txtTotalGroupsFrom.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(650, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Groups";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalGroupsTo
            // 
            this.txtTotalGroupsTo.BackColor = System.Drawing.Color.White;
            this.txtTotalGroupsTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalGroupsTo.Location = new System.Drawing.Point(779, 76);
            this.txtTotalGroupsTo.Name = "txtTotalGroupsTo";
            this.txtTotalGroupsTo.ReadOnly = true;
            this.txtTotalGroupsTo.Size = new System.Drawing.Size(514, 20);
            this.txtTotalGroupsTo.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gvMissingGroups, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gvMissingUsers, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1296, 586);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // gvMissingGroups
            // 
            this.gvMissingGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMissingGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnCopyGroup});
            this.gvMissingGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMissingGroups.Location = new System.Drawing.Point(3, 60);
            this.gvMissingGroups.Name = "gvMissingGroups";
            this.gvMissingGroups.Size = new System.Drawing.Size(1290, 228);
            this.gvMissingGroups.TabIndex = 2;
            this.gvMissingGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMissingGroups_CellContentClick);
            // 
            // btnCopyGroup
            // 
            this.btnCopyGroup.HeaderText = "CopyGroup";
            this.btnCopyGroup.Name = "btnCopyGroup";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 930F));
            this.tableLayoutPanel3.Controls.Add(this.btnGetMisingGroups, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTotalMissingGroups, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1290, 31);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblTotalMissingGroups
            // 
            this.lblTotalMissingGroups.AutoSize = true;
            this.lblTotalMissingGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMissingGroups.ForeColor = System.Drawing.Color.Red;
            this.lblTotalMissingGroups.Location = new System.Drawing.Point(238, 0);
            this.lblTotalMissingGroups.Name = "lblTotalMissingGroups";
            this.lblTotalMissingGroups.Size = new System.Drawing.Size(116, 31);
            this.lblTotalMissingGroups.TabIndex = 1;
            this.lblTotalMissingGroups.Text = "Missing Groups Count :";
            this.lblTotalMissingGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblMissingUsersCount, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLoadMissingUsers, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 314);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1290, 34);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // lblMissingUsersCount
            // 
            this.lblMissingUsersCount.AutoSize = true;
            this.lblMissingUsersCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMissingUsersCount.ForeColor = System.Drawing.Color.Red;
            this.lblMissingUsersCount.Location = new System.Drawing.Point(238, 0);
            this.lblMissingUsersCount.Name = "lblMissingUsersCount";
            this.lblMissingUsersCount.Size = new System.Drawing.Size(109, 34);
            this.lblMissingUsersCount.TabIndex = 3;
            this.lblMissingUsersCount.Text = "Missing Users Count :";
            this.lblMissingUsersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopyUsers
            // 
            this.btnCopyUsers.HeaderText = "Copy User";
            this.btnCopyUsers.Name = "btnCopyUsers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 679);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMissingUsers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMissingGroups)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetMisingGroups;
        private System.Windows.Forms.Button btnLoadMissingUsers;
        private System.Windows.Forms.DataGridView gvMissingUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDbFromCon;
        private System.Windows.Forms.TextBox txtDbTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalUsersFrom;
        private System.Windows.Forms.TextBox txtTotalUsersTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalGroupsFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalGroupsTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView gvMissingGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTotalMissingGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblMissingUsersCount;
        private System.Windows.Forms.DataGridViewButtonColumn btnCopyGroup;
        private System.Windows.Forms.DataGridViewButtonColumn btnCopyUsers;
    }
}

