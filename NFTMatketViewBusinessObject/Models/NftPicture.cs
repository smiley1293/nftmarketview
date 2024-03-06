using System;
using System.Collections.Generic;

namespace NFTMatketViewBusinessObject.Models
{
    public partial class NftPicture
    {
        public string NftId { get; set; } = null!;
        public string NftName { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
    }
}
