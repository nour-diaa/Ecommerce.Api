﻿using System.Collections.Generic;
using Streetwood.Core.Domain.Entities;

namespace Streetwood.Test.Helpers
{
    public class ProductsOrderHelper
    {
        public static IEnumerable<ProductOrder> GetProductsOrders()
        {
            var productOrder = new ProductOrder(2, "Product order comment");
            productOrder.AddProduct(ProductFactory.GetProductWithoutCharms());
            productOrder.SetFinalPrice(99);

            var productOrderWitchCharm = new ProductOrder(1, "Please give give");
            productOrderWitchCharm.AddProduct(ProductFactory.GetProductWithCharms());
            productOrderWitchCharm.AddProductOrderCharms(ProductOrderCharmsFactory.GetMultipleProductOrderCharms(3));
            productOrderWitchCharm.SetFinalPrice(40);

            return new List<ProductOrder>
            {
                productOrder,
                productOrderWitchCharm
            };
        }
    }
}
