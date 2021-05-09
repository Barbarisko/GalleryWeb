using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class Owner
    {
        public Owner()
        {
            OwnedPictures = new HashSet<OwnedPicture>();
        }

        public int IdOwner { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string BankAcc { get; set; }

        public virtual ICollection<OwnedPicture> OwnedPictures { get; set; }
    }
}
