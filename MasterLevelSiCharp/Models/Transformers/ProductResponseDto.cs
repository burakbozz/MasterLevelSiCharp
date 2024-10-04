using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLevelSiCharp.Models.Transformers;

public class ProductResponseDto
{
    public string Name { get; set; }
    public double Price { get; set; }

    public int Stock { get; set; }

    public override string ToString()
    {
        return $"Name : {Name}, price : {Price}, " +
    $"Stock : {Stock}";
    }
}
