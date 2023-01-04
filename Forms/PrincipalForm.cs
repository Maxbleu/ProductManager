using Administrator_of_Products.Forms;
using Administrator_of_Products.Interfaces;
using Administrator_of_Products.Managers;
using Administrator_of_Products.Models;

namespace Administrator_of_Products
{
    public partial class PrincipalForm : Form
    {
        private FormInsert _formInsert { get; set; }
        private FormModify _formModify { get; set; }

        public ProductManager _productManager { get; }
        private GraphicInterfaceManager _graphicInterfaceManager { get; }

        public PrincipalForm(ProductManager productManager, GraphicInterfaceManager graphicInterfaceManager)
        {
            InitializeComponent();
            this._productManager = productManager;
            this._graphicInterfaceManager = graphicInterfaceManager;
        }





        private async void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            dataGridView1.DataSource = null;
        }





        private void List_Products_Click(object sender, EventArgs e)
        {
            this._graphicInterfaceManager.ShowProductsInCheckedListBox(checkedListBox1);
        }





        private void List_Data_Products_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if(checkedListBox1.CheckedItems.Count > 0)
            {
                var listCheckedProducts = this._graphicInterfaceManager.GetCheckedProducts(checkedListBox1);
                this.dataGridView1.DataSource = listCheckedProducts;
            }
        }





        private async void Delete_Product_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count > 0)
            {
                var checkedProduct = this._graphicInterfaceManager.GetCheckedProduct(checkedListBox1);
                this._productManager.ListProducts.RemoveAt(checkedProduct.position);
                await this._productManager.DeleteProductAsync(checkedProduct.product.Id_Product);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminarlo", "Warning", MessageBoxButtons.OK);
            }
        }





        private void Insert_Product_Click(object sender, EventArgs e)
        {
            this._formInsert = new FormInsert(this);
            this._formInsert.Show();
        }





        private void Modify_Product_Click(object sender, EventArgs e)
        {
            if(this.checkedListBox1.CheckedItems.Count > 0)
            {
                ProductModel product = this._graphicInterfaceManager.GetCheckedProduct(checkedListBox1.CheckedItems[0].ToString());
                this._formModify = new FormModify(this,product);
                this._formModify.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista para modificar un producto","Warning",MessageBoxButtons.OK);
            }
        }





        private async void Refresh_List_Click(object sender, EventArgs e)
        {
            await this._productManager.SelectProductsAsync();
        }
    }
}