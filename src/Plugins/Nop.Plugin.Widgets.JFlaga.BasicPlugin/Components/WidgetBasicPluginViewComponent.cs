using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.JFlaga.BasicPlugin.Models;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.JFlaga.BasicPlugin.Components
{
    [ViewComponent(Name= "Widgets.JFlaga.BasicPlugin")]
    public class WidgetBasicPluginViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            var model = new PublicInfoModel
            {
                DisplayText = "This is the Widgets.JFlaga.BasicPlugin's text."
            };

            return View("~/Plugins/Widgets.JFlaga.BasicPlugin/Views/PublicInfo.cshtml", model);
        }
    }
}
