namespace GymSys
{
    partial class frmPlan
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
            this.cboMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboExercise = new System.Windows.Forms.ComboBox();
            this.cboDiet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(106, 341);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(209, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Member Profile";
            // 
            // cboMember
            // 
            this.cboMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMember.FormattingEnabled = true;
            this.cboMember.Location = new System.Drawing.Point(209, 70);
            this.cboMember.Name = "cboMember";
            this.cboMember.Size = new System.Drawing.Size(179, 21);
            this.cboMember.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assign Diet Plan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Assign Exercise Plan";
            // 
            // cboExercise
            // 
            this.cboExercise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExercise.FormattingEnabled = true;
            this.cboExercise.Location = new System.Drawing.Point(209, 240);
            this.cboExercise.Name = "cboExercise";
            this.cboExercise.Size = new System.Drawing.Size(179, 21);
            this.cboExercise.TabIndex = 8;
            // 
            // cboDiet
            // 
            this.cboDiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiet.FormattingEnabled = true;
            this.cboDiet.Location = new System.Drawing.Point(209, 153);
            this.cboDiet.Name = "cboDiet";
            this.cboDiet.Size = new System.Drawing.Size(179, 21);
            this.cboDiet.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Plans";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(418, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboDiet);
            this.Controls.Add(this.cboExercise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmPlan";
            this.Text = "AddFitnessPlan";
            this.Load += new System.EventHandler(this.frmPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboExercise;
        private System.Windows.Forms.ComboBox cboDiet;
        private System.Windows.Forms.Button button1;
    }
}