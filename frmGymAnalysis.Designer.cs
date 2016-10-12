namespace GymSys
{
    partial class frmAnalysis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMale = new System.Windows.Forms.TextBox();
            this.txtFemale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberProfiles = new System.Windows.Forms.TextBox();
            this.txtNoMembers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAnalysis = new System.Windows.Forms.DataGridView();
            this.grpAnalysisDate = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAnalysis)).BeginInit();
            this.grpAnalysisDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(170, 425);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(89, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMale);
            this.groupBox1.Controls.Add(this.txtFemale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMemberProfiles);
            this.groupBox1.Controls.Add(this.txtNoMembers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Analysis";
            // 
            // txtMale
            // 
            this.txtMale.Enabled = false;
            this.txtMale.Location = new System.Drawing.Point(235, 146);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(99, 20);
            this.txtMale.TabIndex = 10;
            // 
            // txtFemale
            // 
            this.txtFemale.Enabled = false;
            this.txtFemale.Location = new System.Drawing.Point(235, 112);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(99, 20);
            this.txtFemale.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "No. of Male Members";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. of Female Members";
            // 
            // txtMemberProfiles
            // 
            this.txtMemberProfiles.Enabled = false;
            this.txtMemberProfiles.Location = new System.Drawing.Point(235, 73);
            this.txtMemberProfiles.Name = "txtMemberProfiles";
            this.txtMemberProfiles.Size = new System.Drawing.Size(99, 20);
            this.txtMemberProfiles.TabIndex = 6;
            // 
            // txtNoMembers
            // 
            this.txtNoMembers.Enabled = false;
            this.txtNoMembers.Location = new System.Drawing.Point(235, 28);
            this.txtNoMembers.Name = "txtNoMembers";
            this.txtNoMembers.Size = new System.Drawing.Size(99, 20);
            this.txtNoMembers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "No. of Member Fitness Profiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. of Members Registered ";
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpAnalysis.Location = new System.Drawing.Point(9, 19);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.ReadOnly = true;
            this.grpAnalysis.Size = new System.Drawing.Size(359, 160);
            this.grpAnalysis.TabIndex = 4;
            // 
            // grpAnalysisDate
            // 
            this.grpAnalysisDate.Controls.Add(this.grpAnalysis);
            this.grpAnalysisDate.Location = new System.Drawing.Point(27, 218);
            this.grpAnalysisDate.Name = "grpAnalysisDate";
            this.grpAnalysisDate.Size = new System.Drawing.Size(385, 201);
            this.grpAnalysisDate.TabIndex = 7;
            this.grpAnalysisDate.TabStop = false;
            this.grpAnalysisDate.Text = "Member Analysis";
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(429, 460);
            this.Controls.Add(this.grpAnalysisDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmAnalysis";
            this.Text = "GymAnalysis";
            this.Load += new System.EventHandler(this.frmAnalysis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAnalysis)).EndInit();
            this.grpAnalysisDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMemberProfiles;
        private System.Windows.Forms.TextBox txtNoMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grpAnalysis;
        private System.Windows.Forms.GroupBox grpAnalysisDate;
        private System.Windows.Forms.TextBox txtMale;
        private System.Windows.Forms.TextBox txtFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}