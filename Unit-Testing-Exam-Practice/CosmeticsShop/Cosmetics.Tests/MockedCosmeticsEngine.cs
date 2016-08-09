using Cosmetics.Contracts;
using Cosmetics.Engine;
using System;
using System.Collections.Generic;

namespace Cosmetics.Tests
{
    public class MockedCosmeticsEngine : CosmeticsEngine
    {

        private ICosmeticsFactory factory;
        private IShoppingCart shoppingCart;

        public MockedCosmeticsEngine(ICosmeticsFactory factory, IShoppingCart shoppingCart) 
            : base(factory, shoppingCart)
        {
        }
        
        public IDictionary<string, ICategory> Categories
        {
            get
            {
                return base.categories;
            }
        }

        public IDictionary<string, IProduct> Products
        {
            get
            {
                return base.products;
            }
        }
    }
}
