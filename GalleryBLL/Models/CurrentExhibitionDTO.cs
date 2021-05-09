using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class CurrentExhibitionDTO:BaseDTO
    {
        private EmployeeDTO id_emp;
        private ExhibitionDTO id_exh;
        private ExhibitPlaceDTO id_exh_place;

        public EmployeeDTO Id_emp { get => id_emp; set => id_emp = value; }
        public ExhibitionDTO Id_exh { get => id_exh; set => id_exh = value; }
        public ExhibitPlaceDTO Id_exh_place { get => id_exh_place; set => id_exh_place = value; }
    }
}
