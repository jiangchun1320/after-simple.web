using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_simple.Core.Models
{
    public class Repayment : BaseModel
    {

        [Required]
        public decimal Principal { get; set; }

        [Required]
        public decimal Interest { get; set; }
    }
}
