namespace СarShops
{
    partial class CarShopForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColCode = new System.Windows.Forms.ColumnHeader();
            this.ColName = new System.Windows.Forms.ColumnHeader();
            this.ColPosition = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductsListView = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.SAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(32, 80);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(174, 27);
            this.NameTb.TabIndex = 1;
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(249, 80);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(174, 27);
            this.AddressTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // EmployeesListView
            // 
            this.EmployeesListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.EmployeesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ColCode,
            this.ColName,
            this.ColPosition});
            this.EmployeesListView.FullRowSelect = true;
            this.EmployeesListView.HideSelection = false;
            this.EmployeesListView.Location = new System.Drawing.Point(64, 321);
            this.EmployeesListView.Name = "EmployeesListView";
            this.EmployeesListView.Size = new System.Drawing.Size(425, 121);
            this.EmployeesListView.TabIndex = 24;
            this.EmployeesListView.UseCompatibleStateImageBehavior = false;
            this.EmployeesListView.View = System.Windows.Forms.View.Details;
            this.EmployeesListView.ItemActivate += new System.EventHandler(this.EmployeesListView_ItemActivate);
            this.EmployeesListView.SelectedIndexChanged += new System.EventHandler(this.EmployeesListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // ColCode
            // 
            this.ColCode.Text = "Code";
            this.ColCode.Width = 120;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.Width = 120;
            // 
            // ColPosition
            // 
            this.ColPosition.Text = "Position";
            this.ColPosition.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Workers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(739, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cars";
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(64, 464);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(142, 29);
            this.addEmployeeBtn.TabIndex = 30;
            this.addEmployeeBtn.Text = "Add";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(336, 464);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(153, 29);
            this.deleteEmployeeBtn.TabIndex = 31;
            this.deleteEmployeeBtn.Text = "Delete";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(739, 464);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(153, 29);
            this.DeleteProductBtn.TabIndex = 35;
            this.DeleteProductBtn.Text = "Delete";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(591, 464);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(142, 29);
            this.AddProductBtn.TabIndex = 34;
            this.AddProductBtn.Text = "Add";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductsListView
            // 
            this.ProductsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ProductsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.ProductsListView.FullRowSelect = true;
            this.ProductsListView.HideSelection = false;
            this.ProductsListView.Location = new System.Drawing.Point(591, 321);
            this.ProductsListView.Name = "ProductsListView";
            this.ProductsListView.Size = new System.Drawing.Size(301, 121);
            this.ProductsListView.TabIndex = 36;
            this.ProductsListView.UseCompatibleStateImageBehavior = false;
            this.ProductsListView.View = System.Windows.Forms.View.Details;
            this.ProductsListView.ItemActivate += new System.EventHandler(this.ProductsListView_ItemActivate);
            this.ProductsListView.SelectedIndexChanged += new System.EventHandler(this.ProductsListView_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "#";
            this.columnHeader8.Width = 30;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Brand";
            this.columnHeader9.Width = 65;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Model";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Sell cost";
            this.columnHeader11.Width = 100;
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(15, 535);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(960, 29);
            this.SAVE.TabIndex = 37;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // CarShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 580);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.ProductsListView);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.deleteEmployeeBtn);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmployeesListView);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label1);
            this.Name = "CarShopForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView EmployeesListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button deleteEmployeeBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColPosition;
        private System.Windows.Forms.ColumnHeader ColCode;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.ListView ProductsListView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
