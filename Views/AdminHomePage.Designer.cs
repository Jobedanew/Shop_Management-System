namespace Shop_Management_System.Views
{
    partial class AdminHomePage
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
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnOperation.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.Location = new System.Drawing.Point(248, 181);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(321, 101);
            this.btnOperation.TabIndex = 0;
            this.btnOperation.Text = "Product Operation";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCustomer.Location = new System.Drawing.Point(29, 80);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(196, 37);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer Operation";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnEmployee.Location = new System.Drawing.Point(29, 123);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(196, 37);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee Operation";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnProfile.Location = new System.Drawing.Point(29, 29);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(103, 45);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(688, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnOperation);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnExit;
    }
}