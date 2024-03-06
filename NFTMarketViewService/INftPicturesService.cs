using NFTMarketViewDAO;
using NFTMatketViewBusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketViewService
{
    public interface INftPicturesService
    {
        public NftPicture GetNftPicture(string id);
        public List<NftPicture> GetNftPictures();
        public void AddNftPicture(NftPicture picture);
        public void DeleteNftPicture(string id);
        public void UpdateNftPicture(NftPicture picture);
        
    }
}
