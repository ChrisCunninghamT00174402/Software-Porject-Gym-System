namespace GymSys
{
    partial class frmFees
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
            this.grpSetPlans = new System.Windows.Forms.GroupBox();
            this.cboDuration = new System.Windows.Forms.ComboBox();
            this.btnAddNewPlan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPlanCode = new System.Windows.Forms.TextBox();
            this.grdListPlan = new System.Windows.Forms.DataGridView();
            this.txtProfileIncluded = new System.Windows.Forms.ComboBox();
            this.grpUpFee = new System.Windows.Forms.GroupBox();
            this.cboUpDuration = new System.Windows.Forms.ComboBox();
            this.btnUpdatePlans = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpPrice = new System.Windows.Forms.TextBox();
            this.txtUpCode = new System.Windows.Forms.TextBox();
            this.grpSetPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListPlan)).BeginInit();
            this.grpUpFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(147, 465);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(170, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpSetPlans
            // 
            this.grpSetPlans.Controls.Add(this.cboDuration);
            this.grpSetPlans.Controls.Add(this.btnAddNewPlan);
            this.grpSetPlans.Controls.Add(this.label4);
            this.grpSetPlans.Controls.Add(this.label3);
            this.grpSetPlans.Controls.Add(this.label1);
            this.grpSetPlans.Controls.Add(this.label2);
            this.grpSetPlans.Controls.Add(this.txtPrice);
            this.grpSetPlans.Controls.Add(this.txtPlanCode);
            this.grpSetPlans.Location = new System.Drawing.Point(12, 12);
            this.grpSetPlans.Name = "grpSetPlans";
            this.grpSetPlans.Size = new System.Drawing.Size(441, 150);
            this.grpSetPlans.TabIndex = 1;
            this.grpSetPlans.TabStop = false;
            this.grpSetPlans.Text = "Set Plans";
            // 
            // cboDuration
            // 
            this.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDuration.FormattingEnabled = true;
            this.cboDuration.Location = new System.Drawing.Point(312, 32);
            this.cboDuration.Name = "cboDuration";
            this.cboDuration.Size = new System.Drawing.Size(112, 21);
            this.cboDuration.TabIndex = 46;
            // 
            // btnAddNewPlan
            // 
            this.btnAddNewPlan.Location = new System.Drawing.Point(147, 121);
            this.btnAddNewPlan.Name = "btnAddNewPlan";
            this.btnAddNewPlan.Size = new System.Drawing.Size(168, 23);
            this.btnAddNewPlan.TabIndex = 45;
            this.btnAddNewPlan.Text = "Add";
            this.btnAddNewPlan.UseVisualStyleBackColor = true;
            this.btnAddNewPlan.Click += new System.EventHandler(this.btnAddNewPlan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Plan Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profile Included";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(86, 78);
            this.txtPrice.MaxLength = 3;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // txtPlanCode
            // 
            this.txtPlanCode.Enabled = false;
            this.txtPlanCode.Location = new System.Drawing.Point(86, 29);
            this.txtPlanCode.MaxLength = 5;
            this.txtPlanCode.Name = "txtPlanCode";
            this.txtPlanCode.Size = new System.Drawing.Size(100, 20);
            this.txtPlanCode.TabIndex = 2;
            // 
            // grdListPlan
            // 
            this.grdListPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListPlan.Location = new System.Drawing.Point(12, 171);
            this.grdListPlan.Name = "grdListPlan";
            this.grdListPlan.ReadOnly = true;
            this.grdListPlan.Size = new System.Drawing.Size(441, 119);
            this.grdListPlan.TabIndex = 2;
            this.grdListPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListPlan_CellContentClick);
            // 
            // txtProfileIncluded
            // 
            this.txtProfileIncluded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProfileIncluded.FormattingEnabled = true;
            this.txtProfileIncluded.Location = new System.Drawing.Point(323, 89);
            this.txtProfileIncluded.Name = "txtProfileIncluded";
            this.txtProfileIncluded.Size = new System.Drawing.Size(113, 21);
            this.txtProfileIncluded.TabIndex = 46;
            // 
            // grpUpFee
            // 
            this.grpUpFee.Controls.Add(this.cboUpDuration);
            this.grpUpFee.Controls.Add(this.btnUpdatePlans);
            this.grpUpFee.Controls.Add(this.label5);
            this.grpUpFee.Controls.Add(this.label6);
            this.grpUpFee.Controls.Add(this.label7);
            this.grpUpFee.Controls.Add(this.txtUpPrice);
            this.grpUpFee.Controls.Add(this.txtUpCode);
            this.grpUpFee.Location = new System.Drawing.Point(12, 309);
            this.grpUpFee.Name = "grpUpFee";
            this.grpUpFee.Size = new System.Drawing.Size(441, 150);
            this.grpUpFee.TabIndex = 46;
            this.grpUpFee.TabStop = false;
            this.grpUpFee.Text = "UpDatePlans";
            this.grpUpFee.Visible = false;
            // 
            // cboUpDuration
            // 
            this.cboUpDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpDuration.FormattingEnabled = true;
            this.cboUpDuration.Location = new System.Drawing.Point(311, 32);
            this.cboUpDuration.Name = "cboUpDuration";
            this.cboUpDuration.Size = new System.Drawing.Size(112, 21);
            this.cboUpDuration.TabIndex = 47;
            // 
            // btnUpdatePlans
            // 
            this.btnUpdatePlans.Location = new System.Drawing.Point(135, 121);
            this.btnUpdatePlans.Name = "btnUpdatePlans";
            this.btnUpdatePlans.Size = new System.Drawing.Size(170, 23);
            this.btnUpdatePlans.TabIndex = 45;
            this.btnUpdatePlans.Text = "Update";
            this.btnUpdatePlans.UseVisualStyleBackColor = true;
            this.btnUpdatePlans.Click += new System.EventHandler(this.btnUpdatePlans_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plan Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Duration";
            // 
            // txtUpPrice
            // 
            this.txtUpPrice.Location = new System.Drawing.Point(180, 78);
            this.txtUpPrice.Name = "txtUpPrice";
            this.txtUpPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUpPrice.TabIndex = 3;
            // 
            // txtUpCode
            // 
            this.txtUpCode.Enabled = false;
            this.txtUpCode.Location = new System.Drawing.Point(86, 29);
            this.txtUpCode.Name = "txtUpCode";
            this.txtUpCode.Size = new System.Drawing.Size(100, 20);
            this.txtUpCode.TabIndex = 2;
            // 
            // frmFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(475, 493);
            this.Controls.Add(this.grpUpFee);
            this.Controls.Add(this.txtProfileIncluded);
            this.Controls.Add(this.grdListPlan);
            this.Controls.Add(this.grpSetPlans);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmFees";
            this.Text = "MembershipFees";
            this.Load += new System.EventHandler(this.frmFees_Load);
            this.grpSetPlans.ResumeLayout(false);
            this.grpSetPlans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListPlan)).EndInit();
            this.grpUpFee.ResumeLayout(false);
            this.grpUpFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox grpSetPlans;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPlanCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewPlan;
        private System.Windows.Forms.DataGridView grdListPlan;
        private System.Windows.Forms.ComboBox txtProfileIncluded;
        private System.Windows.Forms.GroupBox grpUpFee;
        private System.Windows.Forms.Button btnUpdatePlans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpPrice;
        private System.Windows.Forms.TextBox txtUpCode;
        private System.Windows.Forms.ComboBox cboDuration;
        private System.Windows.Forms.ComboBox cboUpDuration;
    }
}