using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NFTMarketViewRazorPages.Filters;
using NFTMarketViewRepository;
using NFTMatketViewBusinessObject.Models;

namespace NFTMarketViewRazorPages.Pages.NftPictures_Customer
{
    [Customer]
    public class Customer_SiteModel : PageModel
    {
        private readonly INftPicturesRepository _nftPicturesRepository;

        public Customer_SiteModel(INftPicturesRepository nftPicturesRepository)
        {
            _nftPicturesRepository = nftPicturesRepository;
        }

        public IList<NftPicture> NftPicture { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_nftPicturesRepository.GetNftPictures() != null)
            {
                NftPicture = _nftPicturesRepository.GetNftPictures();
            }
        }
    }
}
