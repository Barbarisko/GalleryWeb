using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class OwnerDTO:BaseDTO
    {
        private string surname;
        private string name;
        private string last_name;
        private string telephone;
        private string bank_acc;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Bank_acc { get => bank_acc; set => bank_acc = value; }
    }
}
