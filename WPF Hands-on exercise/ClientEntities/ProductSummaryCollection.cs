using System.Collections.Generic;

namespace HandsOnLab1.ClientEntities
{
    /// <summary>
    /// Collection of <see cref="ProductSummary"/> entities.
    /// </summary>
    /// <seealso cref="ClientEntities.Product"/>
    /// <seealso cref="ClientEntities.ProductSummary"/>
    public class ProductSummaryCollection : System.Collections.ObjectModel.ObservableCollection<ProductSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSummaryCollection"/> class.
        /// </summary>
        public ProductSummaryCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSummaryCollection"/> class.
        /// </summary>
        /// <param name="list">The list from which the elements are copied.</param>
        /// <exception cref="T:System.ArgumentNullException">The list parameter cannot be null.</exception>
        public ProductSummaryCollection(List<ProductSummary> list)
            : base(list)
        {
        }
    }
}
