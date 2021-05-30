using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface IOwnershipService
    {
        IEnumerable<OwnedPictureModel> GetAllOwnedPics();
        void BuyPicture(int picId, int ownerId);
        OwnerModel GetOwner(int ownedPicid);
    }
}
