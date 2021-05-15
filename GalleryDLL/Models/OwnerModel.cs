using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class OwnerModel : BaseModel
    {
        private string surname;
        private string name;
        private string lastName;
        private string telephone;
        private string bankAcc;
        private List<OwnedPictureModel> ownedPictures;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string BankAcc { get => bankAcc; set => bankAcc = value; }

        public List<OwnedPictureModel> OwnedPictures { get => ownedPictures; set => ownedPictures = value; }
    }
}
