using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLevelSiCharp.Models.Transformers.Mappers;

public class ElmaMapper
{
    public static Elma ConvertToEntity(CreateElmaDto createElmaDto)
    {
        return new Elma
        {
            Color = createElmaDto.Color,
            KgPrice = createElmaDto.KgPrice,
            SellerName = createElmaDto.SellerName,
            Type = createElmaDto.Type,
        };
    }

    public static ElmaResponseDto ConvertToResponseDto(Elma elma)
    {
        return new ElmaResponseDto
            {
                KgPrice = elma.KgPrice,
                Color = elma.Color,
                Type = elma.Type,   

        };
    }
}
