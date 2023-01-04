using Administrator_of_Products.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_of_Products.Interfaces
{
    public interface IPrincipalFormFactory
    {
        PrincipalForm Create(ProductManager productManager, GraphicInterfaceManager graphicInterfaceManager);
    }
}
