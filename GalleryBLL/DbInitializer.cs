using GalleryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryDAL
{
	public class DbInitializer
	{
		private static bool initialized = false;
		public static void Initialize(GalleryDbContext context)
		{
			if (initialized)
			{
				return;
			}

			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();

			Artist pending = new Artist()
			{
				Name = "Van",
				Surname = "Gog",
				Bday = Convert.ToDateTime("11.12.1890"),
				ArtDirection = "impressionizm"			
			};
			context.Artists.Add(pending);
			context.SaveChanges();

			initialized = true;
		}
	}
}
