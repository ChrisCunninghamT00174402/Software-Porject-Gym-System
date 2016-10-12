namespace GymSys
{
    partial class frmMembers
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(86, 143);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 105);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(140, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change Member Details";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(185, 105);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(140, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List Members";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(12, 49);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(140, 23);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "Register Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Cancel Membership";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(338, 178);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmMembers";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnDelete;
    }
}