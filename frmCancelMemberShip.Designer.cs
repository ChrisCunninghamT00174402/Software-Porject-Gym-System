namespace GymSys
{
    partial class frmCancel
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.optSurname = new System.Windows.Forms.RadioButton();
            this.optMemberId = new System.Windows.Forms.RadioButton();
            this.gridMemberShip = new System.Windows.Forms.DataGridView();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMemberShip)).BeginInit();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(103, 358);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(154, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.optSurname);
            this.grpDelete.Controls.Add(this.optMemberId);
            this.grpDelete.Location = new System.Drawing.Point(24, 25);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(288, 87);
            this.grpDelete.TabIndex = 2;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Select Display Order";
            // 
            // optSurname
            // 
            this.optSurname.AutoSize = true;
            this.optSurname.Checked = true;
            this.optSurname.Location = new System.Drawing.Point(182, 41);
            this.optSurname.Name = "optSurname";
            this.optSurname.Size = new System.Drawing.Size(67, 17);
            this.optSurname.TabIndex = 1;
            this.optSurname.TabStop = true;
            this.optSurname.Text = "Surname";
            this.optSurname.UseVisualStyleBackColor = true;
            this.optSurname.CheckedChanged += new System.EventHandler(this.optSurname_CheckedChanged);
            // 
            // optMemberId
            // 
            this.optMemberId.AutoSize = true;
            this.optMemberId.Location = new System.Drawing.Point(30, 41);
            this.optMemberId.Name = "optMemberId";
            this.optMemberId.Size = new System.Drawing.Size(77, 17);
            this.optMemberId.TabIndex = 0;
            this.optMemberId.Text = "Member ID";
            this.optMemberId.UseVisualStyleBackColor = true;
            this.optMemberId.CheckedChanged += new System.EventHandler(this.optMemberId_CheckedChanged);
            // 
            // gridMemberShip
            // 
            this.gridMemberShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMemberShip.Location = new System.Drawing.Point(12, 118);
            this.gridMemberShip.Name = "gridMemberShip";
            this.gridMemberShip.ReadOnly = true;
            this.gridMemberShip.Size = new System.Drawing.Size(314, 160);
            this.gridMemberShip.TabIndex = 3;
            this.gridMemberShip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMemberShip_CellContentClick);
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.btnCancel);
            this.grpMember.Controls.Add(this.txtMemberId);
            this.grpMember.Controls.Add(this.label7);
            this.grpMember.Location = new System.Drawing.Point(12, 284);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(314, 68);
            this.grpMember.TabIndex = 4;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Member";
            this.grpMember.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Enabled = false;
            this.txtMemberId.Location = new System.Drawing.Point(91, 29);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(100, 20);
            this.txtMemberId.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Member ID";
            // 
            // frmCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(334, 387);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.gridMemberShip);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmCancel";
            this.Text = "CancelMemberShip";
            this.Load += new System.EventHandler(this.frmCancel_Load);
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMemberShip)).EndInit();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.RadioButton optSurname;
        private System.Windows.Forms.RadioButton optMemberId;
        private System.Windows.Forms.DataGridView gridMemberShip;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Button btnCancel;
    }
}