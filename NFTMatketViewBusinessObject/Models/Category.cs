using System;
using System.Collections.Generic;

namespace NFTMatketViewBusinessObject.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
    }
}
