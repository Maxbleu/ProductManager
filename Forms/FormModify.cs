using Administrator_of_Products.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator_of_Products.Forms
{
    public partial class FormModify : Form
    {
        private PrincipalForm PrincipalForm { get; }

        private ProductModel CheckedProduct { get; }

        public FormModify(PrincipalForm principalForm, ProductModel checkedProduct)
        {
            InitializeComponent();
            this.PrincipalForm = principalForm;
            this.CheckedProduct = checkedProduct;
        }

        private void FormModify_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.CheckedProduct.Id_Product.ToString();
            this.textBox2.Text = this.CheckedProduct.Name;
            this.textBox3.Text = this.CheckedProduct.Preci.ToString();
            this.textBox4.Text = this.CheckedProduct.Type_Product;
            this.textBox5.Text = this.CheckedProduct.Name_Provider;
            pictureBox1.Load(this.CheckedProduct.Product_Picture_Path);
            pictureBox1.Show();
        }

        public void KeepNewProduct(ProductModel product)
        {
            for(int i = 0; i<this.PrincipalForm._productManager.ListProducts.Count; i++)
            {
                if (this.PrincipalForm._productManager.ListProducts[i].Id_Product == CheckedProduct.Id_Product)
                {
                    this.PrincipalForm._productManager.ListProducts[i] = product;
                }
            }
        }

        private async void Guardar_Click(object sender, EventArgs e)
        {
            ProductModel product = new ProductModel(int.Parse(this.textBox1.Text),this.textBox2.Text,float.Parse(this.textBox3.Text),this.textBox4.Text,this.textBox5.Text,this.CheckedProduct);
            KeepNewProduct(product);
            await this.PrincipalForm._productManager.ModifyProductAsync(product);
            MessageBox.Show("El cambio ha sido guardado en la base de datos", "Warning", MessageBoxButtons.OK);
        }
    }
}
