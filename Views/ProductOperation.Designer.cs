namespace Shop_Management_System.Views
{
    partial class ProductOperation
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.txtBxQuantity = new System.Windows.Forms.TextBox();
            this.txtBxNAme = new System.Windows.Forms.TextBox();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQantity = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.lblSale = new System.Windows.Forms.Label();
            this.txtBxSale = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.Color.Bisque;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(22, 295);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 62;
            this.Grid.RowTemplate.Height = 28;
            this.Grid.Size = new System.Drawing.Size(1130, 248);
            this.Grid.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Peru;
            this.btnBack.Location = new System.Drawing.Point(1054, 571);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnReset.Location = new System.Drawing.Point(622, 243);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 32);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSearch.Location = new System.Drawing.Point(422, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnDelete.Location = new System.Drawing.Point(1001, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnUpdate.Location = new System.Drawing.Point(240, 243);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAdd.Location = new System.Drawing.Point(78, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(622, 69);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(100, 26);
            this.txtBxPrice.TabIndex = 2;
            // 
            // txtBxQuantity
            // 
            this.txtBxQuantity.Location = new System.Drawing.Point(622, 133);
            this.txtBxQuantity.Name = "txtBxQuantity";
            this.txtBxQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtBxQuantity.TabIndex = 2;
            // 
            // txtBxNAme
            // 
            this.txtBxNAme.Location = new System.Drawing.Point(226, 72);
            this.txtBxNAme.Name = "txtBxNAme";
            this.txtBxNAme.Size = new System.Drawing.Size(158, 26);
            this.txtBxNAme.TabIndex = 2;
            // 
            // txtBxId
            // 
            this.txtBxId.Location = new System.Drawing.Point(226, 133);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.Size = new System.Drawing.Size(158, 26);
            this.txtBxId.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(93, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Product Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(93, 136);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 20);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Product ID";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(524, 69);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblQantity
            // 
            this.lblQantity.AutoSize = true;
            this.lblQantity.Location = new System.Drawing.Point(524, 136);
            this.lblQantity.Name = "lblQantity";
            this.lblQantity.Size = new System.Drawing.Size(68, 20);
            this.lblQantity.TabIndex = 3;
            this.lblQantity.Text = "Quantity";
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSale.Location = new System.Drawing.Point(807, 243);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(90, 32);
            this.btnSale.TabIndex = 4;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(846, 69);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(109, 20);
            this.lblSale.TabIndex = 3;
            this.lblSale.Text = "Sales Amount";
            // 
            // txtBxSale
            // 
            this.txtBxSale.Location = new System.Drawing.Point(963, 66);
            this.txtBxSale.Name = "txtBxSale";
            this.txtBxSale.Size = new System.Drawing.Size(100, 26);
            this.txtBxSale.TabIndex = 2;
            // 
            // ProductOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.lblQantity);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBxSale);
            this.Controls.Add(this.txtBxQuantity);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.txtBxId);
            this.Controls.Add(this.txtBxNAme);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Grid);
            this.Name = "ProductOperation";
            this.Text = "ProductOperation";
            this.Load += new System.EventHandler(this.ProductOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.TextBox txtBxQuantity;
        private System.Windows.Forms.TextBox txtBxNAme;
        private System.Windows.Forms.TextBox txtBxId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQantity;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.TextBox txtBxSale;
    }
}