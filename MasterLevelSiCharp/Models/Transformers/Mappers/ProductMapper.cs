using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLevelSiCharp.Models.Transformers.Mappers;

public class ProductMapper
{
    public static Product ConvertToEntity(CreateProductDto createProductDto)
    {
        return new Product
        {
            Name = createProductDto.Name,
            Price = createProductDto.Price,
            Stock = createProductDto.Stock,
            CategoryName = createProductDto.CategoryName,   
            
        };
    }

    public static ProductResponseDto ConvertToResponseDto(Product product)
    {
        return new ProductResponseDto
        {
            Name = product.Name,
            Price = product.Price,
            Stock = product.Stock,

        };
    }
}
