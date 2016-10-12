namespace GymSys
{
    partial class frmFitnessPlan
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
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnMemberProfile = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(96, 135);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(157, 21);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(77, 79);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(200, 26);
            this.btnProgress.TabIndex = 1;
            this.btnProgress.Text = "Member Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnMemberProfile
            // 
            this.btnMemberProfile.Location = new System.Drawing.Point(12, 40);
            this.btnMemberProfile.Name = "btnMemberProfile";
            this.btnMemberProfile.Size = new System.Drawing.Size(157, 23);
            this.btnMemberProfile.TabIndex = 2;
            this.btnMemberProfile.Text = "Add Member Profile";
            this.btnMemberProfile.UseVisualStyleBackColor = true;
            this.btnMemberProfile.Click += new System.EventHandler(this.btnMemberProfile_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.Location = new System.Drawing.Point(187, 40);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(157, 23);
            this.btnPlan.TabIndex = 3;
            this.btnPlan.Text = "Assign Fitness Plan";
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // frmFitnessPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(356, 164);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.btnMemberProfile);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmFitnessPlan";
            this.Text = "Fitness";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnMemberProfile;
        private System.Windows.Forms.Button btnPlan;
    }
}