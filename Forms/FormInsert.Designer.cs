namespace Administrator_of_Products.Forms
{
    partial class FormInsert
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Insertar = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.Preci = new System.Windows.Forms.Label();
            this.Type_Product = new System.Windows.Forms.Label();
            this.Name_Provider = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Product_Picture_Path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(350, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(350, 250);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 27);
            this.textBox5.TabIndex = 5;
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(391, 370);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(94, 29);
            this.Insertar.TabIndex = 6;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(234, 60);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(106, 20);
            this.Name.TabIndex = 8;
            this.Name.Text = "Name_Product";
            // 
            // Preci
            // 
            this.Preci.AutoSize = true;
            this.Preci.Location = new System.Drawing.Point(242, 128);
            this.Preci.Name = "Preci";
            this.Preci.Size = new System.Drawing.Size(98, 20);
            this.Preci.TabIndex = 9;
            this.Preci.Text = "Preci_Product";
            // 
            // Type_Product
            // 
            this.Type_Product.AutoSize = true;
            this.Type_Product.Location = new System.Drawing.Point(243, 184);
            this.Type_Product.Name = "Type_Product";
            this.Type_Product.Size = new System.Drawing.Size(97, 20);
            this.Type_Product.TabIndex = 10;
            this.Type_Product.Text = "Type_Product";
            // 
            // Name_Provider
            // 
            this.Name_Provider.AutoSize = true;
            this.Name_Provider.Location = new System.Drawing.Point(230, 253);
            this.Name_Provider.Name = "Name_Provider";
            this.Name_Provider.Size = new System.Drawing.Size(110, 20);
            this.Name_Provider.TabIndex = 11;
            this.Name_Provider.Text = "Name_Provider";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 27);
            this.textBox1.TabIndex = 12;
            // 
            // Product_Picture_Path
            // 
            this.Product_Picture_Path.AutoSize = true;
            this.Product_Picture_Path.Location = new System.Drawing.Point(195, 320);
            this.Product_Picture_Path.Name = "Product_Picture_Path";
            this.Product_Picture_Path.Size = new System.Drawing.Size(145, 20);
            this.Product_Picture_Path.TabIndex = 13;
            this.Product_Picture_Path.Text = "Product_Picture_Path";
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 485);
            this.Controls.Add(this.Product_Picture_Path);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Name_Provider);
            this.Controls.Add(this.Type_Product);
            this.Controls.Add(this.Preci);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Text = "FormInsert";
            this.Load += new System.EventHandler(this.FormInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button Insertar;
        private Label Name;
        private Label Preci;
        private Label Type_Product;
        private Label Name_Provider;
        private TextBox textBox1;
        private Label Product_Picture_Path;
    }
}