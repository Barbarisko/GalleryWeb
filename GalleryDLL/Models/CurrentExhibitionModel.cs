using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class CurrentExhibitionModel : BaseModel
    {
        private EmployeeModel employee;
        private ExhibitionModel exhibition;
        private ExhibitPlaceModel exhibitPlace;
        private List<ExhibitedPictureModel> exhibitedPictures;
        private List<TicketModel> tickets;

        //public int IdEmployee { get; set; }
        //public int IdExh { get; set; }
        //public int IdExhPlace { get; set; }

        //public Employee IdEmployeeNavigation { get; set; }
        //public Exhibition IdExhNavigation { get; set; }
        //public ExhibitPlace IdExhPlaceNavigation { get; set; }
        public EmployeeModel Employee { get => employee; set => employee = value; }
        public ExhibitionModel Exhibition { get => exhibition; set => exhibition = value; }
        public ExhibitPlaceModel ExhibitPlace { get => exhibitPlace; set => exhibitPlace = value; }
        public List<ExhibitedPictureModel> ExhibitedPictures { get => exhibitedPictures; set => exhibitedPictures = value; }
        public List<TicketModel> Tickets { get => tickets; set => tickets = value; }
    }
}
