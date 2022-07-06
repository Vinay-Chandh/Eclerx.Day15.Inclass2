namespace Eclerx.Day15.Inclass2
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
            this.LblDeptCode = new System.Windows.Forms.Label();
            this.LblDeptName = new System.Windows.Forms.Label();
            this.LblDeptHead = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.TxtDeptCode = new System.Windows.Forms.TextBox();
            this.TxtDeptName = new System.Windows.Forms.TextBox();
            this.TxtDeptHead = new System.Windows.Forms.TextBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GridDepartment = new System.Windows.Forms.DataGridView();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDeptCode
            // 
            this.LblDeptCode.AutoSize = true;
            this.LblDeptCode.Location = new System.Drawing.Point(171, 16);
            this.LblDeptCode.Name = "LblDeptCode";
            this.LblDeptCode.Size = new System.Drawing.Size(90, 13);
            this.LblDeptCode.TabIndex = 0;
            this.LblDeptCode.Text = "Department Code";
            // 
            // LblDeptName
            // 
            this.LblDeptName.AutoSize = true;
            this.LblDeptName.Location = new System.Drawing.Point(171, 54);
            this.LblDeptName.Name = "LblDeptName";
            this.LblDeptName.Size = new System.Drawing.Size(93, 13);
            this.LblDeptName.TabIndex = 1;
            this.LblDeptName.Text = "Department Name";
            // 
            // LblDeptHead
            // 
            this.LblDeptHead.AutoSize = true;
            this.LblDeptHead.Location = new System.Drawing.Point(171, 89);
            this.LblDeptHead.Name = "LblDeptHead";
            this.LblDeptHead.Size = new System.Drawing.Size(88, 13);
            this.LblDeptHead.TabIndex = 2;
            this.LblDeptHead.Text = "Depatment Head";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(171, 132);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(48, 13);
            this.LblLocation.TabIndex = 3;
            this.LblLocation.Text = "Location";
            // 
            // TxtDeptCode
            // 
            this.TxtDeptCode.Location = new System.Drawing.Point(299, 13);
            this.TxtDeptCode.Name = "TxtDeptCode";
            this.TxtDeptCode.Size = new System.Drawing.Size(184, 20);
            this.TxtDeptCode.TabIndex = 4;
            // 
            // TxtDeptName
            // 
            this.TxtDeptName.Location = new System.Drawing.Point(299, 51);
            this.TxtDeptName.Name = "TxtDeptName";
            this.TxtDeptName.Size = new System.Drawing.Size(184, 20);
            this.TxtDeptName.TabIndex = 5;
            // 
            // TxtDeptHead
            // 
            this.TxtDeptHead.Location = new System.Drawing.Point(299, 86);
            this.TxtDeptHead.Name = "TxtDeptHead";
            this.TxtDeptHead.Size = new System.Drawing.Size(184, 20);
            this.TxtDeptHead.TabIndex = 6;
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(299, 129);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(184, 20);
            this.TxtLocation.TabIndex = 7;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(226, 183);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNew.TabIndex = 8;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(355, 183);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(487, 183);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // GridDepartment
            // 
            this.GridDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDepartment.Location = new System.Drawing.Point(121, 212);
            this.GridDepartment.Name = "GridDepartment";
            this.GridDepartment.Size = new System.Drawing.Size(535, 222);
            this.GridDepartment.TabIndex = 11;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(581, 51);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 12;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(580, 13);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 13;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.GridDepartment);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.TxtDeptHead);
            this.Controls.Add(this.TxtDeptName);
            this.Controls.Add(this.TxtDeptCode);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.LblDeptHead);
            this.Controls.Add(this.LblDeptName);
            this.Controls.Add(this.LblDeptCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDeptCode;
        private System.Windows.Forms.Label LblDeptName;
        private System.Windows.Forms.Label LblDeptHead;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.TextBox TxtDeptCode;
        private System.Windows.Forms.TextBox TxtDeptName;
        private System.Windows.Forms.TextBox TxtDeptHead;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView GridDepartment;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSearch;
    }
}

