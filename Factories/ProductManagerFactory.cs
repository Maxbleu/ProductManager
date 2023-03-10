using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administrator_of_Products.Interfaces;
using Administrator_of_Products.Managers;
using Biblioteca_Sql_Sever;

namespace Administrator_of_Products.Factories
{
    public class ProductManagerFactory : IProductManagerFactory
    {
        public Managers.ProductManager Create(ISqlServer sqlServer, string connectionString)
        {
            return new Managers.ProductManager(sqlServer, connectionString);
        }
    }
}
