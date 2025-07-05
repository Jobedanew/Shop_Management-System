namespace Shop_Management_System.Views
{
    partial class EmployeeHomePage
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
            this.buttonPO = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCO = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPO
            // 
            this.buttonPO.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPO.Location = new System.Drawing.Point(245, 189);
            this.buttonPO.Name = "buttonPO";
            this.buttonPO.Size = new System.Drawing.Size(311, 85);
            this.buttonPO.TabIndex = 0;
            this.buttonPO.Text = "Product Operation";
            this.buttonPO.UseVisualStyleBackColor = false;
            this.buttonPO.Click += new System.EventHandler(this.buttonPO_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(699, 399);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(71, 31);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCO
            // 
            this.buttonCO.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonCO.Location = new System.Drawing.Point(38, 106);
            this.buttonCO.Name = "buttonCO";
            this.buttonCO.Size = new System.Drawing.Size(193, 36);
            this.buttonCO.TabIndex = 1;
            this.buttonCO.Text = "Customer Operation";
            this.buttonCO.UseVisualStyleBackColor = false;
            this.buttonCO.Click += new System.EventHandler(this.buttonCO_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonProfile.Location = new System.Drawing.Point(38, 52);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(133, 36);
            this.buttonProfile.TabIndex = 1;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.Color.Peru;
            this.buttonlogout.Location = new System.Drawing.Point(352, 314);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(92, 35);
            this.buttonlogout.TabIndex = 2;
            this.buttonlogout.Text = "Log out";
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // EmployeeHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonCO);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPO);
            this.Name = "EmployeeHomePage";
            this.Text = "EmployeeHomePage";
            this.Load += new System.EventHandler(this.EmployeeHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPO;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCO;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonlogout;
    }
}