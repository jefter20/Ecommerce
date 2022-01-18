using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;

        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public void ValidaProduct(Product product)
        {
            var validaNome = product.ValidaPropriedadeString(product.Nome, "Nome");

            var validaValor = product.ValidaPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            {
                product.Estado = true;
            }
            else
                product.Estado = false;
        }

        public async Task AddProduct(Product product)
        {
            ValidaProduct(product);

            if (product.Estado == true) 
            {
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            ValidaProduct(product);

            if (product.Estado == true)
            {
                await _IProduct.Update(product);
            }
        }
    }
}
