using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowReviewApp.Models
{
    public class TagViewModel
    {
        public string Name { get; set; }

        public long Count { get; set; }

        public decimal Average { get; set; }
    }
}
