namespace GymSys
{
    partial class frmProgress
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckID = new System.Windows.Forms.Button();
            this.gridUpProfile = new System.Windows.Forms.DataGridView();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.txtAmendDate = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpFitness = new System.Windows.Forms.Button();
            this.txtBFat = new System.Windows.Forms.TextBox();
            this.txtHRate = new System.Windows.Forms.TextBox();
            this.txtProId = new System.Windows.Forms.TextBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.txtWe = new System.Windows.Forms.TextBox();
            this.txtBPressure = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.cmMember = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridFitnessHistory = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridUpProfile)).BeginInit();
            this.grpProfile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFitnessHistory)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(321, 536);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(260, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // btnCheckID
            // 
            this.btnCheckID.Location = new System.Drawing.Point(141, 19);
            this.btnCheckID.Name = "btnCheckID";
            this.btnCheckID.Size = new System.Drawing.Size(90, 23);
            this.btnCheckID.TabIndex = 5;
            this.btnCheckID.Text = "Check";
            this.btnCheckID.UseVisualStyleBackColor = true;
            this.btnCheckID.Click += new System.EventHandler(this.btnCheckID_Click);
            // 
            // gridUpProfile
            // 
            this.gridUpProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUpProfile.Location = new System.Drawing.Point(33, 83);
            this.gridUpProfile.Name = "gridUpProfile";
            this.gridUpProfile.ReadOnly = true;
            this.gridUpProfile.Size = new System.Drawing.Size(393, 150);
            this.gridUpProfile.TabIndex = 6;
            this.gridUpProfile.Visible = false;
            this.gridUpProfile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUpProfile_CellClick);
            // 
            // grpProfile
            // 
            this.grpProfile.Controls.Add(this.txtAmendDate);
            this.grpProfile.Controls.Add(this.txtDate);
            this.grpProfile.Controls.Add(this.txtB);
            this.grpProfile.Controls.Add(this.label10);
            this.grpProfile.Controls.Add(this.btnUpFitness);
            this.grpProfile.Controls.Add(this.txtBFat);
            this.grpProfile.Controls.Add(this.txtHRate);
            this.grpProfile.Controls.Add(this.txtProId);
            this.grpProfile.Controls.Add(this.txtMemId);
            this.grpProfile.Controls.Add(this.txtWe);
            this.grpProfile.Controls.Add(this.txtBPressure);
            this.grpProfile.Controls.Add(this.label9);
            this.grpProfile.Controls.Add(this.label8);
            this.grpProfile.Controls.Add(this.label2);
            this.grpProfile.Controls.Add(this.label4);
            this.grpProfile.Controls.Add(this.label5);
            this.grpProfile.Controls.Add(this.label6);
            this.grpProfile.Controls.Add(this.label7);
            this.grpProfile.Location = new System.Drawing.Point(445, 22);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Size = new System.Drawing.Size(431, 232);
            this.grpProfile.TabIndex = 7;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "List Details";
            this.grpProfile.Visible = false;
            // 
            // txtAmendDate
            // 
            this.txtAmendDate.Enabled = false;
            this.txtAmendDate.Location = new System.Drawing.Point(84, 197);
            this.txtAmendDate.Name = "txtAmendDate";
            this.txtAmendDate.Size = new System.Drawing.Size(100, 20);
            this.txtAmendDate.TabIndex = 20;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(18, 198);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(38, 17);
            this.txtDate.TabIndex = 19;
            this.txtDate.Text = "Date";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(273, 101);
            this.txtB.MaxLength = 2;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(126, 20);
            this.txtB.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(190, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Heart Rate";
            // 
            // btnUpFitness
            // 
            this.btnUpFitness.Location = new System.Drawing.Point(309, 198);
            this.btnUpFitness.Name = "btnUpFitness";
            this.btnUpFitness.Size = new System.Drawing.Size(90, 23);
            this.btnUpFitness.TabIndex = 16;
            this.btnUpFitness.Text = "Update";
            this.btnUpFitness.UseVisualStyleBackColor = true;
            this.btnUpFitness.Click += new System.EventHandler(this.btnUpFitness_Click);
            // 
            // txtBFat
            // 
            this.txtBFat.Location = new System.Drawing.Point(273, 142);
            this.txtBFat.MaxLength = 2;
            this.txtBFat.Name = "txtBFat";
            this.txtBFat.Size = new System.Drawing.Size(126, 20);
            this.txtBFat.TabIndex = 15;
            // 
            // txtHRate
            // 
            this.txtHRate.Location = new System.Drawing.Point(273, 28);
            this.txtHRate.MaxLength = 5;
            this.txtHRate.Name = "txtHRate";
            this.txtHRate.Size = new System.Drawing.Size(126, 20);
            this.txtHRate.TabIndex = 9;
            // 
            // txtProId
            // 
            this.txtProId.Enabled = false;
            this.txtProId.Location = new System.Drawing.Point(84, 28);
            this.txtProId.MaxLength = 5;
            this.txtProId.Name = "txtProId";
            this.txtProId.Size = new System.Drawing.Size(100, 20);
            this.txtProId.TabIndex = 10;
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Location = new System.Drawing.Point(84, 66);
            this.txtMemId.MaxLength = 5;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(100, 20);
            this.txtMemId.TabIndex = 11;
            // 
            // txtWe
            // 
            this.txtWe.Location = new System.Drawing.Point(84, 104);
            this.txtWe.MaxLength = 5;
            this.txtWe.Name = "txtWe";
            this.txtWe.Size = new System.Drawing.Size(100, 20);
            this.txtWe.TabIndex = 12;
            // 
            // txtBPressure
            // 
            this.txtBPressure.Location = new System.Drawing.Point(299, 63);
            this.txtBPressure.MaxLength = 5;
            this.txtBPressure.Name = "txtBPressure";
            this.txtBPressure.Size = new System.Drawing.Size(100, 20);
            this.txtBPressure.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(188, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Body Fat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "BMI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Blood Pressure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "MemberID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Profile ID";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(275, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 23);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.txtFind_Click);
            // 
            // cmMember
            // 
            this.cmMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmMember.FormattingEnabled = true;
            this.cmMember.Location = new System.Drawing.Point(36, 21);
            this.cmMember.Name = "cmMember";
            this.cmMember.Size = new System.Drawing.Size(179, 21);
            this.cmMember.TabIndex = 21;
            this.cmMember.SelectedIndexChanged += new System.EventHandler(this.cmMember_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridFitnessHistory);
            this.groupBox2.Controls.Add(this.cmMember);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Location = new System.Drawing.Point(33, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 236);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Ftness History";
            // 
            // gridFitnessHistory
            // 
            this.gridFitnessHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFitnessHistory.Location = new System.Drawing.Point(23, 65);
            this.gridFitnessHistory.Name = "gridFitnessHistory";
            this.gridFitnessHistory.ReadOnly = true;
            this.gridFitnessHistory.Size = new System.Drawing.Size(800, 158);
            this.gridFitnessHistory.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCheckID);
            this.groupBox3.Location = new System.Drawing.Point(33, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 65);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find Member Profile";
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(888, 570);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.gridUpProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmProgress";
            this.Text = "MemberProgress";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUpProfile)).EndInit();
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFitnessHistory)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckID;
        private System.Windows.Forms.DataGridView gridUpProfile;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Button btnUpFitness;
        private System.Windows.Forms.TextBox txtBFat;
        private System.Windows.Forms.TextBox txtHRate;
        private System.Windows.Forms.TextBox txtProId;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.TextBox txtWe;
        private System.Windows.Forms.TextBox txtBPressure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtAmendDate;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cmMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridFitnessHistory;
    }
}