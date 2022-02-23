using System;
using System.Collections.Generic;
using core.Domain;

namespace core.Repository
{
    public interface IProduct
    {
        bool AddProduct(MProduct Product); 
        bool UpdateProduct(MProduct Product);
        bool DeleteProduct(int id);
        List<MProduct> ShowActiveStatusProduct();
    }
}