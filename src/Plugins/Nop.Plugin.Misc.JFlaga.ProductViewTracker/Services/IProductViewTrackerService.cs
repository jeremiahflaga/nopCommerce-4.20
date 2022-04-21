using System;
using System.Collections.Generic;
using System.Text;
using Nop.Plugin.Misc.JFlaga.ProductViewTracker.Domains;

namespace Nop.Plugin.Misc.JFlaga.ProductViewTracker.Services
{
    public interface IProductViewTrackerService
    {
        /// <summary>
        /// Logs the specified record.
        /// </summary>
        /// <param name="record">The record.</param>
        void Log(ProductViewTrackerRecord record);
    }
}
