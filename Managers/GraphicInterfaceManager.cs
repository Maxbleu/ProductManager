using Administrator_of_Products.Interfaces;
using Administrator_of_Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator_of_Products.Managers
{
    public class GraphicInterfaceManager 
    {
        private ProductManager _productManager { get; }

        public GraphicInterfaceManager(ref ProductManager productManager)
        {
            this._productManager = productManager;
        }

        public void ShowProductsInCheckedListBox(CheckedListBox checkedListBox)
        {
            checkedListBox.Items.Clear();

            for(int i = 0; i<this._productManager.ListProducts.Count; i++)
            {
                checkedListBox.Items.Add(this._productManager.ListProducts[i].Name);
            }
        }

        //Modificar para coger un solo producto ya que no conviene hacer un método de algo que solo voy a utilizar una vez cuando tengo más funcionalidades que requieren de un método que devuelva un solo producto
        public List<ProductModel> GetCheckedProducts(CheckedListBox checkedListBox)
        {
            List<ProductModel> listCheckedProducts = new List<ProductModel>();

            int j = 0;
            for(int i = 0; i<this._productManager.ListProducts.Count && j < checkedListBox.CheckedItems.Count; i++)
            {
                if(this._productManager.ListProducts[i].Name.Equals(checkedListBox.CheckedItems[j].ToString()))
                {
                    listCheckedProducts.Add(this._productManager.ListProducts[i]);
                    j++;
                }
            }
            return listCheckedProducts;
        }

        public (ProductModel product, int position) GetCheckedProduct(CheckedListBox checkedListBox)
        {
            ProductModel checkedProduct = new ProductModel();

            int j = 0;
            for(int i = 0; i<this._productManager.ListProducts.Count; i++)
            {
                if(checkedListBox.CheckedItems[0].ToString().Equals(this._productManager.ListProducts[i].Name))
                {
                    checkedProduct = this._productManager.ListProducts[i];
                    j = i;
                }
            }

            return (checkedProduct, j);
        }

        public ProductModel GetCheckedProduct(string nameProduct)
        {
            ProductModel product = new ProductModel();

            for(int i = 0; i<this._productManager.ListProducts.Count; i++)
            {
                if (nameProduct.Equals(this._productManager.ListProducts[i].Name))
                {
                    product = this._productManager.ListProducts[i];
                }
            }
            
            return product;
        }
    }
}
