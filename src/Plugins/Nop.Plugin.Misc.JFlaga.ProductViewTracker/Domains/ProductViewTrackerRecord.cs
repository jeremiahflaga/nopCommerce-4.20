using Nop.Core;

namespace Nop.Plugin.Misc.JFlaga.ProductViewTracker.Domains
{
    public partial class ProductViewTrackerRecord : BaseEntity
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int CustomerId { get; set; }
        public virtual string IpAddress { get; set; }
        public virtual bool IsRegistered { get; set; }
    }
}
