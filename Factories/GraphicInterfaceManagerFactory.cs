using Administrator_of_Products.Interfaces;
using Administrator_of_Products.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_of_Products.Factories
{
    public class GraphicInterfaceManagerFactory : IGraphicInterfaceManagerFactory
    {
        public GraphicInterfaceManager Create(ref ProductManager productManager)
        {
            return new GraphicInterfaceManager(ref productManager);
        }
    }
}
