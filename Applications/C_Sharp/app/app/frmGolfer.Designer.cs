﻿
namespace app
{
    partial class frmGolfer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetAllGolfers = new System.Windows.Forms.Button();
            this.btnAddGolfer = new System.Windows.Forms.Button();
            this.btnUpdateGolfer = new System.Windows.Forms.Button();
            this.btnDeleteGolfer = new System.Windows.Forms.Button();
            this.lstGolfers = new System.Windows.Forms.ListBox();
            this.txtGolferId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHandicap = new System.Windows.Forms.TextBox();
            this.btnGetClubType = new System.Windows.Forms.Button();
            this.btnAddClubType = new System.Windows.Forms.Button();
            this.btnUpdateClubType = new System.Windows.Forms.Button();
            this.btnDeleteClubType = new System.Windows.Forms.Button();
            this.lstClubType = new System.Windows.Forms.ListBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.txtClubUniqueId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetAllGolfers
            // 
            this.btnGetAllGolfers.Location = new System.Drawing.Point(12, 12);
            this.btnGetAllGolfers.Name = "btnGetAllGolfers";
            this.btnGetAllGolfers.Size = new System.Drawing.Size(103, 23);
            this.btnGetAllGolfers.TabIndex = 0;
            this.btnGetAllGolfers.Text = "Get All Golfers";
            this.btnGetAllGolfers.UseVisualStyleBackColor = true;
            this.btnGetAllGolfers.Click += new System.EventHandler(this.btnGetAllGolfers_Click);
            // 
            // btnAddGolfer
            // 
            this.btnAddGolfer.Location = new System.Drawing.Point(12, 70);
            this.btnAddGolfer.Name = "btnAddGolfer";
            this.btnAddGolfer.Size = new System.Drawing.Size(103, 23);
            this.btnAddGolfer.TabIndex = 2;
            this.btnAddGolfer.Text = "Add Golfer";
            this.btnAddGolfer.UseVisualStyleBackColor = true;
            this.btnAddGolfer.Click += new System.EventHandler(this.btnAddGolfer_Click);
            // 
            // btnUpdateGolfer
            // 
            this.btnUpdateGolfer.Location = new System.Drawing.Point(12, 99);
            this.btnUpdateGolfer.Name = "btnUpdateGolfer";
            this.btnUpdateGolfer.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateGolfer.TabIndex = 3;
            this.btnUpdateGolfer.Text = "Update Golfer";
            this.btnUpdateGolfer.UseVisualStyleBackColor = true;
            this.btnUpdateGolfer.Click += new System.EventHandler(this.btnUpdateGolfer_Click);
            // 
            // btnDeleteGolfer
            // 
            this.btnDeleteGolfer.Location = new System.Drawing.Point(12, 128);
            this.btnDeleteGolfer.Name = "btnDeleteGolfer";
            this.btnDeleteGolfer.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteGolfer.TabIndex = 4;
            this.btnDeleteGolfer.Text = "Delete Golfer";
            this.btnDeleteGolfer.UseVisualStyleBackColor = true;
            this.btnDeleteGolfer.Click += new System.EventHandler(this.btnDeleteGolfer_Click);
            // 
            // lstGolfers
            // 
            this.lstGolfers.FormattingEnabled = true;
            this.lstGolfers.ItemHeight = 15;
            this.lstGolfers.Location = new System.Drawing.Point(121, 12);
            this.lstGolfers.Name = "lstGolfers";
            this.lstGolfers.Size = new System.Drawing.Size(120, 139);
            this.lstGolfers.TabIndex = 6;
            this.lstGolfers.SelectedIndexChanged += new System.EventHandler(this.lstGolfers_SelectedIndexChanged);
            // 
            // txtGolferId
            // 
            this.txtGolferId.Location = new System.Drawing.Point(248, 12);
            this.txtGolferId.Name = "txtGolferId";
            this.txtGolferId.PlaceholderText = "Golfer Id";
            this.txtGolferId.Size = new System.Drawing.Size(157, 23);
            this.txtGolferId.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(247, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(157, 23);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(247, 70);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.PlaceholderText = "Middle Initial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(157, 23);
            this.txtMiddleInitial.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(247, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(157, 23);
            this.txtLastName.TabIndex = 10;
            // 
            // txtHandicap
            // 
            this.txtHandicap.Location = new System.Drawing.Point(247, 128);
            this.txtHandicap.Name = "txtHandicap";
            this.txtHandicap.PlaceholderText = "Handicap";
            this.txtHandicap.Size = new System.Drawing.Size(157, 23);
            this.txtHandicap.TabIndex = 11;
            // 
            // btnGetClubType
            // 
            this.btnGetClubType.Location = new System.Drawing.Point(596, 11);
            this.btnGetClubType.Name = "btnGetClubType";
            this.btnGetClubType.Size = new System.Drawing.Size(112, 23);
            this.btnGetClubType.TabIndex = 12;
            this.btnGetClubType.Text = "Get Club Types";
            this.btnGetClubType.UseVisualStyleBackColor = true;
            this.btnGetClubType.Click += new System.EventHandler(this.btnGetClubTypes_Click);
            // 
            // btnAddClubType
            // 
            this.btnAddClubType.Location = new System.Drawing.Point(596, 70);
            this.btnAddClubType.Name = "btnAddClubType";
            this.btnAddClubType.Size = new System.Drawing.Size(112, 23);
            this.btnAddClubType.TabIndex = 13;
            this.btnAddClubType.Text = "Add Club Type";
            this.btnAddClubType.UseVisualStyleBackColor = true;
            this.btnAddClubType.Click += new System.EventHandler(this.btnAddClubType_Click);
            // 
            // btnUpdateClubType
            // 
            this.btnUpdateClubType.Location = new System.Drawing.Point(596, 99);
            this.btnUpdateClubType.Name = "btnUpdateClubType";
            this.btnUpdateClubType.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateClubType.TabIndex = 14;
            this.btnUpdateClubType.Text = "Update Club Type";
            this.btnUpdateClubType.UseVisualStyleBackColor = true;
            this.btnUpdateClubType.Click += new System.EventHandler(this.btnUpdateClubType_Click);
            // 
            // btnDeleteClubType
            // 
            this.btnDeleteClubType.Location = new System.Drawing.Point(596, 128);
            this.btnDeleteClubType.Name = "btnDeleteClubType";
            this.btnDeleteClubType.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteClubType.TabIndex = 15;
            this.btnDeleteClubType.Text = "Delete Club Type";
            this.btnDeleteClubType.UseVisualStyleBackColor = true;
            this.btnDeleteClubType.Click += new System.EventHandler(this.btnDeleteClubType_Click);
            // 
            // lstClubType
            // 
            this.lstClubType.FormattingEnabled = true;
            this.lstClubType.ItemHeight = 15;
            this.lstClubType.Location = new System.Drawing.Point(714, 12);
            this.lstClubType.Name = "lstClubType";
            this.lstClubType.Size = new System.Drawing.Size(120, 139);
            this.lstClubType.TabIndex = 16;
            this.lstClubType.SelectedIndexChanged += new System.EventHandler(this.lstClubType_SelectedIndexChanged);
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(840, 41);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.PlaceholderText = "Club Name";
            this.txtClubName.Size = new System.Drawing.Size(157, 23);
            this.txtClubName.TabIndex = 18;
            // 
            // txtClubUniqueId
            // 
            this.txtClubUniqueId.Enabled = false;
            this.txtClubUniqueId.Location = new System.Drawing.Point(841, 12);
            this.txtClubUniqueId.Name = "txtClubUniqueId";
            this.txtClubUniqueId.PlaceholderText = "Unique ID";
            this.txtClubUniqueId.Size = new System.Drawing.Size(157, 23);
            this.txtClubUniqueId.TabIndex = 17;
            // 
            // frmGolfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 592);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.txtClubUniqueId);
            this.Controls.Add(this.lstClubType);
            this.Controls.Add(this.btnDeleteClubType);
            this.Controls.Add(this.btnUpdateClubType);
            this.Controls.Add(this.btnAddClubType);
            this.Controls.Add(this.btnGetClubType);
            this.Controls.Add(this.txtHandicap);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtGolferId);
            this.Controls.Add(this.lstGolfers);
            this.Controls.Add(this.btnDeleteGolfer);
            this.Controls.Add(this.btnUpdateGolfer);
            this.Controls.Add(this.btnAddGolfer);
            this.Controls.Add(this.btnGetAllGolfers);
            this.Name = "frmGolfer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllGolfers;
        private System.Windows.Forms.Button btnAddGolfer;
        private System.Windows.Forms.Button btnUpdateGolfer;
        private System.Windows.Forms.Button btnDeleteGolfer;
        private System.Windows.Forms.ListBox lstGolfers;
        private System.Windows.Forms.TextBox txtGolferId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHandicap;
        private System.Windows.Forms.Button btnGetClubType;
        private System.Windows.Forms.Button btnAddClubType;
        private System.Windows.Forms.Button btnUpdateClubType;
        private System.Windows.Forms.Button btnDeleteClubType;
        private System.Windows.Forms.ListBox lstClubType;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.TextBox txtClubUniqueId;
    }
}

