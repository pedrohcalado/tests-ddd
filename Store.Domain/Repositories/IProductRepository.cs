using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Repositories.Interfaces
{
    public interface IProductRepository
    {
        // faz mais sentido criar um get qeu pega todos os produtos de uma vez baseado
        // numa lista de Ids do que fazer um get por id pra fazer várias consultas
        // no banco se tivermos mais de um produto a ser buscado
        IEnumerable<Product> Get(IEnumerable<Guid> ids);
    }
}
