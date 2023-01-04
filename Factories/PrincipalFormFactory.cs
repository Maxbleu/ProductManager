using Administrator_of_Products.Interfaces;
using Administrator_of_Products.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_of_Products.Factories
{
    public class PrincipalFormFactory : IPrincipalFormFactory
    {
        public PrincipalForm Create(ProductManager productManager,GraphicInterfaceManager graphicInterfaceManager)
        {
            return new PrincipalForm(productManager, graphicInterfaceManager);
        }
    }
}
