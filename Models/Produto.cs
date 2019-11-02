using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Produto
    {
        [Key]
        public int ID_PRODUTO { get; set; }
        [MaxLength(44)]
        public string DESC_PRODUTO { get; set; }
        public double? EST_PRODUTO { get; set; }
        public double? VAL_PRODUTO { get; set; }


    }
}
