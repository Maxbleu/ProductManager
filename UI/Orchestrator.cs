using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administrator_of_Products.Interfaces;
using Administrator_of_Products.Managers;
using Administrator_of_Products.Models;
using Biblioteca_Sql_Sever;
using Microsoft.Extensions.Options;

namespace Administrator_of_Products.UI
{
    public class Orchestrator : IOrchestrator
    {
        private IOptionsMonitor<ConfigModel> Options { get; set; }
        private ConfigModel Config { get; set; }
        private IDisposable OptionsDisposable { get; set; }

        private ISqlServer _sqlServer { get; }
        private IProductManagerFactory _productManagerFactory { get; }
        private IPrincipalFormFactory _principalFormFactory { get; }
        private IGraphicInterfaceManagerFactory _graphicInterfaceManagerFactory { get; }

        public Orchestrator(IOptionsMonitor<ConfigModel> options, ISqlServer sqlServer, IProductManagerFactory productManagerFactory, IPrincipalFormFactory principalForm, IGraphicInterfaceManagerFactory graphicInterfaceManagerFactory)
        {
            this.Options = options;
            this.Config = options.CurrentValue;
            this.OptionsDisposable = options.OnChange<ConfigModel>(ReadNewConfig);

            this._sqlServer = sqlServer;
            this._productManagerFactory = productManagerFactory;
            this._principalFormFactory = principalForm;
            this._graphicInterfaceManagerFactory = graphicInterfaceManagerFactory;
        }

        private void ReadNewConfig(ConfigModel newConfig)
        {
            if (this.OptionsDisposable != null)
            {
                this.OptionsDisposable.Dispose();
                this.OptionsDisposable = null;
            }
            this.Config = newConfig;
            this.OptionsDisposable = this.Options.OnChange<ConfigModel>(ReadNewConfig);
        }


        public async Task Play()
        {
            ProductManager productManager = this._productManagerFactory.Create(this._sqlServer,this.Config.SqlConnection);
            await productManager.SelectProductsAsync();
            GraphicInterfaceManager graphicInterfaceManager = this._graphicInterfaceManagerFactory.Create(ref productManager);
            PrincipalForm principalForm = this._principalFormFactory.Create(productManager, graphicInterfaceManager);
            Application.Run(principalForm);
        }
    }
}
