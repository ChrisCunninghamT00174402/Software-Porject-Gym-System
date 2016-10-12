namespace GymSys
{
    partial class frmAdmin
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnFees = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(111, 120);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(145, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Return";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnFees
            // 
            this.btnFees.Location = new System.Drawing.Point(12, 62);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(160, 23);
            this.btnFees.TabIndex = 2;
            this.btnFees.Text = "Membership Fees";
            this.btnFees.UseVisualStyleBackColor = true;
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Gym Analysis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(360, 155);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFees);
            this.Controls.Add(this.btnButton);
            this.Name = "frmAdmin";
            this.Text = "Administration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Button button3;
    }
}