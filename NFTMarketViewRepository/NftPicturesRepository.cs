using NFTMarketViewDAO;
using NFTMatketViewBusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketViewRepository
{
    public class NftPicturesRepository : INftPicturesRepository
    {
        public void AddNftPicture(NftPicture picture) => NftPictureDAO.Instance.AddNftPicture(picture);

        

        public NftPicture GetNftPicture(string id) => NftPictureDAO.Instance.GetNftPicture(id);
        

        public List<NftPicture> GetNftPictures() => NftPictureDAO.Instance.GetNftPictures();
        public void DeleteNftPicture(string id) => NftPictureDAO.Instance.DeleteNftPicture(id);

        public void UpdateNftPicture(NftPicture picture) => NftPictureDAO.Instance.UpdateNftPicture(picture);

        
        
    }
}
