using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NFTMarketViewRepository;
using NFTMatketViewBusinessObject.Models;

namespace NFTMarketViewRazorPages.Pages.NftPictures
{
    public class CreateModel : PageModel
    {
        private readonly INftPicturesRepository _nftPicturesRepository;

        public CreateModel(INftPicturesRepository nftPicturesRepository)
        {
            _nftPicturesRepository = nftPicturesRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public NftPicture NftPicture { get; set; } = default!;

        [BindProperty]
        public IFormFile? Image { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _nftPicturesRepository.GetNftPictures() == null || NftPicture == null)
            {
                return Page();
            }

            if (Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    Image.CopyTo(ms);
                    NftPicture.Image = Convert.ToBase64String(ms.ToArray());
                }
            }
            

            _nftPicturesRepository.AddNftPicture(NftPicture);

            return RedirectToPage("./Index");
        }
    }
}
