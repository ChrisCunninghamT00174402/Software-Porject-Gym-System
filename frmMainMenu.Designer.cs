namespace GymSys
{
    partial class frmMainMenu
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
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnFitness = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(12, 294);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(145, 50);
            this.btnMembers.TabIndex = 0;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(345, 294);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(144, 50);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administration";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnFitness
            // 
            this.btnFitness.Location = new System.Drawing.Point(181, 294);
            this.btnFitness.Name = "btnFitness";
            this.btnFitness.Size = new System.Drawing.Size(145, 50);
            this.btnFitness.TabIndex = 2;
            this.btnFitness.Text = "Fitness Profile";
            this.btnFitness.UseVisualStyleBackColor = true;
            this.btnFitness.Click += new System.EventHandler(this.btnFitness_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gym System";
            // 
            // picture
            // 
            this.picture.Image = global::GymSys.Properties.Resources.images__1_3;
            this.picture.Location = new System.Drawing.Point(148, 69);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(312, 219);
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(504, 360);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFitness);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnMembers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMainMenu";
            this.Text = "Gym System";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnFitness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture;
    }
}

