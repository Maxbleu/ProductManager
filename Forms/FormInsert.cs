using Administrator_of_Products.Managers;
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
    public partial class FormInsert : Form
    {
        private PrincipalForm PrincipalForm { get; }

        public FormInsert(PrincipalForm principalForm)
        {
            InitializeComponent();
            this.PrincipalForm = principalForm;
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
        }

        //Testear el boton para comprobar si funciona correctamente 
        private async void Insertar_Click(object sender, EventArgs e)
        {
            ProductModel newProduct = new ProductModel(this.textBox2.Text,float.Parse(this.textBox3.Text),this.textBox4.Text,this.textBox5.Text, this.textBox1.Text);
            this.PrincipalForm._productManager.ListProducts.Add(newProduct);
            await this.PrincipalForm._productManager.InsertProductAsync(newProduct);
            MessageBox.Show("El producto ha sido insertado en la base de datos","Warning",MessageBoxButtons.OK);
        }
    }
}
