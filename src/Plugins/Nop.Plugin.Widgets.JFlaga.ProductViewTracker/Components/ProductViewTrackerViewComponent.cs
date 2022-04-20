using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;
using Nop.Plugin.Widgets.JFlaga.ProductViewTracker.Domains;
using Nop.Plugin.Widgets.JFlaga.ProductViewTracker.Services;
using Nop.Services.Catalog;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;
using System;

namespace Nop.Plugin.Widgets.JFlaga.ProductViewTracker.Components
{
    [ViewComponent(Name = "Nop.Plugin.Widgets.JFlaga.ProductViewTracker")]
    public class ProductViewTrackerViewComponent : NopViewComponent
    {
        private readonly IProductService _productService;
        private readonly IProductViewTrackerService _productViewTrackerService;
        private readonly IWorkContext _workContext;

        public ProductViewTrackerViewComponent(
            IWorkContext workContext,
            IProductViewTrackerService productViewTrackerService,
            IProductService productService)
        {
            _workContext = workContext;
            _productViewTrackerService = productViewTrackerService;
            _productService = productService;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            var productDetails = (ProductDetailsModel)additionalData;

            //Read from the product service
            Product productById = _productService.GetProductById(productDetails.Id);

            //If the product exists we will log it
            if (productById != null)
            {
                //Setup the product to save
                var record = new ProductViewTrackerRecord();
                record.ProductId = productDetails.Id;
                record.ProductName = productById.Name;
                record.CustomerId = _workContext.CurrentCustomer.Id;
                record.IpAddress = _workContext.CurrentCustomer.LastIpAddress;
                record.IsRegistered = _workContext.CurrentCustomer.IsRegistered();

                //Map the values we're interested in to our new entity
                _productViewTrackerService.Log(record);
            }

            return Content("");
        }
    }
}
