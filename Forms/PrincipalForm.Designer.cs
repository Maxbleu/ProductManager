namespace Administrator_of_Products
{
    partial class PrincipalForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_Products = new System.Windows.Forms.Button();
            this.Delete_Product = new System.Windows.Forms.Button();
            this.Insert_Product = new System.Windows.Forms.Button();
            this.Modify_Product = new System.Windows.Forms.Button();
            this.List_Data_Products = new System.Windows.Forms.Button();
            this.Refresh_List = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(56, 38);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(143, 202);
            this.checkedListBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Product,
            this.Name,
            this.Preci,
            this.Type_Product,
            this.Name_Provider});
            this.dataGridView1.Location = new System.Drawing.Point(40, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(723, 131);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id_Product
            // 
            this.Id_Product.HeaderText = "Id_Product";
            this.Id_Product.MinimumWidth = 6;
            this.Id_Product.Name = "Id_Product";
            this.Id_Product.ReadOnly = true;
            this.Id_Product.Width = 134;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 134;
            // 
            // Preci
            // 
            this.Preci.HeaderText = "Preci";
            this.Preci.MinimumWidth = 6;
            this.Preci.Name = "Preci";
            this.Preci.ReadOnly = true;
            this.Preci.Width = 134;
            // 
            // Type_Product
            // 
            this.Type_Product.HeaderText = "Type_Product";
            this.Type_Product.MinimumWidth = 6;
            this.Type_Product.Name = "Type_Product";
            this.Type_Product.ReadOnly = true;
            this.Type_Product.Width = 134;
            // 
            // Name_Provider
            // 
            this.Name_Provider.HeaderText = "Name_Provider";
            this.Name_Provider.MinimumWidth = 6;
            this.Name_Provider.Name = "Name_Provider";
            this.Name_Provider.ReadOnly = true;
            this.Name_Provider.Width = 134;
            // 
            // List_Products
            // 
            this.List_Products.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.List_Products.Location = new System.Drawing.Point(258, 82);
            this.List_Products.Name = "List_Products";
            this.List_Products.Size = new System.Drawing.Size(141, 64);
            this.List_Products.TabIndex = 2;
            this.List_Products.Text = "List_Products";
            this.List_Products.UseVisualStyleBackColor = true;
            this.List_Products.Click += new System.EventHandler(this.List_Products_Click);
            // 
            // Delete_Product
            // 
            this.Delete_Product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete_Product.Location = new System.Drawing.Point(405, 82);
            this.Delete_Product.Name = "Delete_Product";
            this.Delete_Product.Size = new System.Drawing.Size(141, 64);
            this.Delete_Product.TabIndex = 3;
            this.Delete_Product.Text = "Delete_Product";
            this.Delete_Product.UseVisualStyleBackColor = true;
            this.Delete_Product.Click += new System.EventHandler(this.Delete_Product_Click);
            // 
            // Insert_Product
            // 
            this.Insert_Product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Insert_Product.Location = new System.Drawing.Point(258, 152);
            this.Insert_Product.Name = "Insert_Product";
            this.Insert_Product.Size = new System.Drawing.Size(141, 64);
            this.Insert_Product.TabIndex = 5;
            this.Insert_Product.Text = "Insert_Product";
            this.Insert_Product.UseVisualStyleBackColor = true;
            this.Insert_Product.Click += new System.EventHandler(this.Insert_Product_Click);
            // 
            // Modify_Product
            // 
            this.Modify_Product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Modify_Product.Location = new System.Drawing.Point(405, 152);
            this.Modify_Product.Name = "Modify_Product";
            this.Modify_Product.Size = new System.Drawing.Size(141, 64);
            this.Modify_Product.TabIndex = 6;
            this.Modify_Product.Text = "Modify_Product";
            this.Modify_Product.UseVisualStyleBackColor = true;
            this.Modify_Product.Click += new System.EventHandler(this.Modify_Product_Click);
            // 
            // List_Data_Products
            // 
            this.List_Data_Products.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.List_Data_Products.Location = new System.Drawing.Point(552, 82);
            this.List_Data_Products.Name = "List_Data_Products";
            this.List_Data_Products.Size = new System.Drawing.Size(142, 64);
            this.List_Data_Products.TabIndex = 7;
            this.List_Data_Products.Text = "List_Data_Products";
            this.List_Data_Products.UseVisualStyleBackColor = true;
            this.List_Data_Products.Click += new System.EventHandler(this.List_Data_Products_Click);
            // 
            // Refresh_List
            // 
            this.Refresh_List.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Refresh_List.Location = new System.Drawing.Point(552, 152);
            this.Refresh_List.Name = "Refresh_List";
            this.Refresh_List.Size = new System.Drawing.Size(141, 64);
            this.Refresh_List.TabIndex = 8;
            this.Refresh_List.Text = "Refresh_List";
            this.Refresh_List.UseVisualStyleBackColor = true;
            this.Refresh_List.Click += new System.EventHandler(this.Refresh_List_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(822, 465);
            this.Controls.Add(this.Refresh_List);
            this.Controls.Add(this.List_Data_Products);
            this.Controls.Add(this.Modify_Product);
            this.Controls.Add(this.Insert_Product);
            this.Controls.Add(this.Delete_Product);
            this.Controls.Add(this.List_Products);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBox1);
            
            this.Text = "PrincipalForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private DataGridView dataGridView1;
        private Button List_Products;
        private Button Delete_Product;
        private Button Insert_Product;
        private Button Modify_Product;
        private Button List_Data_Products;
        private Button Refresh_List;
        private DataGridViewTextBoxColumn Id_Product;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Preci;
        private DataGridViewTextBoxColumn Type_Product;
        private DataGridViewTextBoxColumn Name_Provider;
    }
}