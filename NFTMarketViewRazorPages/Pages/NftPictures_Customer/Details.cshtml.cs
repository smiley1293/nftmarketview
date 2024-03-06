using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NFTMarketViewRepository;
using NFTMatketViewBusinessObject.Models;

namespace NFTMarketViewRazorPages.Pages.NftPictures
{
    public class Customer_SiteModel : PageModel
    {
        private readonly INftPicturesRepository _nftPicturesRepository;

        public Customer_SiteModel(INftPicturesRepository nftPicturesRepository)
        {
            _nftPicturesRepository = nftPicturesRepository;
        }

      public NftPicture NftPicture { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _nftPicturesRepository.GetNftPictures() == null)
            {
                return NotFound();
            }

            var nftpicture = _nftPicturesRepository.GetNftPicture(id);
            if (nftpicture == null)
            {
                return NotFound();
            }
            else 
            {
                NftPicture = nftpicture;
            }
            return Page();
        }
    }
}
