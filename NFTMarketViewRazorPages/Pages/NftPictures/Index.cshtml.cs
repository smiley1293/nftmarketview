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

namespace NFTMarketViewRazorPages.Pages.NftPictures
{
    [Admin]
    public class IndexModel : PageModel
    {
        private readonly INftPicturesRepository _nftPicturesRepository;

        public IndexModel(INftPicturesRepository nftPicturesRepository)
        {
            _nftPicturesRepository = nftPicturesRepository;
        }

        public IList<NftPicture> NftPicture { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_nftPicturesRepository.GetNftPictures() != null)
            {
                NftPicture = _nftPicturesRepository.GetNftPictures();
            }
        }
        public ActionResult GetImageFromBytes(string id)
        {
            NftPicture? picture = _nftPicturesRepository.GetNftPicture(id);
            if (picture == null)
            {
                return NotFound();
            }
            //if image is empty return default
            //if (picture.Image == null || picture..Length == 0)
            //{
            //    return File("/img/placeholder/user.jpg", "image/png");
            //}
            return File(picture.Image, "image/png");
        }
    }
}
