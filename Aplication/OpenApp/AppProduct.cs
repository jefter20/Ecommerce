using Aplication.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;

        public AppProduct(IProduct IProduct , IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }

        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }

        public async Task Add(Product Objeto)
        {
            await _IProduct.Add(Objeto);
        }

        public async Task Update(Product Objeto)
        {
            await _IProduct.Update(Objeto);
        }

        public async Task Delete(Product Objeto)
        {
            await _IProduct.Delete(Objeto);
        }

        public async Task<Product> GetById(int id)
        {
            return await _IProduct.GetById(id);
        }

        public async Task<List<Product>> List()
        {
            return await _IProduct.List();
        }
    }
}
