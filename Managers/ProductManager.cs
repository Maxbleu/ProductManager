using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administrator_of_Products.Models;
using Biblioteca_Sql_Sever;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Administrator_of_Products.Managers
{
    public class ProductManager
    {
        private ISqlServer SqlServer { get; }
        public List<ProductModel> ListProducts { get; set; }
        private string ConnectionString { get; }

        public ProductManager(ISqlServer sqlServer, string connectionString)
        {
            this.SqlServer = sqlServer;
            this.ConnectionString = connectionString;
        }

        /// <summary>
        /// Método para selectionar los datos de la tabla productos
        /// </summary>
        /// <returns></returns>
        public async Task SelectProductsAsync()
        {
            await this.SqlServer.ExecuteReaderAsync("Select_Products",this.ConnectionString,CommandType.StoredProcedure,DataHandlerAsync);
        }

        private async Task DataHandlerAsync(SqlDataReader sqlDataReader)
        {
            this.ListProducts = new List<ProductModel>();

            if (sqlDataReader.HasRows)
            {
                while (await sqlDataReader.ReadAsync())
                {
                    ProductModel product = new ProductModel();
                    if (!await sqlDataReader.IsDBNullAsync(0))
                    {
                        product.Id_Product = sqlDataReader.GetInt32(0);
                    }
                    if (!await sqlDataReader.IsDBNullAsync(1))
                    {
                        product.Name = sqlDataReader.GetString(1);
                    }
                    if (!await sqlDataReader.IsDBNullAsync(2))
                    {
                        product.Preci = sqlDataReader.GetFloat(2);
                    }
                    if (!await sqlDataReader.IsDBNullAsync(3))
                    {
                        product.Type_Product = sqlDataReader.GetString(3);
                    }
                    if (!await sqlDataReader.IsDBNullAsync(4))
                    {
                        product.Name_Provider = sqlDataReader.GetString(4);
                    }
                    if(!await sqlDataReader.IsDBNullAsync(5))
                    {
                        product.Product_Picture_Path = sqlDataReader.GetString(5);
                    }
                    this.ListProducts.Add(product);
                }
            }
        }

        /// <summary>
        /// Método para insertar productos en la base de datos
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task InsertProductAsync(ProductModel product)
        {
            SqlParameter[] parameters = GetSqlParameters(product.Name, product.Preci, product.Type_Product, product.Name_Provider, product.Product_Picture_Path);
            await this.SqlServer.ExecuteNonQueryAsync("Insert_Products",this.ConnectionString,CommandType.StoredProcedure,parameters);
        }

        private SqlParameter[] GetSqlParameters(string name, float preci, string type, string name_Provider, string product_Picture_Path)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];

            SqlParameter name_Parameter = new SqlParameter()
            {
                ParameterName = "@name_Product",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = name
            };
            sqlParameters[0] = name_Parameter;

            SqlParameter preci_Product = new SqlParameter()
            {
                ParameterName = "@preci_Product",
                SqlDbType = SqlDbType.Real,
                Direction = ParameterDirection.Input,
                Value = preci
            };
            sqlParameters[1] = preci_Product;

            SqlParameter type_Product = new SqlParameter()
            {
                ParameterName = "@type_Product",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = type
            };
            sqlParameters[2] = type_Product;

            SqlParameter name_Provider_Product = new SqlParameter()
            {
                ParameterName = "@name_Provider_Product",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = name_Provider
            };
            sqlParameters[3] = name_Provider_Product;

            SqlParameter productPicturePath = new SqlParameter()
            {
                ParameterName = "@product_Picture_Path",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = product_Picture_Path
            };
            sqlParameters[4] = productPicturePath;

            return sqlParameters;
        }

        /// <summary>
        /// Método para modificar un producto de la base de datos
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task ModifyProductAsync(ProductModel product)
        {
            SqlParameter[] sqlParameters = GetSqlParameters(product);
            await this.SqlServer.ExecuteNonQueryAsync("Modify_Products",this.ConnectionString,CommandType.StoredProcedure,sqlParameters);
        }

        private SqlParameter[] GetSqlParameters(ProductModel product)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];

            SqlParameter id_Product_Parameter = new SqlParameter()
            {
                ParameterName = "@id_Product",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = product.Id_Product
            };
            sqlParameters[0] = id_Product_Parameter;

            SqlParameter name_Product_Parameter = new SqlParameter()
            {
                ParameterName = "@name_Product",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = product.Name
            };
            sqlParameters[1] = name_Product_Parameter;

            SqlParameter preci_Product_Parameter = new SqlParameter()
            {
                ParameterName = "@preci_Product",
                SqlDbType = SqlDbType.Real,
                Direction = ParameterDirection.Input,
                Value = product.Preci
            };
            sqlParameters[2] = preci_Product_Parameter;

            SqlParameter type_Product_Parameter = new SqlParameter()
            {
                ParameterName = "@type_Product",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = product.Type_Product
            };
            sqlParameters[3] = type_Product_Parameter;

            SqlParameter name_Provider_Parameter = new SqlParameter()
            {
                ParameterName = "@name_Provider_Product",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = product.Name_Provider
            };
            sqlParameters[4] = name_Provider_Parameter;


            return sqlParameters;
        }

        /// <summary>
        /// Método para eliminar un producto de la base de datos
        /// </summary>
        /// <param name="id_Product"></param>
        /// <returns></returns>
        public async Task DeleteProductAsync(int id_Product)
        {
            SqlParameter id_Product_Parameter = new SqlParameter()
            {
                ParameterName = "@id_Product",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = id_Product
            };
            await this.SqlServer.ExecuteNonQueryAsync("Delete_Product",this.ConnectionString,CommandType.StoredProcedure,id_Product_Parameter);
        }
    }
}
