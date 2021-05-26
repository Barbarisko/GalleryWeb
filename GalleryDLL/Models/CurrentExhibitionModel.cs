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
        private int maxTicketNumber;
        private int idEmployee;
        private int idExh;
        private int idExhPlace;
        private DateTime? dateBegin;
        private DateTime? dateEnd;

        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int IdExh { get => idExh; set => idExh = value; }
        public int IdExhPlace { get => idExhPlace; set => idExhPlace = value; }
        public DateTime? DateBegin { get => dateBegin; set => dateBegin = value; }
        public DateTime? DateEnd { get => dateEnd; set => dateEnd = value; }

        //public Employee IdEmployeeNavigation { get; set; }
        //public Exhibition IdExhNavigation { get; set; }
        //public ExhibitPlace IdExhPlaceNavigation { get; set; }
        public EmployeeModel Employee { get => employee; set => employee = value; }
        public ExhibitionModel Exhibition { get => exhibition; set => exhibition = value; }
        public ExhibitPlaceModel ExhibitPlace { get => exhibitPlace; set => exhibitPlace = value; }
        public List<ExhibitedPictureModel> ExhibitedPictures { get => exhibitedPictures; set => exhibitedPictures = value; }
        public List<TicketModel> Tickets { get => tickets; set => tickets = value; }
        public int MaxTicketNumber { get => maxTicketNumber; set => maxTicketNumber = value; }
    }
}
