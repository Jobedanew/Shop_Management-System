namespace Shop_Management_System.Views
{
    partial class EmployeeOperation
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.butonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelgGender = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxrole = new System.Windows.Forms.TextBox();
            this.textBoxsalary = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxconact = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 269);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 62;
            this.Grid.RowTemplate.Height = 28;
            this.Grid.Size = new System.Drawing.Size(1006, 238);
            this.Grid.TabIndex = 0;
            // 
            // butonAdd
            // 
            this.butonAdd.BackColor = System.Drawing.Color.PapayaWhip;
            this.butonAdd.Location = new System.Drawing.Point(94, 217);
            this.butonAdd.Name = "butonAdd";
            this.butonAdd.Size = new System.Drawing.Size(82, 37);
            this.butonAdd.TabIndex = 1;
            this.butonAdd.Text = "Add";
            this.butonAdd.UseVisualStyleBackColor = false;
            this.butonAdd.Click += new System.EventHandler(this.butonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonUpdate.Location = new System.Drawing.Point(234, 217);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 37);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonDelete.Location = new System.Drawing.Point(380, 217);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 37);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonReset.Location = new System.Drawing.Point(515, 217);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(82, 37);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonSearch.Location = new System.Drawing.Point(660, 217);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 37);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonBack.Location = new System.Drawing.Point(812, 217);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 37);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(90, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(90, 91);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(97, 20);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Employee Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(411, 33);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(411, 91);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(65, 20);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Contact";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(411, 154);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 20);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // labelgGender
            // 
            this.labelgGender.AutoSize = true;
            this.labelgGender.Location = new System.Drawing.Point(709, 33);
            this.labelgGender.Name = "labelgGender";
            this.labelgGender.Size = new System.Drawing.Size(63, 20);
            this.labelgGender.TabIndex = 2;
            this.labelgGender.Text = "Gender";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(709, 91);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(42, 20);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Role";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(709, 154);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(53, 20);
            this.labelSalary.TabIndex = 2;
            this.labelSalary.Text = "Salary";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(200, 33);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(148, 26);
            this.textBoxname.TabIndex = 3;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(200, 91);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(148, 26);
            this.textBoxid.TabIndex = 3;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(200, 151);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(148, 26);
            this.textBoxpass.TabIndex = 3;
            // 
            // textBoxrole
            // 
            this.textBoxrole.Location = new System.Drawing.Point(780, 91);
            this.textBoxrole.Name = "textBoxrole";
            this.textBoxrole.Size = new System.Drawing.Size(148, 26);
            this.textBoxrole.TabIndex = 3;
            // 
            // textBoxsalary
            // 
            this.textBoxsalary.Location = new System.Drawing.Point(780, 151);
            this.textBoxsalary.Name = "textBoxsalary";
            this.textBoxsalary.Size = new System.Drawing.Size(148, 26);
            this.textBoxsalary.TabIndex = 3;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(488, 33);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(148, 26);
            this.textBoxemail.TabIndex = 3;
            // 
            // textBoxconact
            // 
            this.textBoxconact.Location = new System.Drawing.Point(488, 91);
            this.textBoxconact.Name = "textBoxconact";
            this.textBoxconact.Size = new System.Drawing.Size(148, 26);
            this.textBoxconact.TabIndex = 3;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(488, 151);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(148, 26);
            this.textBoxage.TabIndex = 3;
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxgender.Location = new System.Drawing.Point(780, 33);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(148, 28);
            this.comboBoxgender.TabIndex = 4;
            // 
            // EmployeeOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1030, 519);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxsalary);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxconact);
            this.Controls.Add(this.textBoxrole);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelgGender);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.butonAdd);
            this.Controls.Add(this.Grid);
            this.Name = "EmployeeOperation";
            this.Text = "EmployeeOperation";
            this.Load += new System.EventHandler(this.EmployeeOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button butonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelgGender;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxrole;
        private System.Windows.Forms.TextBox textBoxsalary;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxconact;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.ComboBox comboBoxgender;
    }
}