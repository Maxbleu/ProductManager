using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Administrator_of_Products.Models
{
    public class ProductModel
    {
        public int Id_Product { get; set; }
        
        public string Name { get; set; }

        public float Preci { get; set; }

        public string Type_Product { get; set; }

        public string Name_Provider { get; set; }

        public string Product_Picture_Path { get; set; }


        public ProductModel(int id_Product, string name, float preci, string type_Product, string name_Provider, string product_Picture_Path)
        {
            this.Id_Product = id_Product;
            this.Name = name;
            this.Preci = preci;
            this.Type_Product = type_Product;
            this.Name_Provider = name_Provider;
            this.Product_Picture_Path = product_Picture_Path;
        }


        public ProductModel(string name, float preci, string type_Product, string name_Provider, string product_Picture_Path)
        {
            this.Name = name;
            this.Preci = preci;
            this.Type_Product = type_Product;
            this.Name_Provider = name_Provider;
            this.Product_Picture_Path = product_Picture_Path;
        }


        public ProductModel(int id_Product, string name, float preci, string type_Product, string name_Provider, ProductModel checkedProduct)
        {
            if(id_Product != checkedProduct.Id_Product)
            {
                this.Id_Product = id_Product;
            }
            else
            {
                this.Id_Product = checkedProduct.Id_Product;
            }

            if(name != checkedProduct.Name)
            {
                this.Name = name;
            }
            else
            {
                this.Name = checkedProduct.Name;
            }

            if(preci != checkedProduct.Preci)
            {
                this.Preci = preci; 
            }
            else
            {
                this.Preci = checkedProduct.Preci;
            }

            if(type_Product != checkedProduct.Type_Product)
            {
                this.Type_Product = type_Product;
            }
            else
            {
                this.Type_Product = checkedProduct.Type_Product;
            }

            if(name_Provider != checkedProduct.Name_Provider)
            {
                this.Name_Provider = name_Provider;
            }
            else
            {
                this.Name_Provider = checkedProduct.Name_Provider;  
            }
        }


        public ProductModel()
        {

        }
    }
}
