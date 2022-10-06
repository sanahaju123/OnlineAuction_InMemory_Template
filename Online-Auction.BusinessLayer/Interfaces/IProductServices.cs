﻿using Online_Auction.BusinessLayer.ViewModels;
using Online_Auction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Auction.BusinessLayer.Interfaces
{
    public interface IProductServices
    {
        Task<Product> Register(Product product);
        Task<Product> FindProductById(long productId);
        Task<Product> UpdateProduct(RegisterProductViewModel model);
        Task<IEnumerable<Product>> ListAllProducts();
        Task<IEnumerable<Product>> GetProductByCategoryId(long categoryId);
        Task<IEnumerable<Product>> GetProductBySellerId(long sellerId);

    }
}
