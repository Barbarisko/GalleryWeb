using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
	public class FeedBackModel
	{
		[Required]
		[Display(Name = "Full name")]
		public string FullName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[DataType(DataType.Text)]
		public string Message { get; set; }

		public FeedBackModel()
        {

        }

	}
}
