using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NFTMarketViewRepository;
using NFTMatketViewBusinessObject.Models;

namespace NFTMarketViewRazorPages.Pages.NftPictures
{
    public class EditModel : PageModel
    {
        private readonly INftPicturesRepository _nftPicturesRepository;

        public EditModel(INftPicturesRepository nftPicturesRepository)
        {
            _nftPicturesRepository = nftPicturesRepository;
        }

        [BindProperty]
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
            NftPicture = nftpicture;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach(NftPicture).State = EntityState.Modified;

            try
            {
                _nftPicturesRepository.UpdateNftPicture(NftPicture);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NftPictureExists(NftPicture.NftId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NftPictureExists(string id)
        {
          return _nftPicturesRepository.GetNftPicture(id) != null;
        }
    }
}
