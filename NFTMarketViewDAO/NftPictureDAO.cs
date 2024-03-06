using NFTMatketViewBusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketViewDAO
{
    public class NftPictureDAO
    {
        private static NftPictureDAO instance = null;
        private readonly NFTWebManagementContext dbContext = null;

        private NftPictureDAO()
        {
            if (dbContext == null)
            {
                dbContext = new NFTWebManagementContext();
            }
        }

        public static NftPictureDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NftPictureDAO();
                }
                return instance;
            }
        }

        //dinh danh nft
        public NftPicture GetNftPicture(string id)
        {
            return dbContext.NftPictures.FirstOrDefault(m => m.NftId.Equals(id));
        }

        //List lay danh sach
        public List<NftPicture> GetNftPictures()
        {
            return dbContext.NftPictures.ToList();
        }

        //Add: them nft
        public void AddNftPicture(NftPicture picture)
        {
            NftPicture item = GetNftPicture(picture.NftId);
            if(item == null)
            {
                dbContext.Add(picture);
                dbContext.SaveChanges();
            }
        }

        //Delete:xoa
        public void DeleteNftPicture(string id)
        {
            NftPicture item = GetNftPicture(id);
            if(item != null)
            {
                dbContext.Remove(item);
                dbContext.SaveChanges();    
            }
        }

        //Update:cap nhat
        public void UpdateNftPicture(NftPicture picture)
        {
            NftPicture item = GetNftPicture(picture.NftId);
            if (item != null)
            {
                dbContext.Entry(item).CurrentValues.SetValues(picture);
                dbContext.SaveChanges();

            }
        }
    }
}
