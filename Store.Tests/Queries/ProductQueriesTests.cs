using Store.Domain.Entities;
using Store.Domain.Queries;
using Store.Tests.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.Tests.Queries
{
    public class ProductQueriesTests
    {
        private IList<Product> _product;


        public ProductQueriesTests()
        {
            _product = new List<Product>();
            _product.Add(new Product("Produto 1", 10, true));
            _product.Add(new Product("Produto 2", 10, true));
            _product.Add(new Product("Produto 3", 10, true));
            _product.Add(new Product("Produto 4", 10, false));
            _product.Add(new Product("Produto 5", 10, false));
        }

        [Fact]
        public void Dado_a_consulta_de_produtos_ativos_deve_retornar_3()
        {
            var result = _product.AsQueryable().Where(ProductQueries.GetActiveProducts());
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void Dado_a_consulta_de_produtos_inativos_deve_retornar_2()
        {
            var result = _product.AsQueryable().Where(ProductQueries.GetInactiveProducts());
            Assert.Equal(2, result.Count());
        }
    }
}
