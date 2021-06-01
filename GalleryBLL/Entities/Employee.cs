using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Employee : BaseEntity
    {
        public Employee()
        {
            CurrentExhibitions = new HashSet<CurrentExhibition>();
        }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required]
        public DateTime? Bday { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        public string Telephone { get; set; }
        public int IdCity { get; set; }
        public string AddInfo { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<CurrentExhibition> CurrentExhibitions { get; set; }
    }
}
