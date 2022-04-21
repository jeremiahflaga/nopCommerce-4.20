using System;
using System.Collections.Generic;
using System.Text;
using Nop.Plugin.Misc.JFlaga.ProductViewTracker.Data;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Misc.JFlaga.ProductViewTracker
{
    public class ProductViewTrackerPlugin : BasePlugin, IWidgetPlugin
    {
        private readonly ProductViewTrackerRecordObjectContext _context;

        public bool HideInWidgetList => false;

        public ProductViewTrackerPlugin(ProductViewTrackerRecordObjectContext context)
        {
            _context = context;
        }

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "Nop.Plugin.Misc.JFlaga.ProductViewTracker";
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.ProductDetailsBottom };
        }

        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }
    }
}
