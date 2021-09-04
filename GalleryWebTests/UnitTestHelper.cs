using AutoMapper;
using GalleryBLL;
using NUnit.Framework;

namespace GalleryWebTests
{
	internal static class UnitTestsHelper
	{
		public static Mapper CreateMapperProfile()
		{
			var myProfile = new CustomMapper();
			var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));

			return new Mapper(configuration);
		}
	}
}