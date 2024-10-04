using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLevelSiCharp.Models.Transformers;

public class CreateProductDto
{
    [Required]
    public string Name { get; set; }
    public double Price { get; set; }

    public int Stock { get; set; }

    public string CategoryName { get; set; }
}
