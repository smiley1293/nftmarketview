using NFTMatketViewBusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketViewRepository
{
    public interface INftPicturesRepository
    {
        public NftPicture GetNftPicture(string id);
        public List<NftPicture> GetNftPictures();
        public void AddNftPicture(NftPicture picture);
        public void DeleteNftPicture(string id);
        public void UpdateNftPicture(NftPicture picture);

    }
}
