namespace GymSys
{
    partial class MemberList
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
            this.gridMember = new System.Windows.Forms.DataGridView();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.optSurname = new System.Windows.Forms.RadioButton();
            this.optMemberId = new System.Windows.Forms.RadioButton();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMember
            // 
            this.gridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMember.Location = new System.Drawing.Point(27, 118);
            this.gridMember.Name = "gridMember";
            this.gridMember.ReadOnly = true;
            this.gridMember.Size = new System.Drawing.Size(353, 218);
            this.gridMember.TabIndex = 0;
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.optSurname);
            this.grpOrder.Controls.Add(this.optMemberId);
            this.grpOrder.Location = new System.Drawing.Point(49, 12);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(307, 100);
            this.grpOrder.TabIndex = 1;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Select Display Order";
            // 
            // optSurname
            // 
            this.optSurname.AutoSize = true;
            this.optSurname.Checked = true;
            this.optSurname.Location = new System.Drawing.Point(184, 41);
            this.optSurname.Name = "optSurname";
            this.optSurname.Size = new System.Drawing.Size(67, 17);
            this.optSurname.TabIndex = 1;
            this.optSurname.TabStop = true;
            this.optSurname.Text = "Surname";
            this.optSurname.UseVisualStyleBackColor = true;
            this.optSurname.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(121, 342);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(167, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(401, 370);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.gridMember);
            this.Name = "MemberList";
            this.Text = "frmMemberList";
            this.Load += new System.EventHandler(this.frmMemberList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMember;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.RadioButton optSurname;
        private System.Windows.Forms.RadioButton optMemberId;
        private System.Windows.Forms.Button btnReturn;
    }
}