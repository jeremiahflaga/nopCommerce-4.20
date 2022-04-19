using System;
using System.Collections.Generic;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.JFlaga.BasicPlugin
{
    public class BasicPlugin : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false; // set to false if you want to show this in the Configuration->Widgets page in the Admin Panel

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "Widgets.JFlaga.BasicPlugin";
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.HomepageBeforeCategories };
        }
    }
}
